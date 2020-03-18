/**  版本信息模板在安装目录下，可自行修改。
* sysUserInfo.cs
*
* 功 能： N/A
* 类 名： sysUserInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:03:33   N/A    初版
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
	/// sysUserInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sysUserInfo
	{
		public sysUserInfo()
		{}
		#region Model
		private int _uid;
		private string _uloginname;
		private string _uloginpwd;
		private string _urealname;
		private int _ustatus;
		private string _uremark;
		private DateTime _ucreatetime;
		private DateTime _uupdatetime;
		private DateTime _ulasterrtime;
		private int _uerrorcount;
		private string _name;
		private int? _sex;
		private int? _age;
		private DateTime? _birth;
		private string _addr;
		private bool _tdisdelete;
		/// <summary>
		/// 
		/// </summary>
		public int uID
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uLoginName
		{
			set{ _uloginname=value;}
			get{return _uloginname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uLoginPWD
		{
			set{ _uloginpwd=value;}
			get{return _uloginpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uRealName
		{
			set{ _urealname=value;}
			get{return _urealname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int uStatus
		{
			set{ _ustatus=value;}
			get{return _ustatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uRemark
		{
			set{ _uremark=value;}
			get{return _uremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime uCreateTime
		{
			set{ _ucreatetime=value;}
			get{return _ucreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime uUpdateTime
		{
			set{ _uupdatetime=value;}
			get{return _uupdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime uLastErrTime
		{
			set{ _ulasterrtime=value;}
			get{return _ulasterrtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int uErrorCount
		{
			set{ _uerrorcount=value;}
			get{return _uerrorcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? birth
		{
			set{ _birth=value;}
			get{return _birth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string addr
		{
			set{ _addr=value;}
			get{return _addr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool tdIsDelete
		{
			set{ _tdisdelete=value;}
			get{return _tdisdelete;}
		}
		#endregion Model

	}
}

