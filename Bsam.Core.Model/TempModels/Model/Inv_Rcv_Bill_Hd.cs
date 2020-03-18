/**  版本信息模板在安装目录下，可自行修改。
* Inv_Rcv_Bill_Hd.cs
*
* 功 能： N/A
* 类 名： Inv_Rcv_Bill_Hd
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:39   N/A    初版
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
	/// Inv_Rcv_Bill_Hd:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Inv_Rcv_Bill_Hd
	{
		public Inv_Rcv_Bill_Hd()
		{}
		#region Model
		private int? _id;
		private string _rcvtype;
		private int? _rcvuserid;
		private string _rcvusername;
		private string _rcvphone;
		private DateTime? _rcvdatetime;
		private string _rcvreason;
		private string _rcvaddress;
		private string _rentsubject;
		private string _rentuserid;
		private string _rentusername;
		private string _rentphone;
		private int? _rrcbillid;
		private DateTime? _planrtndatetime;
		private DateTime? _actualrtndatetime;
		private string _billstatus;
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
		public string RcvType
		{
			set{ _rcvtype=value;}
			get{return _rcvtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RcvUserId
		{
			set{ _rcvuserid=value;}
			get{return _rcvuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RcvUserName
		{
			set{ _rcvusername=value;}
			get{return _rcvusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RcvPhone
		{
			set{ _rcvphone=value;}
			get{return _rcvphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RcvDateTime
		{
			set{ _rcvdatetime=value;}
			get{return _rcvdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RcvReason
		{
			set{ _rcvreason=value;}
			get{return _rcvreason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RcvAddress
		{
			set{ _rcvaddress=value;}
			get{return _rcvaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RentSubject
		{
			set{ _rentsubject=value;}
			get{return _rentsubject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RentUserId
		{
			set{ _rentuserid=value;}
			get{return _rentuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RentUserName
		{
			set{ _rentusername=value;}
			get{return _rentusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RentPhone
		{
			set{ _rentphone=value;}
			get{return _rentphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RrcBillId
		{
			set{ _rrcbillid=value;}
			get{return _rrcbillid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PlanRtnDateTime
		{
			set{ _planrtndatetime=value;}
			get{return _planrtndatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ActualRtnDateTime
		{
			set{ _actualrtndatetime=value;}
			get{return _actualrtndatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BillStatus
		{
			set{ _billstatus=value;}
			get{return _billstatus;}
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

