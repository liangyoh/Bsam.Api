using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bsam.Api.SwaggerHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static Bsam.Api.SwaggerHelper.CustomerApiVersion;

namespace Bsam.Api.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        /************************************************/
        // 如果不需要使用Http协议带名称的，比如这种 [HttpGet]
        // 就可以按照下边的写法去写，在方法上直接加特性 [CustomRoute(ApiVersions.v1, "apbs")]
        // 反之，如果你需要http协议带名称，请看 V2 文件夹的方法
        /************************************************/

        [HttpGet]
        [CustomRoute(ApiVersions.V1, "apbs")]
        public IEnumerable<string> Get()
        {
            return new string[] { "第一版的 apbs" };
        }
    }
}
