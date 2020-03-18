using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Bsam.Core.Common;
using static Bsam.Api.SwaggerHelper.CustomerApiVersion;
using System.Reflection;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Bsam.Core.Common.AppConfig;
using System.Text;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Bsam.Api.Extensions;

namespace Bsam.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Env = env;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Env { get;  }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // ��ӻ������������ļ�����־�������ȣ�
            services.AddSingleton(new Appsettings(Env.ContentRootPath));

            services.AddSqlSugarSetup();
            services.AddCorsSetup();

            // ���Swagger���������� 
            var ApiName = Appsettings.app("Startup", "ApiName");    // ��ȡappsettings.json�����ļ��еĴ����ڵ��ֵ��Bsam.Api
            services.AddSwaggerGen(c =>
            {

                // ע��swagger������������һ������Swagger �ĵ�
                typeof(ApiVersions).GetEnumNames().ToList().ForEach(version =>
                {
                    c.SwaggerDoc(version, new OpenApiInfo()
                    {
                        Version = version,
                        Title = $"{ApiName} �ӿ��ĵ�����Netcore 3.1", // Swagger UI ����ı���
                        Description = $"{ApiName} HTTP API " + version, // Swagger UI ������ӱ���
                        Contact = new OpenApiContact { Name = ApiName, Email = "Bsam.Api@xxx.com", Url = new Uri("https://www.jianshu.com/u/94102b59cc2a") },  // Swagger UI ������ӱ����������ϵ��ʽ������
                        License = new OpenApiLicense { Name = ApiName + " �ٷ��ĵ�", Url = new Uri("http://apk.neters.club/.doc/") }// Swagger UI ������ӱ�����������֤

                    });
                });

                // ���api��Xmlע��
                var basePath = AppContext.BaseDirectory;
                var xmlpath = Path.Combine(basePath, "Bsam.Api.xml");
                c.IncludeXmlComments(xmlpath, true);

                // ���model���Xmlע��
                var modelpath = Path.Combine(basePath, "Bsam.Core.Model.xml");
                c.IncludeXmlComments(modelpath);

                // ������ȨС������������Ҫ��Ȩ��֤�Ļ��и�С������
                c.OperationFilter<AddResponseHeadersFilter>();
                c.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();

                // ��header�����token�����ݵ���̨
                c.OperationFilter<SecurityRequirementsOperationFilter>();

                // ������ oauth2
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "JWT��Ȩ(���ݽ�������ͷ�н��д���) ֱ�����¿�������Bearer {token}��ע������֮����һ���ո�\"",
                    Name = "Authorization",//jwtĬ�ϵĲ�������
                    In = ParameterLocation.Header,//jwtĬ�ϴ��Authorization��Ϣ��λ��(����ͷ��)
                    Type = SecuritySchemeType.ApiKey
                });
            });

            // �����Ȩ����������Ȩ���ԣ�
            // ��Controller����ӵ����� ��[Authorize(Roles = "System")]�������ɫ/�û�����Ȩд�����������ҶԽ�ɫ�ĸ��µ��±��뷽ʽ�������׸ı�
            // ��Controller����ӵ����� ��[Authorize(Policy = "Admin")]�����û��ڲ�����Ȩ����������ɫ/�û�����Ȩд������
            services.AddAuthorization(options=> {
                // �����ڲ�����Ȩ�����ô����ǲ�����controller�У�д��� roles ��
                // Ȼ����ôд [Authorize(Policy = "Admin")]
                options.AddPolicy("System", policy => { policy.RequireRole("System").Build(); });//������ɫ
                options.AddPolicy("Client", policy => policy.RequireRole("Client").Build());//������ɫ
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin").Build());
                options.AddPolicy("SystemOrAdmin", policy => policy.RequireRole("Admin", "System"));//��Ĺ�ϵ
                options.AddPolicy("SystemAndAdmin", policy => policy.RequireRole("Admin").RequireRole("System"));//�ҵĹ�ϵ
            });

            //#region ��Ȩ����֤

            ////��ȡ�����ļ�
            //var symmetricKeyAsBase64 = AppSecretConfig.Audience_Secret_String;
            //var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            //var signingKey = new SymmetricSecurityKey(keyByteArray);
            //var Issuer = Appsettings.app(new string[] { "Audience", "Issuer" });
            //var Audience = Appsettings.app(new string[] { "Audience", "Audience" });

            //var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);



            //// ������֤����(�������ļ��л�ȡ�������)
            //var tokenValidationParameters = new TokenValidationParameters
            //{
            //    ValidateIssuerSigningKey = true,
            //    IssuerSigningKey = signingKey,
            //    ValidateIssuer = true,
            //    ValidIssuer = Issuer,//������
            //    ValidateAudience = true,
            //    ValidAudience = Audience,//������
            //    ValidateLifetime = true,
            //    ClockSkew = TimeSpan.FromSeconds(30),
            //    RequireExpirationTime = true,
            //};

            ////2.1����֤��
            //services.AddAuthentication(x =>
            //{
            //    //�����������Ϥô��û�������ϱߴ�������Ǹ���
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})// Ҳ����ֱ��д�ַ�����AddAuthentication("Bearer")
            // .AddJwtBearer(o =>
            // {
            //     // ��֤��������
            //     o.TokenValidationParameters = tokenValidationParameters;
            //     // ע�� JwtBearer �¼�
            //     o.Events = new JwtBearerEvents
            //     {
            //        endregion // Url����token�ķ�ʽ��JwtBear��ȡ��token
            //         OnMessageReceived = context => {
            //             context.Token = context.Request.Query["access_token"];
            //             return Task.CompletedTask;
            //         },

            //         // ��֤ʧ���¼�
            //         OnAuthenticationFailed = context =>
            //         {
            //             // ������ڣ����<�Ƿ����>��ӵ�������ͷ��Ϣ��
            //             if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
            //             {
            //                 context.Response.Headers.Add("Token-Expired", "true");
            //             }
            //             return Task.CompletedTask;
            //         }
            //     };

            // });

            //#


            services.AddHttpContextSetup();
            services.AddAuthorizationSetup();

            // ��ӿ���������
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            // �������Զ�����֤�����м���������飩
            //app.UseMiddleware<AuthHelper.JwtTokenAuth>();

            // ����Swagger����
            app.UseSwagger();

            // �����м�������swagger-ui,ָ��swagger json�ս��
            app.UseSwaggerUI(c => {
                // ���ݰ汾�����Ƶ��𣬱���չʾ
                var ApiName = Appsettings.app("Startup", "ApiName");    // ��ȡappsettings.json�����ļ��еĴ����ڵ��ֵ��Bsam.Api

                typeof(ApiVersions).GetEnumNames().OrderByDescending(e => e).ToList().ForEach(version => {
                    c.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"{ApiName} - {version}");
                });
                // ָ��swagger ui ����ҳ�������ַ��䷽ʽָ����Դ����C#�з������Դ��Ҫ����index.html�����С����ɲ�����Ϊ��Ƕ�����Դ�������ܱ����·��䷽ʽ��ȡ����
                // C#����Դ��name��ӳ������Ϊ����Ŀ�����ռ�.��Դ�ļ������ļ�����.��Դ�ļ���
                var basePath = AppContext.BaseDirectory;
                //c.IndexStream = () => GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Bsam.Api.index.html");
                //c.InjectJavascript(@".\wwwroot\SwaggerUI\js\swagger.js");
                c.RoutePrefix = string.Empty;
            });


            app.UseCors("LimitRequests");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                //endpoints.MapHub<ChatHub>("/api2/chatHub");
            });
        }

        // ע����CreateDefaultBuilder�У����Autofac���񹤳�
        public void ConfigureContainer(ContainerBuilder builder)
        {
            var basePath = Microsoft.DotNet.PlatformAbstractions.ApplicationEnvironment.ApplicationBasePath;
            //builder.RegisterType<AdvertisementServices>().As<IAdvertisementServices>();


            #region ���нӿڲ�ķ���ע��


            var servicesDllFile = Path.Combine(basePath, "Bsam.Core.Services.dll");
            var repositoryDllFile = Path.Combine(basePath, "Bsam.Core.Repository.dll");

            if (!(File.Exists(servicesDllFile) && File.Exists(repositoryDllFile)))
            {
                throw new Exception("Repository.dll��service.dll ��ʧ����Ϊ��Ŀ�����ˣ�������Ҫ��F6���룬��F5���У����� bin �ļ��У���������");
            }



            //// AOP ���أ������Ҫ��ָ���Ĺ��ܣ�ֻ��Ҫ�� appsettigns.json ��Ӧ��Ӧ true ���С�
            var cacheType = new List<Type>();
            //if (Appsettings.app(new string[] { "AppSettings", "RedisCachingAOP", "Enabled" }).ObjToBool())
            //{
            //    builder.RegisterType<BlogRedisCacheAOP>();
            //    cacheType.Add(typeof(BlogRedisCacheAOP));
            //}
            //if (Appsettings.app(new string[] { "AppSettings", "MemoryCachingAOP", "Enabled" }).ObjToBool())
            //{
            //    builder.RegisterType<BlogCacheAOP>();
            //    cacheType.Add(typeof(BlogCacheAOP));
            //}
            //if (Appsettings.app(new string[] { "AppSettings", "TranAOP", "Enabled" }).ObjToBool())
            //{
            //    builder.RegisterType<BlogTranAOP>();
            //    cacheType.Add(typeof(BlogTranAOP));
            //}
            //if (Appsettings.app(new string[] { "AppSettings", "LogAOP", "Enabled" }).ObjToBool())
            //{
            //    builder.RegisterType<BlogLogAOP>();
            //    cacheType.Add(typeof(BlogLogAOP));
            //}

            // ��ȡ Service.dll ���򼯷��񣬲�ע��
            var assemblysServices = Assembly.LoadFrom(servicesDllFile);
            builder.RegisterAssemblyTypes(assemblysServices)
                      .AsImplementedInterfaces()
                      .InstancePerDependency()
                      .EnableInterfaceInterceptors()//����Autofac.Extras.DynamicProxy;
                      .InterceptedBy(cacheType.ToArray());//����������������б�����ע�ᡣ

            // ��ȡ Repository.dll ���򼯷��񣬲�ע��
            var assemblysRepository = Assembly.LoadFrom(repositoryDllFile);
            builder.RegisterAssemblyTypes(assemblysRepository)
                   .AsImplementedInterfaces()
                   .InstancePerDependency();

            #endregion

            #region û�нӿڲ�ķ����ע��

            //��Ϊû�нӿڲ㣬���Բ���ʵ�ֽ��ֻ���� Load ������
            //ע�����ʹ��û�нӿڵķ��񣬲������ʹ�� AOP ���أ��ͱ�������Ϊ�鷽��
            //var assemblysServicesNoInterfaces = Assembly.Load("Blog.Core.Services");
            //builder.RegisterAssemblyTypes(assemblysServicesNoInterfaces);

            #endregion

            //#region û�нӿڵĵ����� class ע��

            ////ֻ��ע������е��鷽��
            //builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(Love)))
            //    .EnableClassInterceptors()
            //    .InterceptedBy(cacheType.ToArray());

            //#endregion

        }
    }
}
