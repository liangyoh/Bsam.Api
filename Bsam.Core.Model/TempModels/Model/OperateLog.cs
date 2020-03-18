/**  版本信息模板在安装目录下，可自行修改。
* OperateLog.cs
*
* 功 能： N/A
* 类 名： OperateLog
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:43   N/A    初版
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
	/// OperateLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OperateLog
	{
		public OperateLog()
		{}
		#region Model
		private int _id;
		private bool _isdeleted;
		private string _area;
		private string _controller;
		private string _action;
		private string _ipaddress;
		private string _description;
		private DateTime? _logtime;
		private string _loginname;
		private int _userid;
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
		public string IPAddress
		{
			set{ _ipaddress=value;}
			get{return _ipaddress;}
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
		public DateTime? LogTime
		{
			set{ _logtime=value;}
			get{return _logtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginName
		{
			set{ _loginname=value;}
			get{return _loginname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		#endregion Model

	}
}

