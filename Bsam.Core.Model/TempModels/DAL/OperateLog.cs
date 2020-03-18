/**  版本信息模板在安装目录下，可自行修改。
* OperateLog.cs
*
* 功 能： N/A
* 类 名： OperateLog
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:43   N/A    初版
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
	/// 数据访问类:OperateLog
	/// </summary>
	public partial class OperateLog
	{
		public OperateLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Id", "OperateLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OperateLog");
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
		public int Add(Bsam.Core.Model.Models.Model.OperateLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OperateLog(");
			strSql.Append("IsDeleted,Area,Controller,Action,IPAddress,Description,LogTime,LoginName,UserId)");
			strSql.Append(" values (");
			strSql.Append("@IsDeleted,@Area,@Controller,@Action,@IPAddress,@Description,@LogTime,@LoginName,@UserId)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IsDeleted", DbType.bit,1),
					new SQLiteParameter("@Area", DbType.String),
					new SQLiteParameter("@Controller", DbType.String),
					new SQLiteParameter("@Action", DbType.String),
					new SQLiteParameter("@IPAddress", DbType.String),
					new SQLiteParameter("@Description", DbType.String),
					new SQLiteParameter("@LogTime", DbType.DateTime),
					new SQLiteParameter("@LoginName", DbType.String),
					new SQLiteParameter("@UserId", DbType.Int32,8)};
			parameters[0].Value = model.IsDeleted;
			parameters[1].Value = model.Area;
			parameters[2].Value = model.Controller;
			parameters[3].Value = model.Action;
			parameters[4].Value = model.IPAddress;
			parameters[5].Value = model.Description;
			parameters[6].Value = model.LogTime;
			parameters[7].Value = model.LoginName;
			parameters[8].Value = model.UserId;

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
		public bool Update(Bsam.Core.Model.Models.Model.OperateLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OperateLog set ");
			strSql.Append("IsDeleted=@IsDeleted,");
			strSql.Append("Area=@Area,");
			strSql.Append("Controller=@Controller,");
			strSql.Append("Action=@Action,");
			strSql.Append("IPAddress=@IPAddress,");
			strSql.Append("Description=@Description,");
			strSql.Append("LogTime=@LogTime,");
			strSql.Append("LoginName=@LoginName,");
			strSql.Append("UserId=@UserId");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IsDeleted", DbType.bit,1),
					new SQLiteParameter("@Area", DbType.String),
					new SQLiteParameter("@Controller", DbType.String),
					new SQLiteParameter("@Action", DbType.String),
					new SQLiteParameter("@IPAddress", DbType.String),
					new SQLiteParameter("@Description", DbType.String),
					new SQLiteParameter("@LogTime", DbType.DateTime),
					new SQLiteParameter("@LoginName", DbType.String),
					new SQLiteParameter("@UserId", DbType.Int32,8),
					new SQLiteParameter("@Id", DbType.Int32,8)};
			parameters[0].Value = model.IsDeleted;
			parameters[1].Value = model.Area;
			parameters[2].Value = model.Controller;
			parameters[3].Value = model.Action;
			parameters[4].Value = model.IPAddress;
			parameters[5].Value = model.Description;
			parameters[6].Value = model.LogTime;
			parameters[7].Value = model.LoginName;
			parameters[8].Value = model.UserId;
			parameters[9].Value = model.Id;

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
			strSql.Append("delete from OperateLog ");
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
			strSql.Append("delete from OperateLog ");
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
		public Bsam.Core.Model.Models.Model.OperateLog GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,IsDeleted,Area,Controller,Action,IPAddress,Description,LogTime,LoginName,UserId from OperateLog ");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4)
			};
			parameters[0].Value = Id;

			Bsam.Core.Model.Models.Model.OperateLog model=new Bsam.Core.Model.Models.Model.OperateLog();
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
		public Bsam.Core.Model.Models.Model.OperateLog DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.OperateLog model=new Bsam.Core.Model.Models.Model.OperateLog();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["IsDeleted"]!=null && row["IsDeleted"].ToString()!="")
				{
					if((row["IsDeleted"].ToString()=="1")||(row["IsDeleted"].ToString().ToLower()=="true"))
					{
						model.IsDeleted=true;
					}
					else
					{
						model.IsDeleted=false;
					}
				}
				if(row["Area"]!=null)
				{
					model.Area=row["Area"].ToString();
				}
				if(row["Controller"]!=null)
				{
					model.Controller=row["Controller"].ToString();
				}
				if(row["Action"]!=null)
				{
					model.Action=row["Action"].ToString();
				}
				if(row["IPAddress"]!=null)
				{
					model.IPAddress=row["IPAddress"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["LogTime"]!=null && row["LogTime"].ToString()!="")
				{
					model.LogTime=DateTime.Parse(row["LogTime"].ToString());
				}
				if(row["LoginName"]!=null)
				{
					model.LoginName=row["LoginName"].ToString();
				}
				if(row["UserId"]!=null && row["UserId"].ToString()!="")
				{
					model.UserId=int.Parse(row["UserId"].ToString());
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
			strSql.Append("select Id,IsDeleted,Area,Controller,Action,IPAddress,Description,LogTime,LoginName,UserId ");
			strSql.Append(" FROM OperateLog ");
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
			strSql.Append("select count(1) FROM OperateLog ");
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
			strSql.Append(")AS Row, T.*  from OperateLog T ");
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
			parameters[0].Value = "OperateLog";
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

