/**  版本信息模板在安装目录下，可自行修改。
* Module.cs
*
* 功 能： N/A
* 类 名： Module
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:40   N/A    初版
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
	/// Module:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Module
	{
		public Module()
		{}
		#region Model
		private int _id;
		private bool _isdeleted;
		private int? _parentid;
		private string _name;
		private string _linkurl;
		private string _area;
		private string _controller;
		private string _action;
		private string _icon;
		private string _code;
		private int _ordersort;
		private string _description;
		private bool _ismenu;
		private bool _enabled;
		private int? _createid;
		private string _createby;
		private DateTime? _createtime;
		private int? _modifyid;
		private string _modifyby;
		private DateTime? _modifytime;
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
		public bool IsDeleted
		{
			set{ _isdeleted=value;}
			get{return _isdeleted;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LinkUrl
		{
			set{ _linkurl=value;}
			get{return _linkurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Area
		{
			set{ _area=value;}
			get{return _area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Controller
		{
			set{ _controller=value;}
			get{return _controller;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Action
		{
			set{ _action=value;}
			get{return _action;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Icon
		{
			set{ _icon=value;}
			get{return _icon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderSort
		{
			set{ _ordersort=value;}
			get{return _ordersort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsMenu
		{
			set{ _ismenu=value;}
			get{return _ismenu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Enabled
		{
			set{ _enabled=value;}
			get{return _enabled;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CreateId
		{
			set{ _createid=value;}
			get{return _createid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreateBy
		{
			set{ _createby=value;}
			get{return _createby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ModifyId
		{
			set{ _modifyid=value;}
			get{return _modifyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ModifyBy
		{
			set{ _modifyby=value;}
			get{return _modifyby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ModifyTime
		{
			set{ _modifytime=value;}
			get{return _modifytime;}
		}
		#endregion Model

	}
}

