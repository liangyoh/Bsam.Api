using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsam.Core.Common
{
    /// <summary>
    /// appsettings.json操作类
    /// </summary>
    public class Appsettings
    {
        /// <summary>
        /// 配置对象
        /// </summary>
        static IConfiguration Configuration;

        /// <summary>
        /// 初始化配置对象
        /// </summary>
        /// <param name="contentPath"></param>
        public Appsettings(string contentPath)
        {
            string path = "appsettings.json";

            //如果你把配置文件 是 根据环境变量来分开了，可以这样写
            //Path = $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json";

            Configuration = new ConfigurationBuilder()
                .SetBasePath(contentPath)
                .Add(new JsonConfigurationSource() { Path = path, Optional=false, ReloadOnChange=true })    //这样的话，可以直接读目录里的json文件，而不是 bin 文件夹下的，所以不用修改复制属性
                .Build();
        }

        /// <summary>
        /// 返回Json中的指定（路径）节点的值
        /// </summary>
        /// <param name="sessions"></param>
        /// <returns></returns>
        public static string app(params string[] sessions)
        {
            try
            {
                if (sessions.Any())
                {
                    return Configuration[string.Join(":", sessions)];
                }
            }
            catch
            { 
            }

            return string.Empty;
        }
    }
}
