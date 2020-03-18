/**  版本信息模板在安装目录下，可自行修改。
* sysUserInfo.cs
*
* 功 能： N/A
* 类 名： sysUserInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:03:33   N/A    初版
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
	/// 数据访问类:sysUserInfo
	/// </summary>
	public partial class sysUserInfo
	{
		public sysUserInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("uID", "sysUserInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int uID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sysUserInfo");
			strSql.Append(" where uID=@uID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@uID", DbType.Int32,4)
			};
			parameters[0].Value = uID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Bsam.Core.Model.Models.Model.sysUserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sysUserInfo(");
			strSql.Append("uLoginName,uLoginPWD,uRealName,uStatus,uRemark,uCreateTime,uUpdateTime,uLastErrTime,uErrorCount,name,sex,age,birth,addr,tdIsDelete)");
			strSql.Append(" values (");
			strSql.Append("@uLoginName,@uLoginPWD,@uRealName,@uStatus,@uRemark,@uCreateTime,@uUpdateTime,@uLastErrTime,@uErrorCount,@name,@sex,@age,@birth,@addr,@tdIsDelete)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@uLoginName", DbType.String),
					new SQLiteParameter("@uLoginPWD", DbType.String),
					new SQLiteParameter("@uRealName", DbType.String),
					new SQLiteParameter("@uStatus", DbType.Int32,8),
					new SQLiteParameter("@uRemark", DbType.String),
					new SQLiteParameter("@uCreateTime", DbType.DateTime),
					new SQLiteParameter("@uUpdateTime", DbType.DateTime),
					new SQLiteParameter("@uLastErrTime", DbType.DateTime),
					new SQLiteParameter("@uErrorCount", DbType.Int32,8),
					new SQLiteParameter("@name", DbType.String),
					new SQLiteParameter("@sex", DbType.Int32,8),
					new SQLiteParameter("@age", DbType.Int32,8),
					new SQLiteParameter("@birth", DbType.DateTime),
					new SQLiteParameter("@addr", DbType.String),
					new SQLiteParameter("@tdIsDelete", DbType.bit,1)};
			parameters[0].Value = model.uLoginName;
			parameters[1].Value = model.uLoginPWD;
			parameters[2].Value = model.uRealName;
			parameters[3].Value = model.uStatus;
			parameters[4].Value = model.uRemark;
			parameters[5].Value = model.uCreateTime;
			parameters[6].Value = model.uUpdateTime;
			parameters[7].Value = model.uLastErrTime;
			parameters[8].Value = model.uErrorCount;
			parameters[9].Value = model.name;
			parameters[10].Value = model.sex;
			parameters[11].Value = model.age;
			parameters[12].Value = model.birth;
			parameters[13].Value = model.addr;
			parameters[14].Value = model.tdIsDelete;

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
		public bool Update(Bsam.Core.Model.Models.Model.sysUserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sysUserInfo set ");
			strSql.Append("uLoginName=@uLoginName,");
			strSql.Append("uLoginPWD=@uLoginPWD,");
			strSql.Append("uRealName=@uRealName,");
			strSql.Append("uStatus=@uStatus,");
			strSql.Append("uRemark=@uRemark,");
			strSql.Append("uCreateTime=@uCreateTime,");
			strSql.Append("uUpdateTime=@uUpdateTime,");
			strSql.Append("uLastErrTime=@uLastErrTime,");
			strSql.Append("uErrorCount=@uErrorCount,");
			strSql.Append("name=@name,");
			strSql.Append("sex=@sex,");
			strSql.Append("age=@age,");
			strSql.Append("birth=@birth,");
			strSql.Append("addr=@addr,");
			strSql.Append("tdIsDelete=@tdIsDelete");
			strSql.Append(" where uID=@uID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@uLoginName", DbType.String),
					new SQLiteParameter("@uLoginPWD", DbType.String),
					new SQLiteParameter("@uRealName", DbType.String),
					new SQLiteParameter("@uStatus", DbType.Int32,8),
					new SQLiteParameter("@uRemark", DbType.String),
					new SQLiteParameter("@uCreateTime", DbType.DateTime),
					new SQLiteParameter("@uUpdateTime", DbType.DateTime),
					new SQLiteParameter("@uLastErrTime", DbType.DateTime),
					new SQLiteParameter("@uErrorCount", DbType.Int32,8),
					new SQLiteParameter("@name", DbType.String),
					new SQLiteParameter("@sex", DbType.Int32,8),
					new SQLiteParameter("@age", DbType.Int32,8),
					new SQLiteParameter("@birth", DbType.DateTime),
					new SQLiteParameter("@addr", DbType.String),
					new SQLiteParameter("@tdIsDelete", DbType.bit,1),
					new SQLiteParameter("@uID", DbType.Int32,8)};
			parameters[0].Value = model.uLoginName;
			parameters[1].Value = model.uLoginPWD;
			parameters[2].Value = model.uRealName;
			parameters[3].Value = model.uStatus;
			parameters[4].Value = model.uRemark;
			parameters[5].Value = model.uCreateTime;
			parameters[6].Value = model.uUpdateTime;
			parameters[7].Value = model.uLastErrTime;
			parameters[8].Value = model.uErrorCount;
			parameters[9].Value = model.name;
			parameters[10].Value = model.sex;
			parameters[11].Value = model.age;
			parameters[12].Value = model.birth;
			parameters[13].Value = model.addr;
			parameters[14].Value = model.tdIsDelete;
			parameters[15].Value = model.uID;

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
		public bool Delete(int uID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sysUserInfo ");
			strSql.Append(" where uID=@uID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@uID", DbType.Int32,4)
			};
			parameters[0].Value = uID;

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
		public bool DeleteList(string uIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sysUserInfo ");
			strSql.Append(" where uID in ("+uIDlist + ")  ");
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
		public Bsam.Core.Model.Models.Model.sysUserInfo GetModel(int uID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select uID,uLoginName,uLoginPWD,uRealName,uStatus,uRemark,uCreateTime,uUpdateTime,uLastErrTime,uErrorCount,name,sex,age,birth,addr,tdIsDelete from sysUserInfo ");
			strSql.Append(" where uID=@uID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@uID", DbType.Int32,4)
			};
			parameters[0].Value = uID;

			Bsam.Core.Model.Models.Model.sysUserInfo model=new Bsam.Core.Model.Models.Model.sysUserInfo();
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
		public Bsam.Core.Model.Models.Model.sysUserInfo DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.sysUserInfo model=new Bsam.Core.Model.Models.Model.sysUserInfo();
			if (row != null)
			{
				if(row["uID"]!=null && row["uID"].ToString()!="")
				{
					model.uID=int.Parse(row["uID"].ToString());
				}
				if(row["uLoginName"]!=null)
				{
					model.uLoginName=row["uLoginName"].ToString();
				}
				if(row["uLoginPWD"]!=null)
				{
					model.uLoginPWD=row["uLoginPWD"].ToString();
				}
				if(row["uRealName"]!=null)
				{
					model.uRealName=row["uRealName"].ToString();
				}
				if(row["uStatus"]!=null && row["uStatus"].ToString()!="")
				{
					model.uStatus=int.Parse(row["uStatus"].ToString());
				}
				if(row["uRemark"]!=null)
				{
					model.uRemark=row["uRemark"].ToString();
				}
				if(row["uCreateTime"]!=null && row["uCreateTime"].ToString()!="")
				{
					model.uCreateTime=DateTime.Parse(row["uCreateTime"].ToString());
				}
				if(row["uUpdateTime"]!=null && row["uUpdateTime"].ToString()!="")
				{
					model.uUpdateTime=DateTime.Parse(row["uUpdateTime"].ToString());
				}
				if(row["uLastErrTime"]!=null && row["uLastErrTime"].ToString()!="")
				{
					model.uLastErrTime=DateTime.Parse(row["uLastErrTime"].ToString());
				}
				if(row["uErrorCount"]!=null && row["uErrorCount"].ToString()!="")
				{
					model.uErrorCount=int.Parse(row["uErrorCount"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["sex"]!=null && row["sex"].ToString()!="")
				{
					model.sex=int.Parse(row["sex"].ToString());
				}
				if(row["age"]!=null && row["age"].ToString()!="")
				{
					model.age=int.Parse(row["age"].ToString());
				}
				if(row["birth"]!=null && row["birth"].ToString()!="")
				{
					model.birth=DateTime.Parse(row["birth"].ToString());
				}
				if(row["addr"]!=null)
				{
					model.addr=row["addr"].ToString();
				}
				if(row["tdIsDelete"]!=null && row["tdIsDelete"].ToString()!="")
				{
					if((row["tdIsDelete"].ToString()=="1")||(row["tdIsDelete"].ToString().ToLower()=="true"))
					{
						model.tdIsDelete=true;
					}
					else
					{
						model.tdIsDelete=false;
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
			strSql.Append("select uID,uLoginName,uLoginPWD,uRealName,uStatus,uRemark,uCreateTime,uUpdateTime,uLastErrTime,uErrorCount,name,sex,age,birth,addr,tdIsDelete ");
			strSql.Append(" FROM sysUserInfo ");
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
			strSql.Append("select count(1) FROM sysUserInfo ");
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
				strSql.Append("order by T.uID desc");
			}
			strSql.Append(")AS Row, T.*  from sysUserInfo T ");
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
			parameters[0].Value = "sysUserInfo";
			parameters[1].Value = "uID";
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

