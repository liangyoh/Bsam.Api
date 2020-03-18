/**  版本信息模板在安装目录下，可自行修改。
* PasswordLib.cs
*
* 功 能： N/A
* 类 名： PasswordLib
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:45   N/A    初版
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
	/// 数据访问类:PasswordLib
	/// </summary>
	public partial class PasswordLib
	{
		public PasswordLib()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("PLID", "PasswordLib"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PLID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PasswordLib");
			strSql.Append(" where PLID=@PLID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PLID", DbType.Int32,4)
			};
			parameters[0].Value = PLID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Bsam.Core.Model.Models.Model.PasswordLib model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PasswordLib(");
			strSql.Append("IsDeleted,plURL,plPWD,plAccountName,plStatus,plErrorCount,plHintPwd,plHintquestion,plCreateTime,plUpdateTime,plLastErrTime,test)");
			strSql.Append(" values (");
			strSql.Append("@IsDeleted,@plURL,@plPWD,@plAccountName,@plStatus,@plErrorCount,@plHintPwd,@plHintquestion,@plCreateTime,@plUpdateTime,@plLastErrTime,@test)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IsDeleted", DbType.bit,1),
					new SQLiteParameter("@plURL", DbType.String),
					new SQLiteParameter("@plPWD", DbType.String),
					new SQLiteParameter("@plAccountName", DbType.String),
					new SQLiteParameter("@plStatus", DbType.Int32,8),
					new SQLiteParameter("@plErrorCount", DbType.Int32,8),
					new SQLiteParameter("@plHintPwd", DbType.String),
					new SQLiteParameter("@plHintquestion", DbType.String),
					new SQLiteParameter("@plCreateTime", DbType.DateTime),
					new SQLiteParameter("@plUpdateTime", DbType.DateTime),
					new SQLiteParameter("@plLastErrTime", DbType.DateTime),
					new SQLiteParameter("@test", DbType.String)};
			parameters[0].Value = model.IsDeleted;
			parameters[1].Value = model.plURL;
			parameters[2].Value = model.plPWD;
			parameters[3].Value = model.plAccountName;
			parameters[4].Value = model.plStatus;
			parameters[5].Value = model.plErrorCount;
			parameters[6].Value = model.plHintPwd;
			parameters[7].Value = model.plHintquestion;
			parameters[8].Value = model.plCreateTime;
			parameters[9].Value = model.plUpdateTime;
			parameters[10].Value = model.plLastErrTime;
			parameters[11].Value = model.test;

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
		public bool Update(Bsam.Core.Model.Models.Model.PasswordLib model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PasswordLib set ");
			strSql.Append("IsDeleted=@IsDeleted,");
			strSql.Append("plURL=@plURL,");
			strSql.Append("plPWD=@plPWD,");
			strSql.Append("plAccountName=@plAccountName,");
			strSql.Append("plStatus=@plStatus,");
			strSql.Append("plErrorCount=@plErrorCount,");
			strSql.Append("plHintPwd=@plHintPwd,");
			strSql.Append("plHintquestion=@plHintquestion,");
			strSql.Append("plCreateTime=@plCreateTime,");
			strSql.Append("plUpdateTime=@plUpdateTime,");
			strSql.Append("plLastErrTime=@plLastErrTime,");
			strSql.Append("test=@test");
			strSql.Append(" where PLID=@PLID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IsDeleted", DbType.bit,1),
					new SQLiteParameter("@plURL", DbType.String),
					new SQLiteParameter("@plPWD", DbType.String),
					new SQLiteParameter("@plAccountName", DbType.String),
					new SQLiteParameter("@plStatus", DbType.Int32,8),
					new SQLiteParameter("@plErrorCount", DbType.Int32,8),
					new SQLiteParameter("@plHintPwd", DbType.String),
					new SQLiteParameter("@plHintquestion", DbType.String),
					new SQLiteParameter("@plCreateTime", DbType.DateTime),
					new SQLiteParameter("@plUpdateTime", DbType.DateTime),
					new SQLiteParameter("@plLastErrTime", DbType.DateTime),
					new SQLiteParameter("@test", DbType.String),
					new SQLiteParameter("@PLID", DbType.Int32,8)};
			parameters[0].Value = model.IsDeleted;
			parameters[1].Value = model.plURL;
			parameters[2].Value = model.plPWD;
			parameters[3].Value = model.plAccountName;
			parameters[4].Value = model.plStatus;
			parameters[5].Value = model.plErrorCount;
			parameters[6].Value = model.plHintPwd;
			parameters[7].Value = model.plHintquestion;
			parameters[8].Value = model.plCreateTime;
			parameters[9].Value = model.plUpdateTime;
			parameters[10].Value = model.plLastErrTime;
			parameters[11].Value = model.test;
			parameters[12].Value = model.PLID;

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
		public bool Delete(int PLID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PasswordLib ");
			strSql.Append(" where PLID=@PLID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PLID", DbType.Int32,4)
			};
			parameters[0].Value = PLID;

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
		public bool DeleteList(string PLIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PasswordLib ");
			strSql.Append(" where PLID in ("+PLIDlist + ")  ");
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
		public Bsam.Core.Model.Models.Model.PasswordLib GetModel(int PLID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PLID,IsDeleted,plURL,plPWD,plAccountName,plStatus,plErrorCount,plHintPwd,plHintquestion,plCreateTime,plUpdateTime,plLastErrTime,test from PasswordLib ");
			strSql.Append(" where PLID=@PLID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PLID", DbType.Int32,4)
			};
			parameters[0].Value = PLID;

			Bsam.Core.Model.Models.Model.PasswordLib model=new Bsam.Core.Model.Models.Model.PasswordLib();
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
		public Bsam.Core.Model.Models.Model.PasswordLib DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.PasswordLib model=new Bsam.Core.Model.Models.Model.PasswordLib();
			if (row != null)
			{
				if(row["PLID"]!=null && row["PLID"].ToString()!="")
				{
					model.PLID=int.Parse(row["PLID"].ToString());
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
				if(row["plURL"]!=null)
				{
					model.plURL=row["plURL"].ToString();
				}
				if(row["plPWD"]!=null)
				{
					model.plPWD=row["plPWD"].ToString();
				}
				if(row["plAccountName"]!=null)
				{
					model.plAccountName=row["plAccountName"].ToString();
				}
				if(row["plStatus"]!=null && row["plStatus"].ToString()!="")
				{
					model.plStatus=int.Parse(row["plStatus"].ToString());
				}
				if(row["plErrorCount"]!=null && row["plErrorCount"].ToString()!="")
				{
					model.plErrorCount=int.Parse(row["plErrorCount"].ToString());
				}
				if(row["plHintPwd"]!=null)
				{
					model.plHintPwd=row["plHintPwd"].ToString();
				}
				if(row["plHintquestion"]!=null)
				{
					model.plHintquestion=row["plHintquestion"].ToString();
				}
				if(row["plCreateTime"]!=null && row["plCreateTime"].ToString()!="")
				{
					model.plCreateTime=DateTime.Parse(row["plCreateTime"].ToString());
				}
				if(row["plUpdateTime"]!=null && row["plUpdateTime"].ToString()!="")
				{
					model.plUpdateTime=DateTime.Parse(row["plUpdateTime"].ToString());
				}
				if(row["plLastErrTime"]!=null && row["plLastErrTime"].ToString()!="")
				{
					model.plLastErrTime=DateTime.Parse(row["plLastErrTime"].ToString());
				}
				if(row["test"]!=null)
				{
					model.test=row["test"].ToString();
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
			strSql.Append("select PLID,IsDeleted,plURL,plPWD,plAccountName,plStatus,plErrorCount,plHintPwd,plHintquestion,plCreateTime,plUpdateTime,plLastErrTime,test ");
			strSql.Append(" FROM PasswordLib ");
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
			strSql.Append("select count(1) FROM PasswordLib ");
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
				strSql.Append("order by T.PLID desc");
			}
			strSql.Append(")AS Row, T.*  from PasswordLib T ");
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
			parameters[0].Value = "PasswordLib";
			parameters[1].Value = "PLID";
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

