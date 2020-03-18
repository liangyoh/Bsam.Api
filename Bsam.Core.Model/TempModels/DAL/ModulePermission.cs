/**  版本信息模板在安装目录下，可自行修改。
* ModulePermission.cs
*
* 功 能： N/A
* 类 名： ModulePermission
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:42   N/A    初版
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
	/// 数据访问类:ModulePermission
	/// </summary>
	public partial class ModulePermission
	{
		public ModulePermission()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Id", "ModulePermission"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ModulePermission");
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
		public int Add(Bsam.Core.Model.Models.Model.ModulePermission model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ModulePermission(");
			strSql.Append("IsDeleted,ModuleId,PermissionId,CreateId,CreateBy,CreateTime,ModifyId,ModifyBy,ModifyTime)");
			strSql.Append(" values (");
			strSql.Append("@IsDeleted,@ModuleId,@PermissionId,@CreateId,@CreateBy,@CreateTime,@ModifyId,@ModifyBy,@ModifyTime)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IsDeleted", DbType.bit,1),
					new SQLiteParameter("@ModuleId", DbType.Int32,8),
					new SQLiteParameter("@PermissionId", DbType.Int32,8),
					new SQLiteParameter("@CreateId", DbType.Int32,8),
					new SQLiteParameter("@CreateBy", DbType.String),
					new SQLiteParameter("@CreateTime", DbType.DateTime),
					new SQLiteParameter("@ModifyId", DbType.Int32,8),
					new SQLiteParameter("@ModifyBy", DbType.String),
					new SQLiteParameter("@ModifyTime", DbType.DateTime)};
			parameters[0].Value = model.IsDeleted;
			parameters[1].Value = model.ModuleId;
			parameters[2].Value = model.PermissionId;
			parameters[3].Value = model.CreateId;
			parameters[4].Value = model.CreateBy;
			parameters[5].Value = model.CreateTime;
			parameters[6].Value = model.ModifyId;
			parameters[7].Value = model.ModifyBy;
			parameters[8].Value = model.ModifyTime;

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
		public bool Update(Bsam.Core.Model.Models.Model.ModulePermission model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ModulePermission set ");
			strSql.Append("IsDeleted=@IsDeleted,");
			strSql.Append("ModuleId=@ModuleId,");
			strSql.Append("PermissionId=@PermissionId,");
			strSql.Append("CreateId=@CreateId,");
			strSql.Append("CreateBy=@CreateBy,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("ModifyId=@ModifyId,");
			strSql.Append("ModifyBy=@ModifyBy,");
			strSql.Append("ModifyTime=@ModifyTime");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IsDeleted", DbType.bit,1),
					new SQLiteParameter("@ModuleId", DbType.Int32,8),
					new SQLiteParameter("@PermissionId", DbType.Int32,8),
					new SQLiteParameter("@CreateId", DbType.Int32,8),
					new SQLiteParameter("@CreateBy", DbType.String),
					new SQLiteParameter("@CreateTime", DbType.DateTime),
					new SQLiteParameter("@ModifyId", DbType.Int32,8),
					new SQLiteParameter("@ModifyBy", DbType.String),
					new SQLiteParameter("@ModifyTime", DbType.DateTime),
					new SQLiteParameter("@Id", DbType.Int32,8)};
			parameters[0].Value = model.IsDeleted;
			parameters[1].Value = model.ModuleId;
			parameters[2].Value = model.PermissionId;
			parameters[3].Value = model.CreateId;
			parameters[4].Value = model.CreateBy;
			parameters[5].Value = model.CreateTime;
			parameters[6].Value = model.ModifyId;
			parameters[7].Value = model.ModifyBy;
			parameters[8].Value = model.ModifyTime;
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
			strSql.Append("delete from ModulePermission ");
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
			strSql.Append("delete from ModulePermission ");
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
		public Bsam.Core.Model.Models.Model.ModulePermission GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,IsDeleted,ModuleId,PermissionId,CreateId,CreateBy,CreateTime,ModifyId,ModifyBy,ModifyTime from ModulePermission ");
			strSql.Append(" where Id=@Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4)
			};
			parameters[0].Value = Id;

			Bsam.Core.Model.Models.Model.ModulePermission model=new Bsam.Core.Model.Models.Model.ModulePermission();
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
		public Bsam.Core.Model.Models.Model.ModulePermission DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.ModulePermission model=new Bsam.Core.Model.Models.Model.ModulePermission();
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
				if(row["ModuleId"]!=null && row["ModuleId"].ToString()!="")
				{
					model.ModuleId=int.Parse(row["ModuleId"].ToString());
				}
				if(row["PermissionId"]!=null && row["PermissionId"].ToString()!="")
				{
					model.PermissionId=int.Parse(row["PermissionId"].ToString());
				}
				if(row["CreateId"]!=null && row["CreateId"].ToString()!="")
				{
					model.CreateId=int.Parse(row["CreateId"].ToString());
				}
				if(row["CreateBy"]!=null)
				{
					model.CreateBy=row["CreateBy"].ToString();
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
				if(row["ModifyId"]!=null && row["ModifyId"].ToString()!="")
				{
					model.ModifyId=int.Parse(row["ModifyId"].ToString());
				}
				if(row["ModifyBy"]!=null)
				{
					model.ModifyBy=row["ModifyBy"].ToString();
				}
				if(row["ModifyTime"]!=null && row["ModifyTime"].ToString()!="")
				{
					model.ModifyTime=DateTime.Parse(row["ModifyTime"].ToString());
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
			strSql.Append("select Id,IsDeleted,ModuleId,PermissionId,CreateId,CreateBy,CreateTime,ModifyId,ModifyBy,ModifyTime ");
			strSql.Append(" FROM ModulePermission ");
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
			strSql.Append("select count(1) FROM ModulePermission ");
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
			strSql.Append(")AS Row, T.*  from ModulePermission T ");
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
			parameters[0].Value = "ModulePermission";
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

