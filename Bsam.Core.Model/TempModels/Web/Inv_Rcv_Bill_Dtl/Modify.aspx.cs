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
namespace Bsam.Core.Model.Models.Web.Inv_Rcv_Bill_Dtl
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
		Bsam.Core.Model.Models.BLL.Inv_Rcv_Bill_Dtl bll=new Bsam.Core.Model.Models.BLL.Inv_Rcv_Bill_Dtl();
		Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Dtl model=bll.GetModel();
		this.txtId.Text=model.Id.ToString();
		this.txtBillId.Text=model.BillId.ToString();
		this.txtMitemCode.Text=model.MitemCode;
		this.txtPlanQty.Text=model.PlanQty.ToString();
		this.txtActualQty.Text=model.ActualQty.ToString();
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
			if(!PageValidate.IsNumber(txtBillId.Text))
			{
				strErr+="BillId格式错误！\\n";	
			}
			if(this.txtMitemCode.Text.Trim().Length==0)
			{
				strErr+="MitemCode不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPlanQty.Text))
			{
				strErr+="PlanQty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtActualQty.Text))
			{
				strErr+="ActualQty格式错误！\\n";	
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
			int BillId=int.Parse(this.txtBillId.Text);
			string MitemCode=this.txtMitemCode.Text;
			decimal PlanQty=decimal.Parse(this.txtPlanQty.Text);
			decimal ActualQty=decimal.Parse(this.txtActualQty.Text);
			DateTime DateTimeCreated=DateTime.Parse(this.txtDateTimeCreated.Text);
			string UserCreator=this.txtUserCreator.Text;
			DateTime DateTimeModified=DateTime.Parse(this.txtDateTimeModified.Text);
			string UserModified=this.txtUserModified.Text;
			bool State=this.chkState.Checked;
			string OrgId=this.txtOrgId.Text;


			Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Dtl model=new Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Dtl();
			model.Id=Id;
			model.BillId=BillId;
			model.MitemCode=MitemCode;
			model.PlanQty=PlanQty;
			model.ActualQty=ActualQty;
			model.DateTimeCreated=DateTimeCreated;
			model.UserCreator=UserCreator;
			model.DateTimeModified=DateTimeModified;
			model.UserModified=UserModified;
			model.State=State;
			model.OrgId=OrgId;

			Bsam.Core.Model.Models.BLL.Inv_Rcv_Bill_Dtl bll=new Bsam.Core.Model.Models.BLL.Inv_Rcv_Bill_Dtl();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
