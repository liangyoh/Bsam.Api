/**  版本信息模板在安装目录下，可自行修改。
* Sfc_Production_Bom.cs
*
* 功 能： N/A
* 类 名： Sfc_Production_Bom
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:58   N/A    初版
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
	/// Sfc_Production_Bom:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sfc_Production_Bom
	{
		public Sfc_Production_Bom()
		{}
		#region Model
		private int? _id;
		private int? _productid;
		private int? _mitemid;
		private decimal? _reqqty;
		private string _version;
		private string _versiondesc;
		private string _batchno;
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
		public int? ProductId
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MitemId
		{
			set{ _mitemid=value;}
			get{return _mitemid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ReqQty
		{
			set{ _reqqty=value;}
			get{return _reqqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Version
		{
			set{ _version=value;}
			get{return _version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VersionDesc
		{
			set{ _versiondesc=value;}
			get{return _versiondesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BatchNo
		{
			set{ _batchno=value;}
			get{return _batchno;}
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

