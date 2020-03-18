/**  版本信息模板在安装目录下，可自行修改。
* Sys_Permission.cs
*
* 功 能： N/A
* 类 名： Sys_Permission
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:03:04   N/A    初版
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
	/// 数据访问类:Sys_Permission
	/// </summary>
	public partial class Sys_Permission
	{
		public Sys_Permission()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Bsam.Core.Model.Models.Model.Sys_Permission model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_Permission(");
			strSql.Append("Id,PermissionName,PermissionDesc,RequestType,ClientType,ModuleId,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State)");
			strSql.Append(" values (");
			strSql.Append("@Id,@PermissionName,@PermissionDesc,@RequestType,@ClientType,@ModuleId,@DateTimeCreated,@UserCreator,@DateTimeModified,@UserModified,@State)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4),
					new SQLiteParameter("@PermissionName", DbType.String,0),
					new SQLiteParameter("@PermissionDesc", DbType.String,0),
					new SQLiteParameter("@RequestType", DbType.String,0),
					new SQLiteParameter("@ClientType", DbType.String,0),
					new SQLiteParameter("@ModuleId", DbType.Int32,4),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.PermissionName;
			parameters[2].Value = model.PermissionDesc;
			parameters[3].Value = model.RequestType;
			parameters[4].Value = model.ClientType;
			parameters[5].Value = model.ModuleId;
			parameters[6].Value = model.DateTimeCreated;
			parameters[7].Value = model.UserCreator;
			parameters[8].Value = model.DateTimeModified;
			parameters[9].Value = model.UserModified;
			parameters[10].Value = model.State;

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
		public bool Update(Bsam.Core.Model.Models.Model.Sys_Permission model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_Permission set ");
			strSql.Append("Id=@Id,");
			strSql.Append("PermissionName=@PermissionName,");
			strSql.Append("PermissionDesc=@PermissionDesc,");
			strSql.Append("RequestType=@RequestType,");
			strSql.Append("ClientType=@ClientType,");
			strSql.Append("ModuleId=@ModuleId,");
			strSql.Append("DateTimeCreated=@DateTimeCreated,");
			strSql.Append("UserCreator=@UserCreator,");
			strSql.Append("DateTimeModified=@DateTimeModified,");
			strSql.Append("UserModified=@UserModified,");
			strSql.Append("State=@State");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4),
					new SQLiteParameter("@PermissionName", DbType.String,0),
					new SQLiteParameter("@PermissionDesc", DbType.String,0),
					new SQLiteParameter("@RequestType", DbType.String,0),
					new SQLiteParameter("@ClientType", DbType.String,0),
					new SQLiteParameter("@ModuleId", DbType.Int32,4),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.PermissionName;
			parameters[2].Value = model.PermissionDesc;
			parameters[3].Value = model.RequestType;
			parameters[4].Value = model.ClientType;
			parameters[5].Value = model.ModuleId;
			parameters[6].Value = model.DateTimeCreated;
			parameters[7].Value = model.UserCreator;
			parameters[8].Value = model.DateTimeModified;
			parameters[9].Value = model.UserModified;
			parameters[10].Value = model.State;

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
			strSql.Append("delete from Sys_Permission ");
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
		public Bsam.Core.Model.Models.Model.Sys_Permission GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,PermissionName,PermissionDesc,RequestType,ClientType,ModuleId,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State from Sys_Permission ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			Bsam.Core.Model.Models.Model.Sys_Permission model=new Bsam.Core.Model.Models.Model.Sys_Permission();
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
		public Bsam.Core.Model.Models.Model.Sys_Permission DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.Sys_Permission model=new Bsam.Core.Model.Models.Model.Sys_Permission();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["PermissionName"]!=null)
				{
					model.PermissionName=row["PermissionName"].ToString();
				}
				if(row["PermissionDesc"]!=null)
				{
					model.PermissionDesc=row["PermissionDesc"].ToString();
				}
				if(row["RequestType"]!=null)
				{
					model.RequestType=row["RequestType"].ToString();
				}
				if(row["ClientType"]!=null)
				{
					model.ClientType=row["ClientType"].ToString();
				}
				if(row["ModuleId"]!=null && row["ModuleId"].ToString()!="")
				{
					model.ModuleId=int.Parse(row["ModuleId"].ToString());
				}
				if(row["DateTimeCreated"]!=null && row["DateTimeCreated"].ToString()!="")
				{
					model.DateTimeCreated=DateTime.Parse(row["DateTimeCreated"].ToString());
				}
				if(row["UserCreator"]!=null)
				{
					model.UserCreator=row["UserCreator"].ToString();
				}
				if(row["DateTimeModified"]!=null && row["DateTimeModified"].ToString()!="")
				{
					model.DateTimeModified=DateTime.Parse(row["DateTimeModified"].ToString());
				}
				if(row["UserModified"]!=null)
				{
					model.UserModified=row["UserModified"].ToString();
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					if((row["State"].ToString()=="1")||(row["State"].ToString().ToLower()=="true"))
					{
						model.State=true;
					}
					else
					{
						model.State=false;
					}
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
			strSql.Append("select Id,PermissionName,PermissionDesc,RequestType,ClientType,ModuleId,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State ");
			strSql.Append(" FROM Sys_Permission ");
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
			strSql.Append("select count(1) FROM Sys_Permission ");
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
			strSql.Append(")AS Row, T.*  from Sys_Permission T ");
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
			parameters[0].Value = "Sys_Permission";
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

