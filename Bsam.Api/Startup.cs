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
            // 添加基础服务（配置文件，日志处理服务等）
            services.AddSingleton(new Appsettings(Env.ContentRootPath));

            services.AddSqlSugarSetup();
            services.AddCorsSetup();

            // 添加Swagger生成器服务： 
            var ApiName = Appsettings.app("Startup", "ApiName");    // 获取appsettings.json配置文件中的串联节点的值：Bsam.Api
            services.AddSwaggerGen(c =>
            {

                // 注册swagger生成器，定义一个或多个Swagger 文档
                typeof(ApiVersions).GetEnumNames().ToList().ForEach(version =>
                {
                    c.SwaggerDoc(version, new OpenApiInfo()
                    {
                        Version = version,
                        Title = $"{ApiName} 接口文档——Netcore 3.1", // Swagger UI 界面的标题
                        Description = $"{ApiName} HTTP API " + version, // Swagger UI 界面的子标题
                        Contact = new OpenApiContact { Name = ApiName, Email = "Bsam.Api@xxx.com", Url = new Uri("https://www.jianshu.com/u/94102b59cc2a") },  // Swagger UI 界面的子标题下面的联系方式及链接
                        License = new OpenApiLicense { Name = ApiName + " 官方文档", Url = new Uri("http://apk.neters.club/.doc/") }// Swagger UI 界面的子标题下面的许可证

                    });
                });

                // 添加api的Xml注释
                var basePath = AppContext.BaseDirectory;
                var xmlpath = Path.Combine(basePath, "Bsam.Api.xml");
                c.IncludeXmlComments(xmlpath, true);

                // 添加model层的Xml注释
                var modelpath = Path.Combine(basePath, "Bsam.Core.Model.xml");
                c.IncludeXmlComments(modelpath);

                // 开启加权小锁（界面上需要授权认证的会有个小锁？）
                c.OperationFilter<AddResponseHeadersFilter>();
                c.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();

                // 在header中添加token，传递到后台
                c.OperationFilter<SecurityRequirementsOperationFilter>();

                // 必须是 oauth2
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传输) 直接在下框中输入Bearer {token}（注意两者之间是一个空格）\"",
                    Name = "Authorization",//jwt默认的参数名称
                    In = ParameterLocation.Header,//jwt默认存放Authorization信息的位置(请求头中)
                    Type = SecuritySchemeType.ApiKey
                });
            });

            // 添加授权服务：配置授权策略，
            // 在Controller中添加的特性 ：[Authorize(Roles = "System")]，多个角色/用户的授权写法繁琐，并且对角色的更新导致编码方式不能轻易改变
            // 在Controller中添加的特性 ：[Authorize(Policy = "Admin")]，采用基于策略授权，避免多个角色/用户的授权写法问题
            services.AddAuthorization(options=> {
                // 【基于策略授权】，好处就是不用在controller中，写多个 roles 。
                // 然后这么写 [Authorize(Policy = "Admin")]
                options.AddPolicy("System", policy => { policy.RequireRole("System").Build(); });//单独角色
                options.AddPolicy("Client", policy => policy.RequireRole("Client").Build());//单独角色
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin").Build());
                options.AddPolicy("SystemOrAdmin", policy => policy.RequireRole("Admin", "System"));//或的关系
                options.AddPolicy("SystemAndAdmin", policy => policy.RequireRole("Admin").RequireRole("System"));//且的关系
            });

            //#region 授权的认证

            ////读取配置文件
            //var symmetricKeyAsBase64 = AppSecretConfig.Audience_Secret_String;
            //var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            //var signingKey = new SymmetricSecurityKey(keyByteArray);
            //var Issuer = Appsettings.app(new string[] { "Audience", "Issuer" });
            //var Audience = Appsettings.app(new string[] { "Audience", "Audience" });

            //var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);



            //// 令牌验证参数(从配置文件中获取数据组合)
            //var tokenValidationParameters = new TokenValidationParameters
            //{
            //    ValidateIssuerSigningKey = true,
            //    IssuerSigningKey = signingKey,
            //    ValidateIssuer = true,
            //    ValidIssuer = Issuer,//发行人
            //    ValidateAudience = true,
            //    ValidAudience = Audience,//订阅人
            //    ValidateLifetime = true,
            //    ClockSkew = TimeSpan.FromSeconds(30),
            //    RequireExpirationTime = true,
            //};

            ////2.1【认证】
            //services.AddAuthentication(x =>
            //{
            //    //看这个单词熟悉么？没错，就是上边错误里的那个。
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})// 也可以直接写字符串，AddAuthentication("Bearer")
            // .AddJwtBearer(o =>
            // {
            //     // 认证参数设置
            //     o.TokenValidationParameters = tokenValidationParameters;
            //     // 注册 JwtBearer 事件
            //     o.Events = new JwtBearerEvents
            //     {
            //        endregion // Url传递token的方式，JwtBear获取到token
            //         OnMessageReceived = context => {
            //             context.Token = context.Request.Query["access_token"];
            //             return Task.CompletedTask;
            //         },

            //         // 认证失败事件
            //         OnAuthenticationFailed = context =>
            //         {
            //             // 如果过期，则把<是否过期>添加到，返回头信息中
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

            // 添加控制器服务
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

            // 这种是自定义认证方案中间件（不建议）
            //app.UseMiddleware<AuthHelper.JwtTokenAuth>();

            // 启用Swagger服务
            app.UseSwagger();

            // 启用中间件服务对swagger-ui,指定swagger json终结点
            app.UseSwaggerUI(c => {
                // 根据版本号名称倒叙，遍历展示
                var ApiName = Appsettings.app("Startup", "ApiName");    // 获取appsettings.json配置文件中的串联节点的值：Bsam.Api

                typeof(ApiVersions).GetEnumNames().OrderByDescending(e => e).ToList().ForEach(version => {
                    c.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"{ApiName} - {version}");
                });
                // 指定swagger ui 的首页，用这种反射方式指定资源流，C#中反射的资源需要设置index.html属性中【生成操作】为“嵌入的资源”，才能被以下反射方式获取到流
                // C#中资源的name的映射名字为：项目命名空间.资源文件所在文件夹名.资源文件名
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

        // 注意在CreateDefaultBuilder中，添加Autofac服务工厂
        public void ConfigureContainer(ContainerBuilder builder)
        {
            var basePath = Microsoft.DotNet.PlatformAbstractions.ApplicationEnvironment.ApplicationBasePath;
            //builder.RegisterType<AdvertisementServices>().As<IAdvertisementServices>();


            #region 带有接口层的服务注入


            var servicesDllFile = Path.Combine(basePath, "Bsam.Core.Services.dll");
            var repositoryDllFile = Path.Combine(basePath, "Bsam.Core.Repository.dll");

            if (!(File.Exists(servicesDllFile) && File.Exists(repositoryDllFile)))
            {
                throw new Exception("Repository.dll和service.dll 丢失，因为项目解耦了，所以需要先F6编译，再F5运行，请检查 bin 文件夹，并拷贝。");
            }



            //// AOP 开关，如果想要打开指定的功能，只需要在 appsettigns.json 对应对应 true 就行。
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

            // 获取 Service.dll 程序集服务，并注册
            var assemblysServices = Assembly.LoadFrom(servicesDllFile);
            builder.RegisterAssemblyTypes(assemblysServices)
                      .AsImplementedInterfaces()
                      .InstancePerDependency()
                      .EnableInterfaceInterceptors()//引用Autofac.Extras.DynamicProxy;
                      .InterceptedBy(cacheType.ToArray());//允许将拦截器服务的列表分配给注册。

            // 获取 Repository.dll 程序集服务，并注册
            var assemblysRepository = Assembly.LoadFrom(repositoryDllFile);
            builder.RegisterAssemblyTypes(assemblysRepository)
                   .AsImplementedInterfaces()
                   .InstancePerDependency();

            #endregion

            #region 没有接口层的服务层注入

            //因为没有接口层，所以不能实现解耦，只能用 Load 方法。
            //注意如果使用没有接口的服务，并想对其使用 AOP 拦截，就必须设置为虚方法
            //var assemblysServicesNoInterfaces = Assembly.Load("Blog.Core.Services");
            //builder.RegisterAssemblyTypes(assemblysServicesNoInterfaces);

            #endregion

            //#region 没有接口的单独类 class 注入

            ////只能注入该类中的虚方法
            //builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(Love)))
            //    .EnableClassInterceptors()
            //    .InterceptedBy(cacheType.ToArray());

            //#endregion

        }
    }
}
