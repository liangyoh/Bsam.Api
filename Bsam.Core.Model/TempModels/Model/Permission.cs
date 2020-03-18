/**  版本信息模板在安装目录下，可自行修改。
* Permission.cs
*
* 功 能： N/A
* 类 名： Permission
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:46   N/A    初版
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
	/// Permission:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Permission
	{
		public Permission()
		{}
		#region Model
		private int _id;
		private string _code;
		private string _name;
		private bool _isbutton;
		private bool _ishide;
		private string _func;
		private int _pid;
		private int _mid;
		private int _ordersort;
		private string _icon;
		private string _description;
		private bool _enabled;
		private int? _createid;
		private string _createby;
		private DateTime? _createtime;
		private int? _modifyid;
		private string _modifyby;
		private DateTime? _modifytime;
		private bool _isdeleted;
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
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
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
		public bool IsButton
		{
			set{ _isbutton=value;}
			get{return _isbutton;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsHide
		{
			set{ _ishide=value;}
			get{return _ishide;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Func
		{
			set{ _func=value;}
			get{return _func;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Pid
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Mid
		{
			set{ _mid=value;}
			get{return _mid;}
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
		public string Icon
		{
			set{ _icon=value;}
			get{return _icon;}
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

