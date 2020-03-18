using System;
using System.Collections.Generic;
using System.Text;

namespace Bsam.Core.Model
{
    public class Book
    {
        /// <summary>
        /// 
        /// </summary>
        public int bID { get; set; }
        /// <summary>
        /// 发布人
        /// </summary>
        public string bsubmitter { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string btitle { get; set; }
        /// <summary>
        /// 文章分类
        /// </summary>
        public string bcategory { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public string bcontent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int btraffic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int bcommentNum { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public string bUpdateTime { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string bCreateTime { get; set; }
        /// <summary>
        ///  备注
        /// </summary>
        public string bRemark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDeleted { get; set; }
    }

    public class BookList
    {
        /// <summary>
        /// 
        /// </summary>
        public Book Book { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trimArray { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string remove { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unique { get; set; }
    }

}