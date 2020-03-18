/**  版本信息模板在安装目录下，可自行修改。
* BlogArticle.cs
*
* 功 能： N/A
* 类 名： BlogArticle
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:33   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Bsam.Core.Model.Models
{
	/// <summary>
	/// BlogArticle:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlogArticle
	{
		public BlogArticle()
		{}
		#region Model
		private int _bid;
		private string _bsubmitter;
		private string _btitle;
		private string _bcategory;
		private string _bcontent;
		private int _btraffic;
		private int _bcommentnum;
		private DateTime _bupdatetime;
		private DateTime _bcreatetime;
		private string _bremark;
		private bool _isdeleted;
		/// <summary>
		/// 
		/// </summary>
		public int bID
		{
			set{ _bid=value;}
			get{return _bid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bsubmitter
		{
			set{ _bsubmitter=value;}
			get{return _bsubmitter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string btitle
		{
			set{ _btitle=value;}
			get{return _btitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bcategory
		{
			set{ _bcategory=value;}
			get{return _bcategory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bcontent
		{
			set{ _bcontent=value;}
			get{return _bcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int btraffic
		{
			set{ _btraffic=value;}
			get{return _btraffic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int bcommentNum
		{
			set{ _bcommentnum=value;}
			get{return _bcommentnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime bUpdateTime
		{
			set{ _bupdatetime=value;}
			get{return _bupdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime bCreateTime
		{
			set{ _bcreatetime=value;}
			get{return _bcreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bRemark
		{
			set{ _bremark=value;}
			get{return _bremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsDeleted
		{
			set{ _isdeleted=value;}
			get{return _isdeleted;}
		}
		#endregion Model

	}
}

