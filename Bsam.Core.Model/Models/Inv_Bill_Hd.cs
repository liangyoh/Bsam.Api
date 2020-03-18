/**  版本信息模板在安装目录下，可自行修改。
* Inv_Bill_Hd.cs
*
* 功 能： N/A
* 类 名： Inv_Bill_Hd
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:34   N/A    初版
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
	/// Inv_Bill_Hd:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Inv_Bill_Hd
	{
		public Inv_Bill_Hd()
		{}
		#region Model
		private int? _id;
		private string _billtype;
		private decimal? _planqty;
		private decimal? _actualqty;
		private int? _srcbillid;
		private string _srcbillno;
		private int? _invid;
		private string _invcode;
		private string _invname;
		private string _invaddress;
		private string _rcvuser;
		private DateTime? _rcvdatetime;
		private string _rcvreason;
		private string _rcvaddress;
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
		public string BillType
		{
			set{ _billtype=value;}
			get{return _billtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PlanQty
		{
			set{ _planqty=value;}
			get{return _planqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ActualQty
		{
			set{ _actualqty=value;}
			get{return _actualqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SrcBillId
		{
			set{ _srcbillid=value;}
			get{return _srcbillid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SrcBillNo
		{
			set{ _srcbillno=value;}
			get{return _srcbillno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InvId
		{
			set{ _invid=value;}
			get{return _invid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvCode
		{
			set{ _invcode=value;}
			get{return _invcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvName
		{
			set{ _invname=value;}
			get{return _invname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvAddress
		{
			set{ _invaddress=value;}
			get{return _invaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RcvUser
		{
			set{ _rcvuser=value;}
			get{return _rcvuser;}
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

