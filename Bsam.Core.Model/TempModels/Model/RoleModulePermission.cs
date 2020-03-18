/**  版本信息模板在安装目录下，可自行修改。
* RoleModulePermission.cs
*
* 功 能： N/A
* 类 名： RoleModulePermission
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:50   N/A    初版
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
	/// RoleModulePermission:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RoleModulePermission
	{
		public RoleModulePermission()
		{}
		#region Model
		private int _id;
		private bool _isdeleted;
		private int _roleid;
		private int _moduleid;
		private int? _permissionid;
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
		public int RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ModuleId
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PermissionId
		{
			set{ _permissionid=value;}
			get{return _permissionid;}
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

