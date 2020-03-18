/**  版本信息模板在安装目录下，可自行修改。
* Inv_District.cs
*
* 功 能： N/A
* 类 名： Inv_District
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:35   N/A    初版
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
	/// Inv_District:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Inv_District
	{
		public Inv_District()
		{}
		#region Model
		private int? _id;
		private string _districtcode;
		private string _districtname;
		private string _districtdesc;
		private string _districtstatus;
		private int? _volume;
		private string _volumeunit;
		private DateTime? _datetimecreated;
		private string _usercreator;
		private DateTime? _datetimemodified;
		private string _usermodified;
		private bool _state;
		private string _orgid;
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
		public string DistrictCode
		{
			set{ _districtcode=value;}
			get{return _districtcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DistrictName
		{
			set{ _districtname=value;}
			get{return _districtname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DistrictDesc
		{
			set{ _districtdesc=value;}
			get{return _districtdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DistrictStatus
		{
			set{ _districtstatus=value;}
			get{return _districtstatus;}
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
		public int? InvId
		{
			set{ _invid=value;}
			get{return _invid;}
		}
		#endregion Model

	}
}

