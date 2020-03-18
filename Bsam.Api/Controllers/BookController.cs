using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bsam.Core.Common.Helper;
using Bsam.Core.IServices;
using Bsam.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Bsam.Core.Model.Models;
using Bsam.Cores;
using StackExchange.Profiling;

namespace Bsam.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        readonly IBlogArticleServices _blogArticleServices;
        //readonly IRedisCacheManager _redisCacheManager;
        //private readonly ILogger<BookController> _logger;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="blogArticleServices"></param>
        public BookController(IBlogArticleServices blogArticleServices)
        //IRedisCacheManager redisCacheManager, 
        //ILogger<BookController> logger
        {
            _blogArticleServices = blogArticleServices;
            //_redisCacheManager = redisCacheManager;
            //_logger = logger;
        }
        [HttpGet]
        public async Task<object> Page(int page, string bcategory = "技术博文", string key = "")
        {
            //// 读取json数据文件，把文件转换为实体类            
            //string filePath = $"{AppContext.BaseDirectory}book.json";
            //var objJson = FileHelper.ReadFile(filePath, System.Text.Encoding.Default);
            //List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(objJson);


            int intTotalCount = 6;
            int total;
            int totalCount = 1;

            List<BlogArticle> blogArticleList = new List<BlogArticle>();
            blogArticleList = await _blogArticleServices.Query(a => a.bcategory == bcategory && a.IsDeleted == false);

            total = blogArticleList.Count();
            totalCount = (Math.Ceiling(total.ObjToDecimal() / intTotalCount.ObjToDecimal())).ObjToInt();

            using (MiniProfiler.Current.Step("获取成功后，开始处理最终数据"))
            {
                blogArticleList = blogArticleList.OrderByDescending(d => d.bID).Skip((page - 1) * intTotalCount).Take(intTotalCount).ToList();

                foreach (var item in blogArticleList)
                {
                    if (!string.IsNullOrEmpty(item.bcontent))
                    {
                        item.bRemark = (HtmlHelper.ReplaceHtmlTag(item.bcontent)).Length >= 200 ? (HtmlHelper.ReplaceHtmlTag(item.bcontent)).Substring(0, 200) : (HtmlHelper.ReplaceHtmlTag(item.bcontent));
                        int totalLength = 500;
                        if (item.bcontent.Length > totalLength)
                        {
                            item.bcontent = item.bcontent.Substring(0, totalLength);
                        }
                    }
                }
            }

            return Ok(new
            {
                success = true,
                page,
                total,
                pageCount = totalCount,
                data = blogArticleList
            });
        }
    }
}