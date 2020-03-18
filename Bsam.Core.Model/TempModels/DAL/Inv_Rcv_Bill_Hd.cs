/**  版本信息模板在安装目录下，可自行修改。
* Inv_Rcv_Bill_Hd.cs
*
* 功 能： N/A
* 类 名： Inv_Rcv_Bill_Hd
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:39   N/A    初版
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
	/// 数据访问类:Inv_Rcv_Bill_Hd
	/// </summary>
	public partial class Inv_Rcv_Bill_Hd
	{
		public Inv_Rcv_Bill_Hd()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Inv_Rcv_Bill_Hd(");
			strSql.Append("Id,RcvType,RcvUserId,RcvUserName,RcvPhone,RcvDateTime,RcvReason,RcvAddress,RentSubject,RentUserId,RentUserName,RentPhone,RrcBillId,PlanRtnDateTime,ActualRtnDateTime,BillStatus,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId)");
			strSql.Append(" values (");
			strSql.Append("@Id,@RcvType,@RcvUserId,@RcvUserName,@RcvPhone,@RcvDateTime,@RcvReason,@RcvAddress,@RentSubject,@RentUserId,@RentUserName,@RentPhone,@RrcBillId,@PlanRtnDateTime,@ActualRtnDateTime,@BillStatus,@DateTimeCreated,@UserCreator,@DateTimeModified,@UserModified,@State,@OrgId)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4),
					new SQLiteParameter("@RcvType", DbType.String,0),
					new SQLiteParameter("@RcvUserId", DbType.Int32,4),
					new SQLiteParameter("@RcvUserName", DbType.String,0),
					new SQLiteParameter("@RcvPhone", DbType.String,0),
					new SQLiteParameter("@RcvDateTime", DbType.Date),
					new SQLiteParameter("@RcvReason", DbType.String,0),
					new SQLiteParameter("@RcvAddress", DbType.String,0),
					new SQLiteParameter("@RentSubject", DbType.String,0),
					new SQLiteParameter("@RentUserId", DbType.String,0),
					new SQLiteParameter("@RentUserName", DbType.String,0),
					new SQLiteParameter("@RentPhone", DbType.String,0),
					new SQLiteParameter("@RrcBillId", DbType.Int32,4),
					new SQLiteParameter("@PlanRtnDateTime", DbType.Date),
					new SQLiteParameter("@ActualRtnDateTime", DbType.Date),
					new SQLiteParameter("@BillStatus", DbType.String,0),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1),
					new SQLiteParameter("@OrgId", DbType.String,0)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.RcvType;
			parameters[2].Value = model.RcvUserId;
			parameters[3].Value = model.RcvUserName;
			parameters[4].Value = model.RcvPhone;
			parameters[5].Value = model.RcvDateTime;
			parameters[6].Value = model.RcvReason;
			parameters[7].Value = model.RcvAddress;
			parameters[8].Value = model.RentSubject;
			parameters[9].Value = model.RentUserId;
			parameters[10].Value = model.RentUserName;
			parameters[11].Value = model.RentPhone;
			parameters[12].Value = model.RrcBillId;
			parameters[13].Value = model.PlanRtnDateTime;
			parameters[14].Value = model.ActualRtnDateTime;
			parameters[15].Value = model.BillStatus;
			parameters[16].Value = model.DateTimeCreated;
			parameters[17].Value = model.UserCreator;
			parameters[18].Value = model.DateTimeModified;
			parameters[19].Value = model.UserModified;
			parameters[20].Value = model.State;
			parameters[21].Value = model.OrgId;

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
		public bool Update(Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Inv_Rcv_Bill_Hd set ");
			strSql.Append("Id=@Id,");
			strSql.Append("RcvType=@RcvType,");
			strSql.Append("RcvUserId=@RcvUserId,");
			strSql.Append("RcvUserName=@RcvUserName,");
			strSql.Append("RcvPhone=@RcvPhone,");
			strSql.Append("RcvDateTime=@RcvDateTime,");
			strSql.Append("RcvReason=@RcvReason,");
			strSql.Append("RcvAddress=@RcvAddress,");
			strSql.Append("RentSubject=@RentSubject,");
			strSql.Append("RentUserId=@RentUserId,");
			strSql.Append("RentUserName=@RentUserName,");
			strSql.Append("RentPhone=@RentPhone,");
			strSql.Append("RrcBillId=@RrcBillId,");
			strSql.Append("PlanRtnDateTime=@PlanRtnDateTime,");
			strSql.Append("ActualRtnDateTime=@ActualRtnDateTime,");
			strSql.Append("BillStatus=@BillStatus,");
			strSql.Append("DateTimeCreated=@DateTimeCreated,");
			strSql.Append("UserCreator=@UserCreator,");
			strSql.Append("DateTimeModified=@DateTimeModified,");
			strSql.Append("UserModified=@UserModified,");
			strSql.Append("State=@State,");
			strSql.Append("OrgId=@OrgId");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4),
					new SQLiteParameter("@RcvType", DbType.String,0),
					new SQLiteParameter("@RcvUserId", DbType.Int32,4),
					new SQLiteParameter("@RcvUserName", DbType.String,0),
					new SQLiteParameter("@RcvPhone", DbType.String,0),
					new SQLiteParameter("@RcvDateTime", DbType.Date),
					new SQLiteParameter("@RcvReason", DbType.String,0),
					new SQLiteParameter("@RcvAddress", DbType.String,0),
					new SQLiteParameter("@RentSubject", DbType.String,0),
					new SQLiteParameter("@RentUserId", DbType.String,0),
					new SQLiteParameter("@RentUserName", DbType.String,0),
					new SQLiteParameter("@RentPhone", DbType.String,0),
					new SQLiteParameter("@RrcBillId", DbType.Int32,4),
					new SQLiteParameter("@PlanRtnDateTime", DbType.Date),
					new SQLiteParameter("@ActualRtnDateTime", DbType.Date),
					new SQLiteParameter("@BillStatus", DbType.String,0),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1),
					new SQLiteParameter("@OrgId", DbType.String,0)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.RcvType;
			parameters[2].Value = model.RcvUserId;
			parameters[3].Value = model.RcvUserName;
			parameters[4].Value = model.RcvPhone;
			parameters[5].Value = model.RcvDateTime;
			parameters[6].Value = model.RcvReason;
			parameters[7].Value = model.RcvAddress;
			parameters[8].Value = model.RentSubject;
			parameters[9].Value = model.RentUserId;
			parameters[10].Value = model.RentUserName;
			parameters[11].Value = model.RentPhone;
			parameters[12].Value = model.RrcBillId;
			parameters[13].Value = model.PlanRtnDateTime;
			parameters[14].Value = model.ActualRtnDateTime;
			parameters[15].Value = model.BillStatus;
			parameters[16].Value = model.DateTimeCreated;
			parameters[17].Value = model.UserCreator;
			parameters[18].Value = model.DateTimeModified;
			parameters[19].Value = model.UserModified;
			parameters[20].Value = model.State;
			parameters[21].Value = model.OrgId;

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
			strSql.Append("delete from Inv_Rcv_Bill_Hd ");
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
		public Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,RcvType,RcvUserId,RcvUserName,RcvPhone,RcvDateTime,RcvReason,RcvAddress,RentSubject,RentUserId,RentUserName,RentPhone,RrcBillId,PlanRtnDateTime,ActualRtnDateTime,BillStatus,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId from Inv_Rcv_Bill_Hd ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd model=new Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd();
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
		public Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd model=new Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["RcvType"]!=null)
				{
					model.RcvType=row["RcvType"].ToString();
				}
				if(row["RcvUserId"]!=null && row["RcvUserId"].ToString()!="")
				{
					model.RcvUserId=int.Parse(row["RcvUserId"].ToString());
				}
				if(row["RcvUserName"]!=null)
				{
					model.RcvUserName=row["RcvUserName"].ToString();
				}
				if(row["RcvPhone"]!=null)
				{
					model.RcvPhone=row["RcvPhone"].ToString();
				}
				if(row["RcvDateTime"]!=null && row["RcvDateTime"].ToString()!="")
				{
					model.RcvDateTime=DateTime.Parse(row["RcvDateTime"].ToString());
				}
				if(row["RcvReason"]!=null)
				{
					model.RcvReason=row["RcvReason"].ToString();
				}
				if(row["RcvAddress"]!=null)
				{
					model.RcvAddress=row["RcvAddress"].ToString();
				}
				if(row["RentSubject"]!=null)
				{
					model.RentSubject=row["RentSubject"].ToString();
				}
				if(row["RentUserId"]!=null)
				{
					model.RentUserId=row["RentUserId"].ToString();
				}
				if(row["RentUserName"]!=null)
				{
					model.RentUserName=row["RentUserName"].ToString();
				}
				if(row["RentPhone"]!=null)
				{
					model.RentPhone=row["RentPhone"].ToString();
				}
				if(row["RrcBillId"]!=null && row["RrcBillId"].ToString()!="")
				{
					model.RrcBillId=int.Parse(row["RrcBillId"].ToString());
				}
				if(row["PlanRtnDateTime"]!=null && row["PlanRtnDateTime"].ToString()!="")
				{
					model.PlanRtnDateTime=DateTime.Parse(row["PlanRtnDateTime"].ToString());
				}
				if(row["ActualRtnDateTime"]!=null && row["ActualRtnDateTime"].ToString()!="")
				{
					model.ActualRtnDateTime=DateTime.Parse(row["ActualRtnDateTime"].ToString());
				}
				if(row["BillStatus"]!=null)
				{
					model.BillStatus=row["BillStatus"].ToString();
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
			strSql.Append("select Id,RcvType,RcvUserId,RcvUserName,RcvPhone,RcvDateTime,RcvReason,RcvAddress,RentSubject,RentUserId,RentUserName,RentPhone,RrcBillId,PlanRtnDateTime,ActualRtnDateTime,BillStatus,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId ");
			strSql.Append(" FROM Inv_Rcv_Bill_Hd ");
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
			strSql.Append("select count(1) FROM Inv_Rcv_Bill_Hd ");
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
			strSql.Append(")AS Row, T.*  from Inv_Rcv_Bill_Hd T ");
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
			parameters[0].Value = "Inv_Rcv_Bill_Hd";
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

