/**  版本信息模板在安装目录下，可自行修改。
* Inv_Onhand_Qty.cs
*
* 功 能： N/A
* 类 名： Inv_Onhand_Qty
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020-3-4 11:02:37   N/A    初版
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
	/// 数据访问类:Inv_Onhand_Qty
	/// </summary>
	public partial class Inv_Onhand_Qty
	{
		public Inv_Onhand_Qty()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Bsam.Core.Model.Models.Model.Inv_Onhand_Qty model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Inv_Onhand_Qty(");
			strSql.Append("Id,MitemId,InvId,DistrictId,LocId,Trans_Qty,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId)");
			strSql.Append(" values (");
			strSql.Append("@Id,@MitemId,@InvId,@DistrictId,@LocId,@Trans_Qty,@DateTimeCreated,@UserCreator,@DateTimeModified,@UserModified,@State,@OrgId)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,8),
					new SQLiteParameter("@MitemId", DbType.Int32,4),
					new SQLiteParameter("@InvId", DbType.Int32,4),
					new SQLiteParameter("@DistrictId", DbType.Int32,4),
					new SQLiteParameter("@LocId", DbType.Int32,4),
					new SQLiteParameter("@Trans_Qty", DbType.Decimal,8),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1),
					new SQLiteParameter("@OrgId", DbType.String,0)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.MitemId;
			parameters[2].Value = model.InvId;
			parameters[3].Value = model.DistrictId;
			parameters[4].Value = model.LocId;
			parameters[5].Value = model.Trans_Qty;
			parameters[6].Value = model.DateTimeCreated;
			parameters[7].Value = model.UserCreator;
			parameters[8].Value = model.DateTimeModified;
			parameters[9].Value = model.UserModified;
			parameters[10].Value = model.State;
			parameters[11].Value = model.OrgId;

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
		public bool Update(Bsam.Core.Model.Models.Model.Inv_Onhand_Qty model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Inv_Onhand_Qty set ");
			strSql.Append("Id=@Id,");
			strSql.Append("MitemId=@MitemId,");
			strSql.Append("InvId=@InvId,");
			strSql.Append("DistrictId=@DistrictId,");
			strSql.Append("LocId=@LocId,");
			strSql.Append("Trans_Qty=@Trans_Qty,");
			strSql.Append("DateTimeCreated=@DateTimeCreated,");
			strSql.Append("UserCreator=@UserCreator,");
			strSql.Append("DateTimeModified=@DateTimeModified,");
			strSql.Append("UserModified=@UserModified,");
			strSql.Append("State=@State,");
			strSql.Append("OrgId=@OrgId");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,8),
					new SQLiteParameter("@MitemId", DbType.Int32,4),
					new SQLiteParameter("@InvId", DbType.Int32,4),
					new SQLiteParameter("@DistrictId", DbType.Int32,4),
					new SQLiteParameter("@LocId", DbType.Int32,4),
					new SQLiteParameter("@Trans_Qty", DbType.Decimal,8),
					new SQLiteParameter("@DateTimeCreated", DbType.Date),
					new SQLiteParameter("@UserCreator", DbType.String,0),
					new SQLiteParameter("@DateTimeModified", DbType.Date),
					new SQLiteParameter("@UserModified", DbType.String,0),
					new SQLiteParameter("@State", DbType.bit,1),
					new SQLiteParameter("@OrgId", DbType.String,0)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.MitemId;
			parameters[2].Value = model.InvId;
			parameters[3].Value = model.DistrictId;
			parameters[4].Value = model.LocId;
			parameters[5].Value = model.Trans_Qty;
			parameters[6].Value = model.DateTimeCreated;
			parameters[7].Value = model.UserCreator;
			parameters[8].Value = model.DateTimeModified;
			parameters[9].Value = model.UserModified;
			parameters[10].Value = model.State;
			parameters[11].Value = model.OrgId;

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
			strSql.Append("delete from Inv_Onhand_Qty ");
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
		public Bsam.Core.Model.Models.Model.Inv_Onhand_Qty GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,MitemId,InvId,DistrictId,LocId,Trans_Qty,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId from Inv_Onhand_Qty ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			Bsam.Core.Model.Models.Model.Inv_Onhand_Qty model=new Bsam.Core.Model.Models.Model.Inv_Onhand_Qty();
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
		public Bsam.Core.Model.Models.Model.Inv_Onhand_Qty DataRowToModel(DataRow row)
		{
			Bsam.Core.Model.Models.Model.Inv_Onhand_Qty model=new Bsam.Core.Model.Models.Model.Inv_Onhand_Qty();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["MitemId"]!=null && row["MitemId"].ToString()!="")
				{
					model.MitemId=int.Parse(row["MitemId"].ToString());
				}
				if(row["InvId"]!=null && row["InvId"].ToString()!="")
				{
					model.InvId=int.Parse(row["InvId"].ToString());
				}
				if(row["DistrictId"]!=null && row["DistrictId"].ToString()!="")
				{
					model.DistrictId=int.Parse(row["DistrictId"].ToString());
				}
				if(row["LocId"]!=null && row["LocId"].ToString()!="")
				{
					model.LocId=int.Parse(row["LocId"].ToString());
				}
				if(row["Trans_Qty"]!=null && row["Trans_Qty"].ToString()!="")
				{
					model.Trans_Qty=decimal.Parse(row["Trans_Qty"].ToString());
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
			strSql.Append("select Id,MitemId,InvId,DistrictId,LocId,Trans_Qty,DateTimeCreated,UserCreator,DateTimeModified,UserModified,State,OrgId ");
			strSql.Append(" FROM Inv_Onhand_Qty ");
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
			strSql.Append("select count(1) FROM Inv_Onhand_Qty ");
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
			strSql.Append(")AS Row, T.*  from Inv_Onhand_Qty T ");
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
			parameters[0].Value = "Inv_Onhand_Qty";
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

