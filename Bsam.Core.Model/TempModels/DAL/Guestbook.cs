/**  版本信息模板在安装目录下，可自行修改。
* Guestbook.cs
*
* 功 能： N/A
* 类 名： Guestbook
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:33   N/A    初版
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
	/// 数据访问类:Guestbook
	/// </summary>
	public partial class Guestbook
	{
		public Guestbook()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "Guestbook"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Guestbook");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Bsam.Core.Model.Models.Model.Guestbook model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Guestbook(");
			strSql.Append("blogId,createdate,username,phone,QQ,body,ip,isshow)");
			strSql.Append(" values (");
			strSql.Append("@blogId,@createdate,@username,@phone,@QQ,@body,@ip,@isshow)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@blogId", DbType.Int32,8),
					new SQLiteParameter("@createdate", DbType.DateTime),
					new SQLiteParameter("@username", DbType.String),
					new SQLiteParameter("@phone", DbType.String),
					new SQLiteParameter("@QQ", DbType.String),
					new SQLiteParameter("@body", DbType.String),
					new SQLiteParameter("@ip", DbType.String),
					new SQLiteParameter("@isshow", DbType.bit,1)};
			parameters[0].Value = model.blogId;
			parameters[1].Value = model.createdate;
			parameters[2].Value = model.username;
			parameters[3].Value = model.phone;
			parameters[4].Value = model.QQ;
			parameters[5].Value = model.body;
			parameters[6].Value = model.ip;
			parameters[7].Value = model.isshow;

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
		public bool Update(Bsam.Core.Model.Models.Model.Guestbook model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Guestbook set ");
			strSql.Append("blogId=@blogId,");
			strSql.Append("createdate=@createdate,");
			strSql.Append("username=@username,");
			strSql.Append("phone=@phone,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("body=@body,");
			strSql.Append("ip=@ip,");
			strSql.Append("isshow=@isshow");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@blogId", DbType.Int32,8),
					new SQLiteParameter("@createdate", DbType.DateTime),
					new SQLiteParameter("@username", DbType.String),
					new SQLiteParameter("@phone", DbType.String),
					new SQLiteParameter("@QQ", DbType.String),
					new SQLiteParameter("@body", DbType.String),
					new SQLiteParameter("@ip", DbType.String),
					new SQLiteParameter("@isshow", DbType.bit,1),
					new SQLiteParameter("@id", DbType.Int32,8)};
			parameters[0].Value = model.blogId;
			parameters[1].Value = model.createdate;
			parameters[2].Value = model.username;
			parameters[3].Value = model.phone;
			parameters[4].Value = model.QQ;
			parameters[5].Value = model.body;
			parameters[6].Value = model.ip;
			parameters[7].Value = model.isshow;
			parameters[8].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Guestbook ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Guestbook ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public Bsam.Core.Model.Models.Model.Guestbook GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,blogId,createdate,username,phone,QQ,body,ip,isshow from Guestbook ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			Bsam.Core.Model.Models.Model.Guestbook model=new Bsam.Core.Model.Models.Model.Guestbook();
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
		public Bsam.Core.Model.Models.Model.Guestbook DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.Guestbook model=new Bsam.Core.Model.Models.Model.Guestbook();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["blogId"]!=null && row["blogId"].ToString()!="")
				{
					model.blogId=int.Parse(row["blogId"].ToString());
				}
				if(row["createdate"]!=null && row["createdate"].ToString()!="")
				{
					model.createdate=DateTime.Parse(row["createdate"].ToString());
				}
				if(row["username"]!=null)
				{
					model.username=row["username"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["QQ"]!=null)
				{
					model.QQ=row["QQ"].ToString();
				}
				if(row["body"]!=null)
				{
					model.body=row["body"].ToString();
				}
				if(row["ip"]!=null)
				{
					model.ip=row["ip"].ToString();
				}
				if(row["isshow"]!=null && row["isshow"].ToString()!="")
				{
					if((row["isshow"].ToString()=="1")||(row["isshow"].ToString().ToLower()=="true"))
					{
						model.isshow=true;
					}
					else
					{
						model.isshow=false;
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
			strSql.Append("select id,blogId,createdate,username,phone,QQ,body,ip,isshow ");
			strSql.Append(" FROM Guestbook ");
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
			strSql.Append("select count(1) FROM Guestbook ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from Guestbook T ");
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
			parameters[0].Value = "Guestbook";
			parameters[1].Value = "id";
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

