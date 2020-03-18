/**  版本信息模板在安装目录下，可自行修改。
* Sfc_Mitem.cs
*
* 功 能： N/A
* 类 名： Sfc_Mitem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:54   N/A    初版
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
	/// 数据访问类:Sfc_Mitem
	/// </summary>
	public partial class Sfc_Mitem
	{
		public Sfc_Mitem()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Bsam.Core.Model.Models.Model.Sfc_Mitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sfc_Mitem(");
			strSql.Append("Id,MitemCode,MitemName,MitemDesc,MitemType,Brand,Buyer,DutyPerson,SupplierId,DefaultInvId,Uom,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId)");
			strSql.Append(" values (");
			strSql.Append("@Id,@MitemCode,@MitemName,@MitemDesc,@MitemType,@Brand,@Buyer,@DutyPerson,@SupplierId,@DefaultInvId,@Uom,@DateTimeCreated,@UserCreator,@DateTimeModified,@UserModified,@State,@OrgId)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,8),
					new SQLiteParameter("@MitemCode", DbType.String,0),
					new SQLiteParameter("@MitemName", DbType.String,0),
					new SQLiteParameter("@MitemDesc", DbType.String,0),
					new SQLiteParameter("@MitemType", DbType.String,0),
					new SQLiteParameter("@Brand", DbType.String,0),
					new SQLiteParameter("@Buyer", DbType.String,0),
					new SQLiteParameter("@DutyPerson", DbType.String,0),
					new SQLiteParameter("@SupplierId", DbType.Int32,4),
					new SQLiteParameter("@DefaultInvId", DbType.Int32,4),
					new SQLiteParameter("@Uom", DbType.String,0),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1),
					new SQLiteParameter("@OrgId", DbType.String,0)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.MitemCode;
			parameters[2].Value = model.MitemName;
			parameters[3].Value = model.MitemDesc;
			parameters[4].Value = model.MitemType;
			parameters[5].Value = model.Brand;
			parameters[6].Value = model.Buyer;
			parameters[7].Value = model.DutyPerson;
			parameters[8].Value = model.SupplierId;
			parameters[9].Value = model.DefaultInvId;
			parameters[10].Value = model.Uom;
			parameters[11].Value = model.DateTimeCreated;
			parameters[12].Value = model.UserCreator;
			parameters[13].Value = model.DateTimeModified;
			parameters[14].Value = model.UserModified;
			parameters[15].Value = model.State;
			parameters[16].Value = model.OrgId;

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
		public bool Update(Bsam.Core.Model.Models.Model.Sfc_Mitem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sfc_Mitem set ");
			strSql.Append("Id=@Id,");
			strSql.Append("MitemCode=@MitemCode,");
			strSql.Append("MitemName=@MitemName,");
			strSql.Append("MitemDesc=@MitemDesc,");
			strSql.Append("MitemType=@MitemType,");
			strSql.Append("Brand=@Brand,");
			strSql.Append("Buyer=@Buyer,");
			strSql.Append("DutyPerson=@DutyPerson,");
			strSql.Append("SupplierId=@SupplierId,");
			strSql.Append("DefaultInvId=@DefaultInvId,");
			strSql.Append("Uom=@Uom,");
			strSql.Append("DateTimeCreated=@DateTimeCreated,");
			strSql.Append("UserCreator=@UserCreator,");
			strSql.Append("DateTimeModified=@DateTimeModified,");
			strSql.Append("UserModified=@UserModified,");
			strSql.Append("State=@State,");
			strSql.Append("OrgId=@OrgId");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,8),
					new SQLiteParameter("@MitemCode", DbType.String,0),
					new SQLiteParameter("@MitemName", DbType.String,0),
					new SQLiteParameter("@MitemDesc", DbType.String,0),
					new SQLiteParameter("@MitemType", DbType.String,0),
					new SQLiteParameter("@Brand", DbType.String,0),
					new SQLiteParameter("@Buyer", DbType.String,0),
					new SQLiteParameter("@DutyPerson", DbType.String,0),
					new SQLiteParameter("@SupplierId", DbType.Int32,4),
					new SQLiteParameter("@DefaultInvId", DbType.Int32,4),
					new SQLiteParameter("@Uom", DbType.String,0),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1),
					new SQLiteParameter("@OrgId", DbType.String,0)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.MitemCode;
			parameters[2].Value = model.MitemName;
			parameters[3].Value = model.MitemDesc;
			parameters[4].Value = model.MitemType;
			parameters[5].Value = model.Brand;
			parameters[6].Value = model.Buyer;
			parameters[7].Value = model.DutyPerson;
			parameters[8].Value = model.SupplierId;
			parameters[9].Value = model.DefaultInvId;
			parameters[10].Value = model.Uom;
			parameters[11].Value = model.DateTimeCreated;
			parameters[12].Value = model.UserCreator;
			parameters[13].Value = model.DateTimeModified;
			parameters[14].Value = model.UserModified;
			parameters[15].Value = model.State;
			parameters[16].Value = model.OrgId;

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
			strSql.Append("delete from Sfc_Mitem ");
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
		public Bsam.Core.Model.Models.Model.Sfc_Mitem GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,MitemCode,MitemName,MitemDesc,MitemType,Brand,Buyer,DutyPerson,SupplierId,DefaultInvId,Uom,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId from Sfc_Mitem ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			Bsam.Core.Model.Models.Model.Sfc_Mitem model=new Bsam.Core.Model.Models.Model.Sfc_Mitem();
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
		public Bsam.Core.Model.Models.Model.Sfc_Mitem DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.Sfc_Mitem model=new Bsam.Core.Model.Models.Model.Sfc_Mitem();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["MitemCode"]!=null)
				{
					model.MitemCode=row["MitemCode"].ToString();
				}
				if(row["MitemName"]!=null)
				{
					model.MitemName=row["MitemName"].ToString();
				}
				if(row["MitemDesc"]!=null)
				{
					model.MitemDesc=row["MitemDesc"].ToString();
				}
				if(row["MitemType"]!=null)
				{
					model.MitemType=row["MitemType"].ToString();
				}
				if(row["Brand"]!=null)
				{
					model.Brand=row["Brand"].ToString();
				}
				if(row["Buyer"]!=null)
				{
					model.Buyer=row["Buyer"].ToString();
				}
				if(row["DutyPerson"]!=null)
				{
					model.DutyPerson=row["DutyPerson"].ToString();
				}
				if(row["SupplierId"]!=null && row["SupplierId"].ToString()!="")
				{
					model.SupplierId=int.Parse(row["SupplierId"].ToString());
				}
				if(row["DefaultInvId"]!=null && row["DefaultInvId"].ToString()!="")
				{
					model.DefaultInvId=int.Parse(row["DefaultInvId"].ToString());
				}
				if(row["Uom"]!=null)
				{
					model.Uom=row["Uom"].ToString();
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
			strSql.Append("select Id,MitemCode,MitemName,MitemDesc,MitemType,Brand,Buyer,DutyPerson,SupplierId,DefaultInvId,Uom,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId ");
			strSql.Append(" FROM Sfc_Mitem ");
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
			strSql.Append("select count(1) FROM Sfc_Mitem ");
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
			strSql.Append(")AS Row, T.*  from Sfc_Mitem T ");
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
			parameters[0].Value = "Sfc_Mitem";
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

