/**  版本信息模板在安装目录下，可自行修改。
* TopicDetail.cs
*
* 功 能： N/A
* 类 名： TopicDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:03:28   N/A    初版
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
	/// 数据访问类:TopicDetail
	/// </summary>
	public partial class TopicDetail
	{
		public TopicDetail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Id", "TopicDetail"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TopicDetail");
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
		public int Add(Bsam.Core.Model.Models.Model.TopicDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TopicDetail(");
			strSql.Append("TopicId,tdLogo,tdName,tdContent,tdDetail,tdSectendDetail,tdIsDelete,tdRead,tdCommend,tdGood,tdCreatetime,tdUpdatetime,tdTop,tdAuthor)");
			strSql.Append(" values (");
			strSql.Append("@TopicId,@tdLogo,@tdName,@tdContent,@tdDetail,@tdSectendDetail,@tdIsDelete,@tdRead,@tdCommend,@tdGood,@tdCreatetime,@tdUpdatetime,@tdTop,@tdAuthor)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@TopicId", DbType.Int32,8),
					new SQLiteParameter("@tdLogo", DbType.String),
					new SQLiteParameter("@tdName", DbType.String),
					new SQLiteParameter("@tdContent", DbType.String),
					new SQLiteParameter("@tdDetail", DbType.String),
					new SQLiteParameter("@tdSectendDetail", DbType.String),
					new SQLiteParameter("@tdIsDelete", DbType.bit,1),
					new SQLiteParameter("@tdRead", DbType.Int32,8),
					new SQLiteParameter("@tdCommend", DbType.Int32,8),
					new SQLiteParameter("@tdGood", DbType.Int32,8),
					new SQLiteParameter("@tdCreatetime", DbType.DateTime),
					new SQLiteParameter("@tdUpdatetime", DbType.DateTime),
					new SQLiteParameter("@tdTop", DbType.Int32,8),
					new SQLiteParameter("@tdAuthor", DbType.String)};
			parameters[0].Value = model.TopicId;
			parameters[1].Value = model.tdLogo;
			parameters[2].Value = model.tdName;
			parameters[3].Value = model.tdContent;
			parameters[4].Value = model.tdDetail;
			parameters[5].Value = model.tdSectendDetail;
			parameters[6].Value = model.tdIsDelete;
			parameters[7].Value = model.tdRead;
			parameters[8].Value = model.tdCommend;
			parameters[9].Value = model.tdGood;
			parameters[10].Value = model.tdCreatetime;
			parameters[11].Value = model.tdUpdatetime;
			parameters[12].Value = model.tdTop;
			parameters[13].Value = model.tdAuthor;

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
		public bool Update(Bsam.Core.Model.Models.Model.TopicDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TopicDetail set ");
			strSql.Append("TopicId=@TopicId,");
			strSql.Append("tdLogo=@tdLogo,");
			strSql.Append("tdName=@tdName,");
			strSql.Append("tdContent=@tdContent,");
			strSql.Append("tdDetail=@tdDetail,");
			strSql.Append("tdSectendDetail=@tdSectendDetail,");
			strSql.Append("tdIsDelete=@tdIsDelete,");
			strSql.Append("tdRead=@tdRead,");
			strSql.Append("tdCommend=@tdCommend,");
			strSql.Append("tdGood=@tdGood,");
			strSql.Append("tdCreatetime=@tdCreatetime,");
			strSql.Append("tdUpdatetime=@tdUpdatetime,");
			strSql.Append("tdTop=@tdTop,");
			strSql.Append("tdAuthor=@tdAuthor");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@TopicId", DbType.Int32,8),
					new SQLiteParameter("@tdLogo", DbType.String),
					new SQLiteParameter("@tdName", DbType.String),
					new SQLiteParameter("@tdContent", DbType.String),
					new SQLiteParameter("@tdDetail", DbType.String),
					new SQLiteParameter("@tdSectendDetail", DbType.String),
					new SQLiteParameter("@tdIsDelete", DbType.bit,1),
					new SQLiteParameter("@tdRead", DbType.Int32,8),
					new SQLiteParameter("@tdCommend", DbType.Int32,8),
					new SQLiteParameter("@tdGood", DbType.Int32,8),
					new SQLiteParameter("@tdCreatetime", DbType.DateTime),
					new SQLiteParameter("@tdUpdatetime", DbType.DateTime),
					new SQLiteParameter("@tdTop", DbType.Int32,8),
					new SQLiteParameter("@tdAuthor", DbType.String),
					new SQLiteParameter("@Id", DbType.Int32,8)};
			parameters[0].Value = model.TopicId;
			parameters[1].Value = model.tdLogo;
			parameters[2].Value = model.tdName;
			parameters[3].Value = model.tdContent;
			parameters[4].Value = model.tdDetail;
			parameters[5].Value = model.tdSectendDetail;
			parameters[6].Value = model.tdIsDelete;
			parameters[7].Value = model.tdRead;
			parameters[8].Value = model.tdCommend;
			parameters[9].Value = model.tdGood;
			parameters[10].Value = model.tdCreatetime;
			parameters[11].Value = model.tdUpdatetime;
			parameters[12].Value = model.tdTop;
			parameters[13].Value = model.tdAuthor;
			parameters[14].Value = model.Id;

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
			strSql.Append("delete from TopicDetail ");
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
			strSql.Append("delete from TopicDetail ");
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
		public Bsam.Core.Model.Models.Model.TopicDetail GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,TopicId,tdLogo,tdName,tdContent,tdDetail,tdSectendDetail,tdIsDelete,tdRead,tdCommend,tdGood,tdCreatetime,tdUpdatetime,tdTop,tdAuthor from TopicDetail ");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4)
			};
			parameters[0].Value = Id;

			Bsam.Core.Model.Models.Model.TopicDetail model=new Bsam.Core.Model.Models.Model.TopicDetail();
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
		public Bsam.Core.Model.Models.Model.TopicDetail DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.TopicDetail model=new Bsam.Core.Model.Models.Model.TopicDetail();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["TopicId"]!=null && row["TopicId"].ToString()!="")
				{
					model.TopicId=int.Parse(row["TopicId"].ToString());
				}
				if(row["tdLogo"]!=null)
				{
					model.tdLogo=row["tdLogo"].ToString();
				}
				if(row["tdName"]!=null)
				{
					model.tdName=row["tdName"].ToString();
				}
				if(row["tdContent"]!=null)
				{
					model.tdContent=row["tdContent"].ToString();
				}
				if(row["tdDetail"]!=null)
				{
					model.tdDetail=row["tdDetail"].ToString();
				}
				if(row["tdSectendDetail"]!=null)
				{
					model.tdSectendDetail=row["tdSectendDetail"].ToString();
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
				if(row["tdRead"]!=null && row["tdRead"].ToString()!="")
				{
					model.tdRead=int.Parse(row["tdRead"].ToString());
				}
				if(row["tdCommend"]!=null && row["tdCommend"].ToString()!="")
				{
					model.tdCommend=int.Parse(row["tdCommend"].ToString());
				}
				if(row["tdGood"]!=null && row["tdGood"].ToString()!="")
				{
					model.tdGood=int.Parse(row["tdGood"].ToString());
				}
				if(row["tdCreatetime"]!=null && row["tdCreatetime"].ToString()!="")
				{
					model.tdCreatetime=DateTime.Parse(row["tdCreatetime"].ToString());
				}
				if(row["tdUpdatetime"]!=null && row["tdUpdatetime"].ToString()!="")
				{
					model.tdUpdatetime=DateTime.Parse(row["tdUpdatetime"].ToString());
				}
				if(row["tdTop"]!=null && row["tdTop"].ToString()!="")
				{
					model.tdTop=int.Parse(row["tdTop"].ToString());
				}
				if(row["tdAuthor"]!=null)
				{
					model.tdAuthor=row["tdAuthor"].ToString();
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
			strSql.Append("select Id,TopicId,tdLogo,tdName,tdContent,tdDetail,tdSectendDetail,tdIsDelete,tdRead,tdCommend,tdGood,tdCreatetime,tdUpdatetime,tdTop,tdAuthor ");
			strSql.Append(" FROM TopicDetail ");
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
			strSql.Append("select count(1) FROM TopicDetail ");
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
			strSql.Append(")AS Row, T.*  from TopicDetail T ");
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
			parameters[0].Value = "TopicDetail";
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

