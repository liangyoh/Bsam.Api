/**  版本信息模板在安装目录下，可自行修改。
* TopicDetail.cs
*
* 功 能： N/A
* 类 名： TopicDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:03:27   N/A    初版
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
	/// TopicDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TopicDetail
	{
		public TopicDetail()
		{}
		#region Model
		private int _id;
		private int _topicid;
		private string _tdlogo;
		private string _tdname;
		private string _tdcontent;
		private string _tddetail;
		private string _tdsectenddetail;
		private bool _tdisdelete;
		private int _tdread;
		private int _tdcommend;
		private int _tdgood;
		private DateTime _tdcreatetime;
		private DateTime _tdupdatetime;
		private int _tdtop;
		private string _tdauthor;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TopicId
		{
			set{ _topicid=value;}
			get{return _topicid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tdLogo
		{
			set{ _tdlogo=value;}
			get{return _tdlogo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tdName
		{
			set{ _tdname=value;}
			get{return _tdname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tdContent
		{
			set{ _tdcontent=value;}
			get{return _tdcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tdDetail
		{
			set{ _tddetail=value;}
			get{return _tddetail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tdSectendDetail
		{
			set{ _tdsectenddetail=value;}
			get{return _tdsectenddetail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool tdIsDelete
		{
			set{ _tdisdelete=value;}
			get{return _tdisdelete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tdRead
		{
			set{ _tdread=value;}
			get{return _tdread;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tdCommend
		{
			set{ _tdcommend=value;}
			get{return _tdcommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tdGood
		{
			set{ _tdgood=value;}
			get{return _tdgood;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime tdCreatetime
		{
			set{ _tdcreatetime=value;}
			get{return _tdcreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime tdUpdatetime
		{
			set{ _tdupdatetime=value;}
			get{return _tdupdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tdTop
		{
			set{ _tdtop=value;}
			get{return _tdtop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tdAuthor
		{
			set{ _tdauthor=value;}
			get{return _tdauthor;}
		}
		#endregion Model

	}
}

