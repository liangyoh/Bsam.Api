/**  版本信息模板在安装目录下，可自行修改。
* PasswordLib.cs
*
* 功 能： N/A
* 类 名： PasswordLib
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:44   N/A    初版
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
	/// PasswordLib:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PasswordLib
	{
		public PasswordLib()
		{}
		#region Model
		private int _plid;
		private bool _isdeleted;
		private string _plurl;
		private string _plpwd;
		private string _placcountname;
		private int? _plstatus;
		private int? _plerrorcount;
		private string _plhintpwd;
		private string _plhintquestion;
		private DateTime? _plcreatetime;
		private DateTime? _plupdatetime;
		private DateTime? _pllasterrtime;
		private string _test;
		/// <summary>
		/// 
		/// </summary>
		public int PLID
		{
			set{ _plid=value;}
			get{return _plid;}
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
		public string plURL
		{
			set{ _plurl=value;}
			get{return _plurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plPWD
		{
			set{ _plpwd=value;}
			get{return _plpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plAccountName
		{
			set{ _placcountname=value;}
			get{return _placcountname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? plStatus
		{
			set{ _plstatus=value;}
			get{return _plstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? plErrorCount
		{
			set{ _plerrorcount=value;}
			get{return _plerrorcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plHintPwd
		{
			set{ _plhintpwd=value;}
			get{return _plhintpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plHintquestion
		{
			set{ _plhintquestion=value;}
			get{return _plhintquestion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? plCreateTime
		{
			set{ _plcreatetime=value;}
			get{return _plcreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? plUpdateTime
		{
			set{ _plupdatetime=value;}
			get{return _plupdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? plLastErrTime
		{
			set{ _pllasterrtime=value;}
			get{return _pllasterrtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string test
		{
			set{ _test=value;}
			get{return _test;}
		}
		#endregion Model

	}
}

