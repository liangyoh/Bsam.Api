/**  版本信息模板在安装目录下，可自行修改。
* Inv_Bill_Dtl.cs
*
* 功 能： N/A
* 类 名： Inv_Bill_Dtl
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:33   N/A    初版
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
	/// Inv_Bill_Dtl:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Inv_Bill_Dtl
	{
		public Inv_Bill_Dtl()
		{}
		#region Model
		private int? _id;
		private int? _billid;
		private string _mitemcode;
		private decimal? _planqty;
		private decimal? _actualqty;
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
		public int? BillId
		{
			set{ _billid=value;}
			get{return _billid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MitemCode
		{
			set{ _mitemcode=value;}
			get{return _mitemcode;}
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

