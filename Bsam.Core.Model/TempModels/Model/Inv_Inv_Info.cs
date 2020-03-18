﻿/**  版本信息模板在安装目录下，可自行修改。
* Inv_Inv_Info.cs
*
* 功 能： N/A
* 类 名： Inv_Inv_Info
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
	/// Inv_Inv_Info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Inv_Inv_Info
	{
		public Inv_Inv_Info()
		{}
		#region Model
		private int? _id;
		private string _invcode;
		private string _invname;
		private string _invdesc;
		private string _invaddress;
		private int? _volume;
		private string _volumeunit;
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
		public string InvDesc
		{
			set{ _invdesc=value;}
			get{return _invdesc;}
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
		#endregion Model

	}
}

