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
namespace Bsam.Core.Model.Models.Web.Inv_Bill_Hd
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtId.Text))
			{
				strErr+="Id格式错误！\\n";	
			}
			if(this.txtBillType.Text.Trim().Length==0)
			{
				strErr+="BillType不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPlanQty.Text))
			{
				strErr+="PlanQty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtActualQty.Text))
			{
				strErr+="ActualQty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSrcBillId.Text))
			{
				strErr+="SrcBillId格式错误！\\n";	
			}
			if(this.txtSrcBillNo.Text.Trim().Length==0)
			{
				strErr+="SrcBillNo不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtInvId.Text))
			{
				strErr+="InvId格式错误！\\n";	
			}
			if(this.txtInvCode.Text.Trim().Length==0)
			{
				strErr+="InvCode不能为空！\\n";	
			}
			if(this.txtInvName.Text.Trim().Length==0)
			{
				strErr+="InvName不能为空！\\n";	
			}
			if(this.txtInvAddress.Text.Trim().Length==0)
			{
				strErr+="InvAddress不能为空！\\n";	
			}
			if(this.txtRcvUser.Text.Trim().Length==0)
			{
				strErr+="RcvUser不能为空！\\n";	
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
			string BillType=this.txtBillType.Text;
			decimal PlanQty=decimal.Parse(this.txtPlanQty.Text);
			decimal ActualQty=decimal.Parse(this.txtActualQty.Text);
			int SrcBillId=int.Parse(this.txtSrcBillId.Text);
			string SrcBillNo=this.txtSrcBillNo.Text;
			int InvId=int.Parse(this.txtInvId.Text);
			string InvCode=this.txtInvCode.Text;
			string InvName=this.txtInvName.Text;
			string InvAddress=this.txtInvAddress.Text;
			string RcvUser=this.txtRcvUser.Text;
			DateTime RcvDateTime=DateTime.Parse(this.txtRcvDateTime.Text);
			string RcvReason=this.txtRcvReason.Text;
			string RcvAddress=this.txtRcvAddress.Text;
			string BillStatus=this.txtBillStatus.Text;
			DateTime DateTimeCreated=DateTime.Parse(this.txtDateTimeCreated.Text);
			string UserCreator=this.txtUserCreator.Text;
			DateTime DateTimeModified=DateTime.Parse(this.txtDateTimeModified.Text);
			string UserModified=this.txtUserModified.Text;
			bool State=this.chkState.Checked;
			string OrgId=this.txtOrgId.Text;

			Bsam.Core.Model.Models.Model.Inv_Bill_Hd model=new Bsam.Core.Model.Models.Model.Inv_Bill_Hd();
			model.Id=Id;
			model.BillType=BillType;
			model.PlanQty=PlanQty;
			model.ActualQty=ActualQty;
			model.SrcBillId=SrcBillId;
			model.SrcBillNo=SrcBillNo;
			model.InvId=InvId;
			model.InvCode=InvCode;
			model.InvName=InvName;
			model.InvAddress=InvAddress;
			model.RcvUser=RcvUser;
			model.RcvDateTime=RcvDateTime;
			model.RcvReason=RcvReason;
			model.RcvAddress=RcvAddress;
			model.BillStatus=BillStatus;
			model.DateTimeCreated=DateTimeCreated;
			model.UserCreator=UserCreator;
			model.DateTimeModified=DateTimeModified;
			model.UserModified=UserModified;
			model.State=State;
			model.OrgId=OrgId;

			Bsam.Core.Model.Models.BLL.Inv_Bill_Hd bll=new Bsam.Core.Model.Models.BLL.Inv_Bill_Hd();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
