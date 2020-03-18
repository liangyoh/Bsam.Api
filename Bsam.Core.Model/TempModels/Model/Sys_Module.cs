/**  版本信息模板在安装目录下，可自行修改。
* Sys_Module.cs
*
* 功 能： N/A
* 类 名： Sys_Module
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:03:00   N/A    初版
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
	/// Sys_Module:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_Module
	{
		public Sys_Module()
		{}
		#region Model
		private int _id;
		private string _moduletype;
		private string _modulecode;
		private string _modulename;
		private string _moduledesc;
		private string _moduleconfig;
		private string _path;
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
		public string ModuleType
		{
			set{ _moduletype=value;}
			get{return _moduletype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ModuleCode
		{
			set{ _modulecode=value;}
			get{return _modulecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ModuleName
		{
			set{ _modulename=value;}
			get{return _modulename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ModuleDesc
		{
			set{ _moduledesc=value;}
			get{return _moduledesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ModuleConfig
		{
			set{ _moduleconfig=value;}
			get{return _moduleconfig;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Path
		{
			set{ _path=value;}
			get{return _path;}
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

