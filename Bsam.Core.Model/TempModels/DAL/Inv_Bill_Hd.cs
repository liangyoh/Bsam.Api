/**  版本信息模板在安装目录下，可自行修改。
* Inv_Bill_Hd.cs
*
* 功 能： N/A
* 类 名： Inv_Bill_Hd
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:34   N/A    初版
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
	/// 数据访问类:Inv_Bill_Hd
	/// </summary>
	public partial class Inv_Bill_Hd
	{
		public Inv_Bill_Hd()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Bsam.Core.Model.Models.Model.Inv_Bill_Hd model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Inv_Bill_Hd(");
			strSql.Append("Id,BillType,PlanQty,ActualQty,SrcBillId,SrcBillNo,InvId,InvCode,InvName,InvAddress,RcvUser,RcvDateTime,RcvReason,RcvAddress,BillStatus,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId)");
			strSql.Append(" values (");
			strSql.Append("@Id,@BillType,@PlanQty,@ActualQty,@SrcBillId,@SrcBillNo,@InvId,@InvCode,@InvName,@InvAddress,@RcvUser,@RcvDateTime,@RcvReason,@RcvAddress,@BillStatus,@DateTimeCreated,@UserCreator,@DateTimeModified,@UserModified,@State,@OrgId)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,4),
					new SQLiteParameter("@BillType", DbType.String,0),
					new SQLiteParameter("@PlanQty", DbType.Decimal,8),
					new SQLiteParameter("@ActualQty", DbType.Decimal,8),
					new SQLiteParameter("@SrcBillId", DbType.Int32,4),
					new SQLiteParameter("@SrcBillNo", DbType.String,0),
					new SQLiteParameter("@InvId", DbType.Int32,4),
					new SQLiteParameter("@InvCode", DbType.String,0),
					new SQLiteParameter("@InvName", DbType.String,0),
					new SQLiteParameter("@InvAddress", DbType.String,0),
					new SQLiteParameter("@RcvUser", DbType.String,0),
					new SQLiteParameter("@RcvDateTime", DbType.Date),
					new SQLiteParameter("@RcvReason", DbType.String,0),
					new SQLiteParameter("@RcvAddress", DbType.String,0),
					new SQLiteParameter("@BillStatus", DbType.String,0),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1),
					new SQLiteParameter("@OrgId", DbType.String,0)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.BillType;
			parameters[2].Value = model.PlanQty;
			parameters[3].Value = model.ActualQty;
			parameters[4].Value = model.SrcBillId;
			parameters[5].Value = model.SrcBillNo;
			parameters[6].Value = model.InvId;
			parameters[7].Value = model.InvCode;
			parameters[8].Value = model.InvName;
			parameters[9].Value = model.InvAddress;
			parameters[10].Value = model.RcvUser;
			parameters[11].Value = model.RcvDateTime;
			parameters[12].Value = model.RcvReason;
			parameters[13].Value = model.RcvAddress;
			parameters[14].Value = model.BillStatus;
			parameters[15].Value = model.DateTimeCreated;
			parameters[16].Value = model.UserCreator;
			parameters[17].Value = model.DateTimeModified;
			parameters[18].Value = model.UserModified;
			parameters[19].Value = model.State;
			parameters[20].Value = model.OrgId;

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
		public bool Update(Bsam.Core.Model.Models.Model.Inv_Bill_Hd model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Inv_Bill_Hd set ");
			strSql.Append("Id=@Id,");
			strSql.Append("BillType=@BillType,");
			strSql.Append("PlanQty=@PlanQty,");
			strSql.Append("ActualQty=@ActualQty,");
			strSql.Append("SrcBillId=@SrcBillId,");
			strSql.Append("SrcBillNo=@SrcBillNo,");
			strSql.Append("InvId=@InvId,");
			strSql.Append("InvCode=@InvCode,");
			strSql.Append("InvName=@InvName,");
			strSql.Append("InvAddress=@InvAddress,");
			strSql.Append("RcvUser=@RcvUser,");
			strSql.Append("RcvDateTime=@RcvDateTime,");
			strSql.Append("RcvReason=@RcvReason,");
			strSql.Append("RcvAddress=@RcvAddress,");
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
					new SQLiteParameter("@BillType", DbType.String,0),
					new SQLiteParameter("@PlanQty", DbType.Decimal,8),
					new SQLiteParameter("@ActualQty", DbType.Decimal,8),
					new SQLiteParameter("@SrcBillId", DbType.Int32,4),
					new SQLiteParameter("@SrcBillNo", DbType.String,0),
					new SQLiteParameter("@InvId", DbType.Int32,4),
					new SQLiteParameter("@InvCode", DbType.String,0),
					new SQLiteParameter("@InvName", DbType.String,0),
					new SQLiteParameter("@InvAddress", DbType.String,0),
					new SQLiteParameter("@RcvUser", DbType.String,0),
					new SQLiteParameter("@RcvDateTime", DbType.Date),
					new SQLiteParameter("@RcvReason", DbType.String,0),
					new SQLiteParameter("@RcvAddress", DbType.String,0),
					new SQLiteParameter("@BillStatus", DbType.String,0),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1),
					new SQLiteParameter("@OrgId", DbType.String,0)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.BillType;
			parameters[2].Value = model.PlanQty;
			parameters[3].Value = model.ActualQty;
			parameters[4].Value = model.SrcBillId;
			parameters[5].Value = model.SrcBillNo;
			parameters[6].Value = model.InvId;
			parameters[7].Value = model.InvCode;
			parameters[8].Value = model.InvName;
			parameters[9].Value = model.InvAddress;
			parameters[10].Value = model.RcvUser;
			parameters[11].Value = model.RcvDateTime;
			parameters[12].Value = model.RcvReason;
			parameters[13].Value = model.RcvAddress;
			parameters[14].Value = model.BillStatus;
			parameters[15].Value = model.DateTimeCreated;
			parameters[16].Value = model.UserCreator;
			parameters[17].Value = model.DateTimeModified;
			parameters[18].Value = model.UserModified;
			parameters[19].Value = model.State;
			parameters[20].Value = model.OrgId;

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
			strSql.Append("delete from Inv_Bill_Hd ");
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
		public Bsam.Core.Model.Models.Model.Inv_Bill_Hd GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,BillType,PlanQty,ActualQty,SrcBillId,SrcBillNo,InvId,InvCode,InvName,InvAddress,RcvUser,RcvDateTime,RcvReason,RcvAddress,BillStatus,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId from Inv_Bill_Hd ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			Bsam.Core.Model.Models.Model.Inv_Bill_Hd model=new Bsam.Core.Model.Models.Model.Inv_Bill_Hd();
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
		public Bsam.Core.Model.Models.Model.Inv_Bill_Hd DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.Inv_Bill_Hd model=new Bsam.Core.Model.Models.Model.Inv_Bill_Hd();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["BillType"]!=null)
				{
					model.BillType=row["BillType"].ToString();
				}
				if(row["PlanQty"]!=null && row["PlanQty"].ToString()!="")
				{
					model.PlanQty=decimal.Parse(row["PlanQty"].ToString());
				}
				if(row["ActualQty"]!=null && row["ActualQty"].ToString()!="")
				{
					model.ActualQty=decimal.Parse(row["ActualQty"].ToString());
				}
				if(row["SrcBillId"]!=null && row["SrcBillId"].ToString()!="")
				{
					model.SrcBillId=int.Parse(row["SrcBillId"].ToString());
				}
				if(row["SrcBillNo"]!=null)
				{
					model.SrcBillNo=row["SrcBillNo"].ToString();
				}
				if(row["InvId"]!=null && row["InvId"].ToString()!="")
				{
					model.InvId=int.Parse(row["InvId"].ToString());
				}
				if(row["InvCode"]!=null)
				{
					model.InvCode=row["InvCode"].ToString();
				}
				if(row["InvName"]!=null)
				{
					model.InvName=row["InvName"].ToString();
				}
				if(row["InvAddress"]!=null)
				{
					model.InvAddress=row["InvAddress"].ToString();
				}
				if(row["RcvUser"]!=null)
				{
					model.RcvUser=row["RcvUser"].ToString();
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
			strSql.Append("select Id,BillType,PlanQty,ActualQty,SrcBillId,SrcBillNo,InvId,InvCode,InvName,InvAddress,RcvUser,RcvDateTime,RcvReason,RcvAddress,BillStatus,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId ");
			strSql.Append(" FROM Inv_Bill_Hd ");
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
			strSql.Append("select count(1) FROM Inv_Bill_Hd ");
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
			strSql.Append(")AS Row, T.*  from Inv_Bill_Hd T ");
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
			parameters[0].Value = "Inv_Bill_Hd";
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

