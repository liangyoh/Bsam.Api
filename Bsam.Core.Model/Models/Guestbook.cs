/**  版本信息模板在安装目录下，可自行修改。
* Guestbook.cs
*
* 功 能： N/A
* 类 名： Guestbook
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
	/// Guestbook:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Guestbook
	{
		public Guestbook()
		{}
		#region Model
		private int _id;
		private int _blogid;
		private DateTime _createdate;
		private string _username;
		private string _phone;
		private string _qq;
		private string _body;
		private string _ip;
		private bool _isshow;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int blogId
		{
			set{ _blogid=value;}
			get{return _blogid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime createdate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string body
		{
			set{ _body=value;}
			get{return _body;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isshow
		{
			set{ _isshow=value;}
			get{return _isshow;}
		}
		#endregion Model

	}
}

