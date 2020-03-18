/**  版本信息模板在安装目录下，可自行修改。
* Sfc_Mitem.cs
*
* 功 能： N/A
* 类 名： Sfc_Mitem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:54   N/A    初版
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
	/// Sfc_Mitem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sfc_Mitem
	{
		public Sfc_Mitem()
		{}
		#region Model
		private int? _id;
		private string _mitemcode;
		private string _mitemname;
		private string _mitemdesc;
		private string _mitemtype;
		private string _brand;
		private string _buyer;
		private string _dutyperson;
		private int? _supplierid;
		private int? _defaultinvid;
		private string _uom;
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
		public string MitemCode
		{
			set{ _mitemcode=value;}
			get{return _mitemcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MitemName
		{
			set{ _mitemname=value;}
			get{return _mitemname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MitemDesc
		{
			set{ _mitemdesc=value;}
			get{return _mitemdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MitemType
		{
			set{ _mitemtype=value;}
			get{return _mitemtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Brand
		{
			set{ _brand=value;}
			get{return _brand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Buyer
		{
			set{ _buyer=value;}
			get{return _buyer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DutyPerson
		{
			set{ _dutyperson=value;}
			get{return _dutyperson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SupplierId
		{
			set{ _supplierid=value;}
			get{return _supplierid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DefaultInvId
		{
			set{ _defaultinvid=value;}
			get{return _defaultinvid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Uom
		{
			set{ _uom=value;}
			get{return _uom;}
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

