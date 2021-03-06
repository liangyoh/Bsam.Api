﻿/**  版本信息模板在安装目录下，可自行修改。
* Advertisement.cs
*
* 功 能： N/A
* 类 名： Advertisement
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:32   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace Bsam.Core.Model.Models.DAL
{
	/// <summary>
	/// 数据访问类:Advertisement
	/// </summary>
	public partial class Advertisement
	{
		public Advertisement()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Id", "Advertisement"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Advertisement");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Bsam.Core.Model.Models.Model.Advertisement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Advertisement(");
			strSql.Append("ImgUrl,Title,Url,Remark,Createdate)");
			strSql.Append(" values (");
			strSql.Append("@ImgUrl,@Title,@Url,@Remark,@Createdate)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ImgUrl", DbType.String),
					new SQLiteParameter("@Title", DbType.String),
					new SQLiteParameter("@Url", DbType.String),
					new SQLiteParameter("@Remark", DbType.String),
					new SQLiteParameter("@Createdate", DbType.DateTime)};
			parameters[0].Value = model.ImgUrl;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.Url;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.Createdate;

			object obj = DbHelperSQLite.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Bsam.Core.Model.Models.Model.Advertisement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Advertisement set ");
			strSql.Append("ImgUrl=@ImgUrl,");
			strSql.Append("Title=@Title,");
			strSql.Append("Url=@Url,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Createdate=@Createdate");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ImgUrl", DbType.String),
					new SQLiteParameter("@Title", DbType.String),
					new SQLiteParameter("@Url", DbType.String),
					new SQLiteParameter("@Remark", DbType.String),
					new SQLiteParameter("@Createdate", DbType.DateTime),
					new SQLiteParameter("@Id", DbType.Int32,8)};
			parameters[0].Value = model.ImgUrl;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.Url;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.Createdate;
			parameters[5].Value = model.Id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Advertisement ");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4)
			};
			parameters[0].Value = Id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Advertisement ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Bsam.Core.Model.Models.Model.Advertisement GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,ImgUrl,Title,Url,Remark,Createdate from Advertisement ");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4)
			};
			parameters[0].Value = Id;

			Bsam.Core.Model.Models.Model.Advertisement model=new Bsam.Core.Model.Models.Model.Advertisement();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Bsam.Core.Model.Models.Model.Advertisement DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.Advertisement model=new Bsam.Core.Model.Models.Model.Advertisement();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["ImgUrl"]!=null)
				{
					model.ImgUrl=row["ImgUrl"].ToString();
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Url"]!=null)
				{
					model.Url=row["Url"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["Createdate"]!=null && row["Createdate"].ToString()!="")
				{
					model.Createdate=DateTime.Parse(row["Createdate"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,ImgUrl,Title,Url,Remark,Createdate ");
			strSql.Append(" FROM Advertisement ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Advertisement ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from Advertisement T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "Advertisement";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

