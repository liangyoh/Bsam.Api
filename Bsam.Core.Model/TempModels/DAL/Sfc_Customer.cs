/**  版本信息模板在安装目录下，可自行修改。
* Sfc_Customer.cs
*
* 功 能： N/A
* 类 名： Sfc_Customer
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:52   N/A    初版
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
	/// 数据访问类:Sfc_Customer
	/// </summary>
	public partial class Sfc_Customer
	{
		public Sfc_Customer()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Bsam.Core.Model.Models.Model.Sfc_Customer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sfc_Customer(");
			strSql.Append("Id,CustomerCode,CustomerName,CustomerShortName,CustomerPhone,CustomerWebchat,EnterpriseName,EnterpriseLegal,EnterpriseAddress,EnterprisePhone,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId)");
			strSql.Append(" values (");
			strSql.Append("@Id,@CustomerCode,@CustomerName,@CustomerShortName,@CustomerPhone,@CustomerWebchat,@EnterpriseName,@EnterpriseLegal,@EnterpriseAddress,@EnterprisePhone,@DateTimeCreated,@UserCreator,@DateTimeModified,@UserModified,@State,@OrgId)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,8),
					new SQLiteParameter("@CustomerCode", DbType.String,0),
					new SQLiteParameter("@CustomerName", DbType.String,0),
					new SQLiteParameter("@CustomerShortName", DbType.String,0),
					new SQLiteParameter("@CustomerPhone", DbType.String,0),
					new SQLiteParameter("@CustomerWebchat", DbType.String,0),
					new SQLiteParameter("@EnterpriseName", DbType.String,0),
					new SQLiteParameter("@EnterpriseLegal", DbType.String,0),
					new SQLiteParameter("@EnterpriseAddress", DbType.String,0),
					new SQLiteParameter("@EnterprisePhone", DbType.String,0),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1),
					new SQLiteParameter("@OrgId", DbType.String,0)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.CustomerCode;
			parameters[2].Value = model.CustomerName;
			parameters[3].Value = model.CustomerShortName;
			parameters[4].Value = model.CustomerPhone;
			parameters[5].Value = model.CustomerWebchat;
			parameters[6].Value = model.EnterpriseName;
			parameters[7].Value = model.EnterpriseLegal;
			parameters[8].Value = model.EnterpriseAddress;
			parameters[9].Value = model.EnterprisePhone;
			parameters[10].Value = model.DateTimeCreated;
			parameters[11].Value = model.UserCreator;
			parameters[12].Value = model.DateTimeModified;
			parameters[13].Value = model.UserModified;
			parameters[14].Value = model.State;
			parameters[15].Value = model.OrgId;

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
		public bool Update(Bsam.Core.Model.Models.Model.Sfc_Customer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sfc_Customer set ");
			strSql.Append("Id=@Id,");
			strSql.Append("CustomerCode=@CustomerCode,");
			strSql.Append("CustomerName=@CustomerName,");
			strSql.Append("CustomerShortName=@CustomerShortName,");
			strSql.Append("CustomerPhone=@CustomerPhone,");
			strSql.Append("CustomerWebchat=@CustomerWebchat,");
			strSql.Append("EnterpriseName=@EnterpriseName,");
			strSql.Append("EnterpriseLegal=@EnterpriseLegal,");
			strSql.Append("EnterpriseAddress=@EnterpriseAddress,");
			strSql.Append("EnterprisePhone=@EnterprisePhone,");
			strSql.Append("DateTimeCreated=@DateTimeCreated,");
			strSql.Append("UserCreator=@UserCreator,");
			strSql.Append("DateTimeModified=@DateTimeModified,");
			strSql.Append("UserModified=@UserModified,");
			strSql.Append("State=@State,");
			strSql.Append("OrgId=@OrgId");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,8),
					new SQLiteParameter("@CustomerCode", DbType.String,0),
					new SQLiteParameter("@CustomerName", DbType.String,0),
					new SQLiteParameter("@CustomerShortName", DbType.String,0),
					new SQLiteParameter("@CustomerPhone", DbType.String,0),
					new SQLiteParameter("@CustomerWebchat", DbType.String,0),
					new SQLiteParameter("@EnterpriseName", DbType.String,0),
					new SQLiteParameter("@EnterpriseLegal", DbType.String,0),
					new SQLiteParameter("@EnterpriseAddress", DbType.String,0),
					new SQLiteParameter("@EnterprisePhone", DbType.String,0),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1),
					new SQLiteParameter("@OrgId", DbType.String,0)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.CustomerCode;
			parameters[2].Value = model.CustomerName;
			parameters[3].Value = model.CustomerShortName;
			parameters[4].Value = model.CustomerPhone;
			parameters[5].Value = model.CustomerWebchat;
			parameters[6].Value = model.EnterpriseName;
			parameters[7].Value = model.EnterpriseLegal;
			parameters[8].Value = model.EnterpriseAddress;
			parameters[9].Value = model.EnterprisePhone;
			parameters[10].Value = model.DateTimeCreated;
			parameters[11].Value = model.UserCreator;
			parameters[12].Value = model.DateTimeModified;
			parameters[13].Value = model.UserModified;
			parameters[14].Value = model.State;
			parameters[15].Value = model.OrgId;

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
			strSql.Append("delete from Sfc_Customer ");
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
		public Bsam.Core.Model.Models.Model.Sfc_Customer GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,CustomerCode,CustomerName,CustomerShortName,CustomerPhone,CustomerWebchat,EnterpriseName,EnterpriseLegal,EnterpriseAddress,EnterprisePhone,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId from Sfc_Customer ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			Bsam.Core.Model.Models.Model.Sfc_Customer model=new Bsam.Core.Model.Models.Model.Sfc_Customer();
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
		public Bsam.Core.Model.Models.Model.Sfc_Customer DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.Sfc_Customer model=new Bsam.Core.Model.Models.Model.Sfc_Customer();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["CustomerCode"]!=null)
				{
					model.CustomerCode=row["CustomerCode"].ToString();
				}
				if(row["CustomerName"]!=null)
				{
					model.CustomerName=row["CustomerName"].ToString();
				}
				if(row["CustomerShortName"]!=null)
				{
					model.CustomerShortName=row["CustomerShortName"].ToString();
				}
				if(row["CustomerPhone"]!=null)
				{
					model.CustomerPhone=row["CustomerPhone"].ToString();
				}
				if(row["CustomerWebchat"]!=null)
				{
					model.CustomerWebchat=row["CustomerWebchat"].ToString();
				}
				if(row["EnterpriseName"]!=null)
				{
					model.EnterpriseName=row["EnterpriseName"].ToString();
				}
				if(row["EnterpriseLegal"]!=null)
				{
					model.EnterpriseLegal=row["EnterpriseLegal"].ToString();
				}
				if(row["EnterpriseAddress"]!=null)
				{
					model.EnterpriseAddress=row["EnterpriseAddress"].ToString();
				}
				if(row["EnterprisePhone"]!=null)
				{
					model.EnterprisePhone=row["EnterprisePhone"].ToString();
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
				if(row["OrgId"]!=null)
				{
					model.OrgId=row["OrgId"].ToString();
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
			strSql.Append("select Id,CustomerCode,CustomerName,CustomerShortName,CustomerPhone,CustomerWebchat,EnterpriseName,EnterpriseLegal,EnterpriseAddress,EnterprisePhone,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId ");
			strSql.Append(" FROM Sfc_Customer ");
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
			strSql.Append("select count(1) FROM Sfc_Customer ");
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
			strSql.Append(")AS Row, T.*  from Sfc_Customer T ");
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
			parameters[0].Value = "Sfc_Customer";
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

