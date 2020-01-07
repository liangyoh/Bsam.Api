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

            // 添加Swagger生成器服务： 注册swagger生成器，定义一个或多个Swagger 文档
            var version = "v1";
            var ApiName = "Bsam.Api";
            services.AddSwaggerGen(c=> {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Version = version,
                    Title = $"{ApiName} 接口文档——Netcore 3.1", // Swagger UI 界面的标题
                    Description = $"{ApiName} HTTP API " + version, // Swagger UI 界面的子标题
                    Contact = new  OpenApiContact { Name = ApiName, Email = "Blog.Core@xxx.com", Url= new Uri("https://www.jianshu.com/u/94102b59cc2a") },  // Swagger UI 界面的子标题下面的联系方式及链接
                    License = new  OpenApiLicense { Name = ApiName + " 官方文档", Url = new Uri("http://apk.neters.club/.doc/") }// Swagger UI 界面的子标题下面的许可证

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


            // 启用Swagger服务
            app.UseSwagger();

            // 启用中间件服务对swagger-ui,指定swagger json终结点
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
