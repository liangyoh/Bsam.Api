﻿/**  版本信息模板在安装目录下，可自行修改。
* Sys_Permission_In_Group.cs
*
* 功 能： N/A
* 类 名： Sys_Permission_In_Group
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:03:08   N/A    初版
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
	/// 数据访问类:Sys_Permission_In_Group
	/// </summary>
	public partial class Sys_Permission_In_Group
	{
		public Sys_Permission_In_Group()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Bsam.Core.Model.Models.Model.Sys_Permission_In_Group model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_Permission_In_Group(");
			strSql.Append("PermissionId,PermissionGroupId)");
			strSql.Append(" values (");
			strSql.Append("@PermissionId,@PermissionGroupId)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PermissionId", DbType.Int32,4),
					new SQLiteParameter("@PermissionGroupId", DbType.Int32,4)};
			parameters[0].Value = model.PermissionId;
			parameters[1].Value = model.PermissionGroupId;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Bsam.Core.Model.Models.Model.Sys_Permission_In_Group model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_Permission_In_Group set ");
			strSql.Append("PermissionId=@PermissionId,");
			strSql.Append("PermissionGroupId=@PermissionGroupId");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PermissionId", DbType.Int32,4),
					new SQLiteParameter("@PermissionGroupId", DbType.Int32,4)};
			parameters[0].Value = model.PermissionId;
			parameters[1].Value = model.PermissionGroupId;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_Permission_In_Group ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Bsam.Core.Model.Models.Model.Sys_Permission_In_Group GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PermissionId,PermissionGroupId from Sys_Permission_In_Group ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			Bsam.Core.Model.Models.Model.Sys_Permission_In_Group model=new Bsam.Core.Model.Models.Model.Sys_Permission_In_Group();
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
		public Bsam.Core.Model.Models.Model.Sys_Permission_In_Group DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.Sys_Permission_In_Group model=new Bsam.Core.Model.Models.Model.Sys_Permission_In_Group();
			if (row != null)
			{
				if(row["PermissionId"]!=null && row["PermissionId"].ToString()!="")
				{
					model.PermissionId=int.Parse(row["PermissionId"].ToString());
				}
				if(row["PermissionGroupId"]!=null && row["PermissionGroupId"].ToString()!="")
				{
					model.PermissionGroupId=int.Parse(row["PermissionGroupId"].ToString());
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
			strSql.Append("select PermissionId,PermissionGroupId ");
			strSql.Append(" FROM Sys_Permission_In_Group ");
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
			strSql.Append("select count(1) FROM Sys_Permission_In_Group ");
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
			strSql.Append(")AS Row, T.*  from Sys_Permission_In_Group T ");
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
			parameters[0].Value = "Sys_Permission_In_Group";
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

