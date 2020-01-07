using System;
using System.Collections.Generic;
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

namespace Bsam.Swagger
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // ����Swagger���������� ע��swagger������������һ������Swagger �ĵ�
            var version = "v1";
            var ApiName = "Bsam.Api";
            services.AddSwaggerGen(c=> {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Version = version,
                    Title = $"{ApiName} �ӿ��ĵ�����Netcore 3.1", // Swagger UI ����ı���
                    Description = $"{ApiName} HTTP API " + version, // Swagger UI ������ӱ���
                    Contact = new  OpenApiContact { Name = ApiName, Email = "Blog.Core@xxx.com", Url= new Uri("https://www.jianshu.com/u/94102b59cc2a") },  // Swagger UI ������ӱ����������ϵ��ʽ������
                    License = new  OpenApiLicense { Name = ApiName + " �ٷ��ĵ�", Url = new Uri("http://apk.neters.club/.doc/") }// Swagger UI ������ӱ������������֤

                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseAuthorization();


            // ����Swagger����
            app.UseSwagger();

            // �����м�������swagger-ui,ָ��swagger json�ս��
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}