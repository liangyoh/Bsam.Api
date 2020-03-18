/**  版本信息模板在安装目录下，可自行修改。
* Sys_Permission.cs
*
* 功 能： N/A
* 类 名： Sys_Permission
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:03:04   N/A    初版
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
	/// Sys_Permission:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_Permission
	{
		public Sys_Permission()
		{}
		#region Model
		private int _id;
		private string _permissionname;
		private string _permissiondesc;
		private string _requesttype;
		private string _clienttype;
		private int? _moduleid;
		private DateTime? _datetimecreated;
		private string _usercreator;
		private DateTime? _datetimemodified;
		private string _usermodified;
		private bool _state;
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
		public string PermissionName
		{
			set{ _permissionname=value;}
			get{return _permissionname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PermissionDesc
		{
			set{ _permissiondesc=value;}
			get{return _permissiondesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RequestType
		{
			set{ _requesttype=value;}
			get{return _requesttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientType
		{
			set{ _clienttype=value;}
			get{return _clienttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ModuleId
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DateTimeCreated
		{
			set{ _datetimecreated=value;}
			get{return _datetimecreated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserCreator
		{
			set{ _usercreator=value;}
			get{return _usercreator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DateTimeModified
		{
			set{ _datetimemodified=value;}
			get{return _datetimemodified;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserModified
		{
			set{ _usermodified=value;}
			get{return _usermodified;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool State
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

