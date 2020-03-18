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
namespace Bsam.Core.Model.Models.Web.Sfc_Customer
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
			if(this.txtCustomerCode.Text.Trim().Length==0)
			{
				strErr+="CustomerCode不能为空！\\n";	
			}
			if(this.txtCustomerName.Text.Trim().Length==0)
			{
				strErr+="CustomerName不能为空！\\n";	
			}
			if(this.txtCustomerShortName.Text.Trim().Length==0)
			{
				strErr+="CustomerShortName不能为空！\\n";	
			}
			if(this.txtCustomerPhone.Text.Trim().Length==0)
			{
				strErr+="CustomerPhone不能为空！\\n";	
			}
			if(this.txtCustomerWebchat.Text.Trim().Length==0)
			{
				strErr+="CustomerWebchat不能为空！\\n";	
			}
			if(this.txtEnterpriseName.Text.Trim().Length==0)
			{
				strErr+="EnterpriseName不能为空！\\n";	
			}
			if(this.txtEnterpriseLegal.Text.Trim().Length==0)
			{
				strErr+="EnterpriseLegal不能为空！\\n";	
			}
			if(this.txtEnterpriseAddress.Text.Trim().Length==0)
			{
				strErr+="EnterpriseAddress不能为空！\\n";	
			}
			if(this.txtEnterprisePhone.Text.Trim().Length==0)
			{
				strErr+="EnterprisePhone不能为空！\\n";	
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
			string CustomerCode=this.txtCustomerCode.Text;
			string CustomerName=this.txtCustomerName.Text;
			string CustomerShortName=this.txtCustomerShortName.Text;
			string CustomerPhone=this.txtCustomerPhone.Text;
			string CustomerWebchat=this.txtCustomerWebchat.Text;
			string EnterpriseName=this.txtEnterpriseName.Text;
			string EnterpriseLegal=this.txtEnterpriseLegal.Text;
			string EnterpriseAddress=this.txtEnterpriseAddress.Text;
			string EnterprisePhone=this.txtEnterprisePhone.Text;
			DateTime DateTimeCreated=DateTime.Parse(this.txtDateTimeCreated.Text);
			string UserCreator=this.txtUserCreator.Text;
			DateTime DateTimeModified=DateTime.Parse(this.txtDateTimeModified.Text);
			string UserModified=this.txtUserModified.Text;
			bool State=this.chkState.Checked;
			string OrgId=this.txtOrgId.Text;

			Bsam.Core.Model.Models.Model.Sfc_Customer model=new Bsam.Core.Model.Models.Model.Sfc_Customer();
			model.Id=Id;
			model.CustomerCode=CustomerCode;
			model.CustomerName=CustomerName;
			model.CustomerShortName=CustomerShortName;
			model.CustomerPhone=CustomerPhone;
			model.CustomerWebchat=CustomerWebchat;
			model.EnterpriseName=EnterpriseName;
			model.EnterpriseLegal=EnterpriseLegal;
			model.EnterpriseAddress=EnterpriseAddress;
			model.EnterprisePhone=EnterprisePhone;
			model.DateTimeCreated=DateTimeCreated;
			model.UserCreator=UserCreator;
			model.DateTimeModified=DateTimeModified;
			model.UserModified=UserModified;
			model.State=State;
			model.OrgId=OrgId;

			Bsam.Core.Model.Models.BLL.Sfc_Customer bll=new Bsam.Core.Model.Models.BLL.Sfc_Customer();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
