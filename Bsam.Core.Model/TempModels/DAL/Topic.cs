/**  版本信息模板在安装目录下，可自行修改。
* Topic.cs
*
* 功 能： N/A
* 类 名： Topic
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:03:25   N/A    初版
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
	/// 数据访问类:Topic
	/// </summary>
	public partial class Topic
	{
		public Topic()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Id", "Topic"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Topic");
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
		public int Add(Bsam.Core.Model.Models.Model.Topic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Topic(");
			strSql.Append("tLogo,tName,tDetail,tAuthor,tSectendDetail,tIsDelete,tRead,tCommend,tGood,tCreatetime,tUpdatetime)");
			strSql.Append(" values (");
			strSql.Append("@tLogo,@tName,@tDetail,@tAuthor,@tSectendDetail,@tIsDelete,@tRead,@tCommend,@tGood,@tCreatetime,@tUpdatetime)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tLogo", DbType.String),
					new SQLiteParameter("@tName", DbType.String),
					new SQLiteParameter("@tDetail", DbType.String),
					new SQLiteParameter("@tAuthor", DbType.String),
					new SQLiteParameter("@tSectendDetail", DbType.String),
					new SQLiteParameter("@tIsDelete", DbType.bit,1),
					new SQLiteParameter("@tRead", DbType.Int32,8),
					new SQLiteParameter("@tCommend", DbType.Int32,8),
					new SQLiteParameter("@tGood", DbType.Int32,8),
					new SQLiteParameter("@tCreatetime", DbType.DateTime),
					new SQLiteParameter("@tUpdatetime", DbType.DateTime)};
			parameters[0].Value = model.tLogo;
			parameters[1].Value = model.tName;
			parameters[2].Value = model.tDetail;
			parameters[3].Value = model.tAuthor;
			parameters[4].Value = model.tSectendDetail;
			parameters[5].Value = model.tIsDelete;
			parameters[6].Value = model.tRead;
			parameters[7].Value = model.tCommend;
			parameters[8].Value = model.tGood;
			parameters[9].Value = model.tCreatetime;
			parameters[10].Value = model.tUpdatetime;

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
		public bool Update(Bsam.Core.Model.Models.Model.Topic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Topic set ");
			strSql.Append("tLogo=@tLogo,");
			strSql.Append("tName=@tName,");
			strSql.Append("tDetail=@tDetail,");
			strSql.Append("tAuthor=@tAuthor,");
			strSql.Append("tSectendDetail=@tSectendDetail,");
			strSql.Append("tIsDelete=@tIsDelete,");
			strSql.Append("tRead=@tRead,");
			strSql.Append("tCommend=@tCommend,");
			strSql.Append("tGood=@tGood,");
			strSql.Append("tCreatetime=@tCreatetime,");
			strSql.Append("tUpdatetime=@tUpdatetime");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tLogo", DbType.String),
					new SQLiteParameter("@tName", DbType.String),
					new SQLiteParameter("@tDetail", DbType.String),
					new SQLiteParameter("@tAuthor", DbType.String),
					new SQLiteParameter("@tSectendDetail", DbType.String),
					new SQLiteParameter("@tIsDelete", DbType.bit,1),
					new SQLiteParameter("@tRead", DbType.Int32,8),
					new SQLiteParameter("@tCommend", DbType.Int32,8),
					new SQLiteParameter("@tGood", DbType.Int32,8),
					new SQLiteParameter("@tCreatetime", DbType.DateTime),
					new SQLiteParameter("@tUpdatetime", DbType.DateTime),
					new SQLiteParameter("@Id", DbType.Int32,8)};
			parameters[0].Value = model.tLogo;
			parameters[1].Value = model.tName;
			parameters[2].Value = model.tDetail;
			parameters[3].Value = model.tAuthor;
			parameters[4].Value = model.tSectendDetail;
			parameters[5].Value = model.tIsDelete;
			parameters[6].Value = model.tRead;
			parameters[7].Value = model.tCommend;
			parameters[8].Value = model.tGood;
			parameters[9].Value = model.tCreatetime;
			parameters[10].Value = model.tUpdatetime;
			parameters[11].Value = model.Id;

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
			strSql.Append("delete from Topic ");
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
			strSql.Append("delete from Topic ");
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
		public Bsam.Core.Model.Models.Model.Topic GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,tLogo,tName,tDetail,tAuthor,tSectendDetail,tIsDelete,tRead,tCommend,tGood,tCreatetime,tUpdatetime from Topic ");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4)
			};
			parameters[0].Value = Id;

			Bsam.Core.Model.Models.Model.Topic model=new Bsam.Core.Model.Models.Model.Topic();
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
		public Bsam.Core.Model.Models.Model.Topic DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.Topic model=new Bsam.Core.Model.Models.Model.Topic();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["tLogo"]!=null)
				{
					model.tLogo=row["tLogo"].ToString();
				}
				if(row["tName"]!=null)
				{
					model.tName=row["tName"].ToString();
				}
				if(row["tDetail"]!=null)
				{
					model.tDetail=row["tDetail"].ToString();
				}
				if(row["tAuthor"]!=null)
				{
					model.tAuthor=row["tAuthor"].ToString();
				}
				if(row["tSectendDetail"]!=null)
				{
					model.tSectendDetail=row["tSectendDetail"].ToString();
				}
				if(row["tIsDelete"]!=null && row["tIsDelete"].ToString()!="")
				{
					if((row["tIsDelete"].ToString()=="1")||(row["tIsDelete"].ToString().ToLower()=="true"))
					{
						model.tIsDelete=true;
					}
					else
					{
						model.tIsDelete=false;
					}
				}
				if(row["tRead"]!=null && row["tRead"].ToString()!="")
				{
					model.tRead=int.Parse(row["tRead"].ToString());
				}
				if(row["tCommend"]!=null && row["tCommend"].ToString()!="")
				{
					model.tCommend=int.Parse(row["tCommend"].ToString());
				}
				if(row["tGood"]!=null && row["tGood"].ToString()!="")
				{
					model.tGood=int.Parse(row["tGood"].ToString());
				}
				if(row["tCreatetime"]!=null && row["tCreatetime"].ToString()!="")
				{
					model.tCreatetime=DateTime.Parse(row["tCreatetime"].ToString());
				}
				if(row["tUpdatetime"]!=null && row["tUpdatetime"].ToString()!="")
				{
					model.tUpdatetime=DateTime.Parse(row["tUpdatetime"].ToString());
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
			strSql.Append("select Id,tLogo,tName,tDetail,tAuthor,tSectendDetail,tIsDelete,tRead,tCommend,tGood,tCreatetime,tUpdatetime ");
			strSql.Append(" FROM Topic ");
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
			strSql.Append("select count(1) FROM Topic ");
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
			strSql.Append(")AS Row, T.*  from Topic T ");
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
			parameters[0].Value = "Topic";
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

