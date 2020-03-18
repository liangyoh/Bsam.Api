/**  版本信息模板在安装目录下，可自行修改。
* BlogArticle.cs
*
* 功 能： N/A
* 类 名： BlogArticle
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
	/// 数据访问类:BlogArticle
	/// </summary>
	public partial class BlogArticle
	{
		public BlogArticle()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("bID", "BlogArticle"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int bID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BlogArticle");
			strSql.Append(" where bID=@bID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@bID", DbType.Int32,4)
			};
			parameters[0].Value = bID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Bsam.Core.Model.Models.Model.BlogArticle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BlogArticle(");
			strSql.Append("bsubmitter,btitle,bcategory,bcontent,btraffic,bcommentNum,bUpdateTime,bCreateTime,bRemark,IsDeleted)");
			strSql.Append(" values (");
			strSql.Append("@bsubmitter,@btitle,@bcategory,@bcontent,@btraffic,@bcommentNum,@bUpdateTime,@bCreateTime,@bRemark,@IsDeleted)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@bsubmitter", DbType.String),
					new SQLiteParameter("@btitle", DbType.String),
					new SQLiteParameter("@bcategory", DbType.String),
					new SQLiteParameter("@bcontent", DbType.String),
					new SQLiteParameter("@btraffic", DbType.Int32,8),
					new SQLiteParameter("@bcommentNum", DbType.Int32,8),
					new SQLiteParameter("@bUpdateTime", DbType.DateTime),
					new SQLiteParameter("@bCreateTime", DbType.DateTime),
					new SQLiteParameter("@bRemark", DbType.String),
					new SQLiteParameter("@IsDeleted", DbType.bit,1)};
			parameters[0].Value = model.bsubmitter;
			parameters[1].Value = model.btitle;
			parameters[2].Value = model.bcategory;
			parameters[3].Value = model.bcontent;
			parameters[4].Value = model.btraffic;
			parameters[5].Value = model.bcommentNum;
			parameters[6].Value = model.bUpdateTime;
			parameters[7].Value = model.bCreateTime;
			parameters[8].Value = model.bRemark;
			parameters[9].Value = model.IsDeleted;

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
		public bool Update(Bsam.Core.Model.Models.Model.BlogArticle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BlogArticle set ");
			strSql.Append("bsubmitter=@bsubmitter,");
			strSql.Append("btitle=@btitle,");
			strSql.Append("bcategory=@bcategory,");
			strSql.Append("bcontent=@bcontent,");
			strSql.Append("btraffic=@btraffic,");
			strSql.Append("bcommentNum=@bcommentNum,");
			strSql.Append("bUpdateTime=@bUpdateTime,");
			strSql.Append("bCreateTime=@bCreateTime,");
			strSql.Append("bRemark=@bRemark,");
			strSql.Append("IsDeleted=@IsDeleted");
			strSql.Append(" where bID=@bID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@bsubmitter", DbType.String),
					new SQLiteParameter("@btitle", DbType.String),
					new SQLiteParameter("@bcategory", DbType.String),
					new SQLiteParameter("@bcontent", DbType.String),
					new SQLiteParameter("@btraffic", DbType.Int32,8),
					new SQLiteParameter("@bcommentNum", DbType.Int32,8),
					new SQLiteParameter("@bUpdateTime", DbType.DateTime),
					new SQLiteParameter("@bCreateTime", DbType.DateTime),
					new SQLiteParameter("@bRemark", DbType.String),
					new SQLiteParameter("@IsDeleted", DbType.bit,1),
					new SQLiteParameter("@bID", DbType.Int32,8)};
			parameters[0].Value = model.bsubmitter;
			parameters[1].Value = model.btitle;
			parameters[2].Value = model.bcategory;
			parameters[3].Value = model.bcontent;
			parameters[4].Value = model.btraffic;
			parameters[5].Value = model.bcommentNum;
			parameters[6].Value = model.bUpdateTime;
			parameters[7].Value = model.bCreateTime;
			parameters[8].Value = model.bRemark;
			parameters[9].Value = model.IsDeleted;
			parameters[10].Value = model.bID;

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
		public bool Delete(int bID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogArticle ");
			strSql.Append(" where bID=@bID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@bID", DbType.Int32,4)
			};
			parameters[0].Value = bID;

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
		public bool DeleteList(string bIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogArticle ");
			strSql.Append(" where bID in ("+bIDlist + ")  ");
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
		public Bsam.Core.Model.Models.Model.BlogArticle GetModel(int bID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select bID,bsubmitter,btitle,bcategory,bcontent,btraffic,bcommentNum,bUpdateTime,bCreateTime,bRemark,IsDeleted from BlogArticle ");
			strSql.Append(" where bID=@bID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@bID", DbType.Int32,4)
			};
			parameters[0].Value = bID;

			Bsam.Core.Model.Models.Model.BlogArticle model=new Bsam.Core.Model.Models.Model.BlogArticle();
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
		public Bsam.Core.Model.Models.Model.BlogArticle DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.BlogArticle model=new Bsam.Core.Model.Models.Model.BlogArticle();
			if (row != null)
			{
				if(row["bID"]!=null && row["bID"].ToString()!="")
				{
					model.bID=int.Parse(row["bID"].ToString());
				}
				if(row["bsubmitter"]!=null)
				{
					model.bsubmitter=row["bsubmitter"].ToString();
				}
				if(row["btitle"]!=null)
				{
					model.btitle=row["btitle"].ToString();
				}
				if(row["bcategory"]!=null)
				{
					model.bcategory=row["bcategory"].ToString();
				}
				if(row["bcontent"]!=null)
				{
					model.bcontent=row["bcontent"].ToString();
				}
				if(row["btraffic"]!=null && row["btraffic"].ToString()!="")
				{
					model.btraffic=int.Parse(row["btraffic"].ToString());
				}
				if(row["bcommentNum"]!=null && row["bcommentNum"].ToString()!="")
				{
					model.bcommentNum=int.Parse(row["bcommentNum"].ToString());
				}
				if(row["bUpdateTime"]!=null && row["bUpdateTime"].ToString()!="")
				{
					model.bUpdateTime=DateTime.Parse(row["bUpdateTime"].ToString());
				}
				if(row["bCreateTime"]!=null && row["bCreateTime"].ToString()!="")
				{
					model.bCreateTime=DateTime.Parse(row["bCreateTime"].ToString());
				}
				if(row["bRemark"]!=null)
				{
					model.bRemark=row["bRemark"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select bID,bsubmitter,btitle,bcategory,bcontent,btraffic,bcommentNum,bUpdateTime,bCreateTime,bRemark,IsDeleted ");
			strSql.Append(" FROM BlogArticle ");
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
			strSql.Append("select count(1) FROM BlogArticle ");
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
				strSql.Append("order by T.bID desc");
			}
			strSql.Append(")AS Row, T.*  from BlogArticle T ");
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
			parameters[0].Value = "BlogArticle";
			parameters[1].Value = "bID";
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

