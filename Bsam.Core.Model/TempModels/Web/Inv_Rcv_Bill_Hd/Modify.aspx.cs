using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Bsam.Core.Model.Models.Web.Inv_Rcv_Bill_Hd
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		Bsam.Core.Model.Models.BLL.Inv_Rcv_Bill_Hd bll=new Bsam.Core.Model.Models.BLL.Inv_Rcv_Bill_Hd();
		Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd model=bll.GetModel();
		this.txtId.Text=model.Id.ToString();
		this.txtRcvType.Text=model.RcvType;
		this.txtRcvUserId.Text=model.RcvUserId.ToString();
		this.txtRcvUserName.Text=model.RcvUserName;
		this.txtRcvPhone.Text=model.RcvPhone;
		this.txtRcvDateTime.Text=model.RcvDateTime.ToString();
		this.txtRcvReason.Text=model.RcvReason;
		this.txtRcvAddress.Text=model.RcvAddress;
		this.txtRentSubject.Text=model.RentSubject;
		this.txtRentUserId.Text=model.RentUserId;
		this.txtRentUserName.Text=model.RentUserName;
		this.txtRentPhone.Text=model.RentPhone;
		this.txtRrcBillId.Text=model.RrcBillId.ToString();
		this.txtPlanRtnDateTime.Text=model.PlanRtnDateTime.ToString();
		this.txtActualRtnDateTime.Text=model.ActualRtnDateTime.ToString();
		this.txtBillStatus.Text=model.BillStatus;
		this.txtDateTimeCreated.Text=model.DateTimeCreated.ToString();
		this.txtUserCreator.Text=model.UserCreator;
		this.txtDateTimeModified.Text=model.DateTimeModified.ToString();
		this.txtUserModified.Text=model.UserModified;
		this.chkState.Checked=model.State;
		this.txtOrgId.Text=model.OrgId;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtId.Text))
			{
				strErr+="Id格式错误！\\n";	
			}
			if(this.txtRcvType.Text.Trim().Length==0)
			{
				strErr+="RcvType不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtRcvUserId.Text))
			{
				strErr+="RcvUserId格式错误！\\n";	
			}
			if(this.txtRcvUserName.Text.Trim().Length==0)
			{
				strErr+="RcvUserName不能为空！\\n";	
			}
			if(this.txtRcvPhone.Text.Trim().Length==0)
			{
				strErr+="RcvPhone不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRcvDateTime.Text))
			{
				strErr+="RcvDateTime格式错误！\\n";	
			}
			if(this.txtRcvReason.Text.Trim().Length==0)
			{
				strErr+="RcvReason不能为空！\\n";	
			}
			if(this.txtRcvAddress.Text.Trim().Length==0)
			{
				strErr+="RcvAddress不能为空！\\n";	
			}
			if(this.txtRentSubject.Text.Trim().Length==0)
			{
				strErr+="RentSubject不能为空！\\n";	
			}
			if(this.txtRentUserId.Text.Trim().Length==0)
			{
				strErr+="RentUserId不能为空！\\n";	
			}
			if(this.txtRentUserName.Text.Trim().Length==0)
			{
				strErr+="RentUserName不能为空！\\n";	
			}
			if(this.txtRentPhone.Text.Trim().Length==0)
			{
				strErr+="RentPhone不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtRrcBillId.Text))
			{
				strErr+="RrcBillId格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtPlanRtnDateTime.Text))
			{
				strErr+="PlanRtnDateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtActualRtnDateTime.Text))
			{
				strErr+="ActualRtnDateTime格式错误！\\n";	
			}
			if(this.txtBillStatus.Text.Trim().Length==0)
			{
				strErr+="BillStatus不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDateTimeCreated.Text))
			{
				strErr+="DateTimeCreated格式错误！\\n";	
			}
			if(this.txtUserCreator.Text.Trim().Length==0)
			{
				strErr+="UserCreator不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDateTimeModified.Text))
			{
				strErr+="DateTimeModified格式错误！\\n";	
			}
			if(this.txtUserModified.Text.Trim().Length==0)
			{
				strErr+="UserModified不能为空！\\n";	
			}
			if(this.txtOrgId.Text.Trim().Length==0)
			{
				strErr+="OrgId不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.txtId.Text);
			string RcvType=this.txtRcvType.Text;
			int RcvUserId=int.Parse(this.txtRcvUserId.Text);
			string RcvUserName=this.txtRcvUserName.Text;
			string RcvPhone=this.txtRcvPhone.Text;
			DateTime RcvDateTime=DateTime.Parse(this.txtRcvDateTime.Text);
			string RcvReason=this.txtRcvReason.Text;
			string RcvAddress=this.txtRcvAddress.Text;
			string RentSubject=this.txtRentSubject.Text;
			string RentUserId=this.txtRentUserId.Text;
			string RentUserName=this.txtRentUserName.Text;
			string RentPhone=this.txtRentPhone.Text;
			int RrcBillId=int.Parse(this.txtRrcBillId.Text);
			DateTime PlanRtnDateTime=DateTime.Parse(this.txtPlanRtnDateTime.Text);
			DateTime ActualRtnDateTime=DateTime.Parse(this.txtActualRtnDateTime.Text);
			string BillStatus=this.txtBillStatus.Text;
			DateTime DateTimeCreated=DateTime.Parse(this.txtDateTimeCreated.Text);
			string UserCreator=this.txtUserCreator.Text;
			DateTime DateTimeModified=DateTime.Parse(this.txtDateTimeModified.Text);
			string UserModified=this.txtUserModified.Text;
			bool State=this.chkState.Checked;
			string OrgId=this.txtOrgId.Text;


			Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd model=new Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd();
			model.Id=Id;
			model.RcvType=RcvType;
			model.RcvUserId=RcvUserId;
			model.RcvUserName=RcvUserName;
			model.RcvPhone=RcvPhone;
			model.RcvDateTime=RcvDateTime;
			model.RcvReason=RcvReason;
			model.RcvAddress=RcvAddress;
			model.RentSubject=RentSubject;
			model.RentUserId=RentUserId;
			model.RentUserName=RentUserName;
			model.RentPhone=RentPhone;
			model.RrcBillId=RrcBillId;
			model.PlanRtnDateTime=PlanRtnDateTime;
			model.ActualRtnDateTime=ActualRtnDateTime;
			model.BillStatus=BillStatus;
			model.DateTimeCreated=DateTimeCreated;
			model.UserCreator=UserCreator;
			model.DateTimeModified=DateTimeModified;
			model.UserModified=UserModified;
			model.State=State;
			model.OrgId=OrgId;

			Bsam.Core.Model.Models.BLL.Inv_Rcv_Bill_Hd bll=new Bsam.Core.Model.Models.BLL.Inv_Rcv_Bill_Hd();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
