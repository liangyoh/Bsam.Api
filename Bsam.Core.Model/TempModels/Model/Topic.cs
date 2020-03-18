/**  版本信息模板在安装目录下，可自行修改。
* Topic.cs
*
* 功 能： N/A
* 类 名： Topic
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:03:24   N/A    初版
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
	/// Topic:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Topic
	{
		public Topic()
		{}
		#region Model
		private int _id;
		private string _tlogo;
		private string _tname;
		private string _tdetail;
		private string _tauthor;
		private string _tsectenddetail;
		private bool _tisdelete;
		private int _tread;
		private int _tcommend;
		private int _tgood;
		private DateTime _tcreatetime;
		private DateTime _tupdatetime;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tLogo
		{
			set{ _tlogo=value;}
			get{return _tlogo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tName
		{
			set{ _tname=value;}
			get{return _tname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tDetail
		{
			set{ _tdetail=value;}
			get{return _tdetail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tAuthor
		{
			set{ _tauthor=value;}
			get{return _tauthor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tSectendDetail
		{
			set{ _tsectenddetail=value;}
			get{return _tsectenddetail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool tIsDelete
		{
			set{ _tisdelete=value;}
			get{return _tisdelete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tRead
		{
			set{ _tread=value;}
			get{return _tread;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tCommend
		{
			set{ _tcommend=value;}
			get{return _tcommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tGood
		{
			set{ _tgood=value;}
			get{return _tgood;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime tCreatetime
		{
			set{ _tcreatetime=value;}
			get{return _tcreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime tUpdatetime
		{
			set{ _tupdatetime=value;}
			get{return _tupdatetime;}
		}
		#endregion Model

	}
}

