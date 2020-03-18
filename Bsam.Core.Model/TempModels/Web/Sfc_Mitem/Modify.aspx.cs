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
namespace Bsam.Core.Model.Models.Web.Sfc_Mitem
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
		Bsam.Core.Model.Models.BLL.Sfc_Mitem bll=new Bsam.Core.Model.Models.BLL.Sfc_Mitem();
		Bsam.Core.Model.Models.Model.Sfc_Mitem model=bll.GetModel();
		this.txtId.Text=model.Id.ToString();
		this.txtMitemCode.Text=model.MitemCode;
		this.txtMitemName.Text=model.MitemName;
		this.txtMitemDesc.Text=model.MitemDesc;
		this.txtMitemType.Text=model.MitemType;
		this.txtBrand.Text=model.Brand;
		this.txtBuyer.Text=model.Buyer;
		this.txtDutyPerson.Text=model.DutyPerson;
		this.txtSupplierId.Text=model.SupplierId.ToString();
		this.txtDefaultInvId.Text=model.DefaultInvId.ToString();
		this.txtUom.Text=model.Uom;
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
			if(this.txtMitemCode.Text.Trim().Length==0)
			{
				strErr+="MitemCode不能为空！\\n";	
			}
			if(this.txtMitemName.Text.Trim().Length==0)
			{
				strErr+="MitemName不能为空！\\n";	
			}
			if(this.txtMitemDesc.Text.Trim().Length==0)
			{
				strErr+="MitemDesc不能为空！\\n";	
			}
			if(this.txtMitemType.Text.Trim().Length==0)
			{
				strErr+="MitemType不能为空！\\n";	
			}
			if(this.txtBrand.Text.Trim().Length==0)
			{
				strErr+="Brand不能为空！\\n";	
			}
			if(this.txtBuyer.Text.Trim().Length==0)
			{
				strErr+="Buyer不能为空！\\n";	
			}
			if(this.txtDutyPerson.Text.Trim().Length==0)
			{
				strErr+="DutyPerson不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSupplierId.Text))
			{
				strErr+="SupplierId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDefaultInvId.Text))
			{
				strErr+="DefaultInvId格式错误！\\n";	
			}
			if(this.txtUom.Text.Trim().Length==0)
			{
				strErr+="Uom不能为空！\\n";	
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
			string MitemCode=this.txtMitemCode.Text;
			string MitemName=this.txtMitemName.Text;
			string MitemDesc=this.txtMitemDesc.Text;
			string MitemType=this.txtMitemType.Text;
			string Brand=this.txtBrand.Text;
			string Buyer=this.txtBuyer.Text;
			string DutyPerson=this.txtDutyPerson.Text;
			int SupplierId=int.Parse(this.txtSupplierId.Text);
			int DefaultInvId=int.Parse(this.txtDefaultInvId.Text);
			string Uom=this.txtUom.Text;
			DateTime DateTimeCreated=DateTime.Parse(this.txtDateTimeCreated.Text);
			string UserCreator=this.txtUserCreator.Text;
			DateTime DateTimeModified=DateTime.Parse(this.txtDateTimeModified.Text);
			string UserModified=this.txtUserModified.Text;
			bool State=this.chkState.Checked;
			string OrgId=this.txtOrgId.Text;


			Bsam.Core.Model.Models.Model.Sfc_Mitem model=new Bsam.Core.Model.Models.Model.Sfc_Mitem();
			model.Id=Id;
			model.MitemCode=MitemCode;
			model.MitemName=MitemName;
			model.MitemDesc=MitemDesc;
			model.MitemType=MitemType;
			model.Brand=Brand;
			model.Buyer=Buyer;
			model.DutyPerson=DutyPerson;
			model.SupplierId=SupplierId;
			model.DefaultInvId=DefaultInvId;
			model.Uom=Uom;
			model.DateTimeCreated=DateTimeCreated;
			model.UserCreator=UserCreator;
			model.DateTimeModified=DateTimeModified;
			model.UserModified=UserModified;
			model.State=State;
			model.OrgId=OrgId;

			Bsam.Core.Model.Models.BLL.Sfc_Mitem bll=new Bsam.Core.Model.Models.BLL.Sfc_Mitem();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
