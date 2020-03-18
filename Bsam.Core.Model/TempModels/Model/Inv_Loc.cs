/**  版本信息模板在安装目录下，可自行修改。
* Inv_Loc.cs
*
* 功 能： N/A
* 类 名： Inv_Loc
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:36   N/A    初版
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
	/// Inv_Loc:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Inv_Loc
	{
		public Inv_Loc()
		{}
		#region Model
		private int? _id;
		private string _loccode;
		private string _locname;
		private string _locdesc;
		private string _locstatus;
		private int? _locorder;
		private int? _volume;
		private string _volumeunit;
		private DateTime? _datetimecreated;
		private string _usercreator;
		private DateTime? _datetimemodified;
		private string _usermodified;
		private bool _state;
		private string _orgid;
		private int? _districtid;
		private int? _invid;
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
		public string LocCode
		{
			set{ _loccode=value;}
			get{return _loccode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LocName
		{
			set{ _locname=value;}
			get{return _locname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LocDesc
		{
			set{ _locdesc=value;}
			get{return _locdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LocStatus
		{
			set{ _locstatus=value;}
			get{return _locstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LocOrder
		{
			set{ _locorder=value;}
			get{return _locorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Volume
		{
			set{ _volume=value;}
			get{return _volume;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VolumeUnit
		{
			set{ _volumeunit=value;}
			get{return _volumeunit;}
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
		/// <summary>
		/// 
		/// </summary>
		public int? DistrictId
		{
			set{ _districtid=value;}
			get{return _districtid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InvId
		{
			set{ _invid=value;}
			get{return _invid;}
		}
		#endregion Model

	}
}

