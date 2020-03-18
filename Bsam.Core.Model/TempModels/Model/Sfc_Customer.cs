/**  版本信息模板在安装目录下，可自行修改。
* Sfc_Customer.cs
*
* 功 能： N/A
* 类 名： Sfc_Customer
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:52   N/A    初版
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
	/// Sfc_Customer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sfc_Customer
	{
		public Sfc_Customer()
		{}
		#region Model
		private int? _id;
		private string _customercode;
		private string _customername;
		private string _customershortname;
		private string _customerphone;
		private string _customerwebchat;
		private string _enterprisename;
		private string _enterpriselegal;
		private string _enterpriseaddress;
		private string _enterprisephone;
		private DateTime? _datetimecreated;
		private string _usercreator;
		private DateTime? _datetimemodified;
		private string _usermodified;
		private bool _state;
		private string _orgid;
		/// <summary>
		/// 
		/// </summary>
		public int? Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerCode
		{
			set{ _customercode=value;}
			get{return _customercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerName
		{
			set{ _customername=value;}
			get{return _customername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerShortName
		{
			set{ _customershortname=value;}
			get{return _customershortname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerPhone
		{
			set{ _customerphone=value;}
			get{return _customerphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerWebchat
		{
			set{ _customerwebchat=value;}
			get{return _customerwebchat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnterpriseName
		{
			set{ _enterprisename=value;}
			get{return _enterprisename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnterpriseLegal
		{
			set{ _enterpriselegal=value;}
			get{return _enterpriselegal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnterpriseAddress
		{
			set{ _enterpriseaddress=value;}
			get{return _enterpriseaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnterprisePhone
		{
			set{ _enterprisephone=value;}
			get{return _enterprisephone;}
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
		/// <summary>
		/// 
		/// </summary>
		public string OrgId
		{
			set{ _orgid=value;}
			get{return _orgid;}
		}
		#endregion Model

	}
}

