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
namespace Bsam.Core.Model.Models.Web.Sys_Role
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
		Bsam.Core.Model.Models.BLL.Sys_Role bll=new Bsam.Core.Model.Models.BLL.Sys_Role();
		Bsam.Core.Model.Models.Model.Sys_Role model=bll.GetModel();
		this.txtId.Text=model.Id.ToString();
		this.txtRoleName.Text=model.RoleName;
		this.txtRoleDesc.Text=model.RoleDesc;
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
			if(this.txtRoleName.Text.Trim().Length==0)
			{
				strErr+="RoleName不能为空！\\n";	
			}
			if(this.txtRoleDesc.Text.Trim().Length==0)
			{
				strErr+="RoleDesc不能为空！\\n";	
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
			string RoleName=this.txtRoleName.Text;
			string RoleDesc=this.txtRoleDesc.Text;
			DateTime DateTimeCreated=DateTime.Parse(this.txtDateTimeCreated.Text);
			string UserCreator=this.txtUserCreator.Text;
			DateTime DateTimeModified=DateTime.Parse(this.txtDateTimeModified.Text);
			string UserModified=this.txtUserModified.Text;
			bool State=this.chkState.Checked;
			string OrgId=this.txtOrgId.Text;


			Bsam.Core.Model.Models.Model.Sys_Role model=new Bsam.Core.Model.Models.Model.Sys_Role();
			model.Id=Id;
			model.RoleName=RoleName;
			model.RoleDesc=RoleDesc;
			model.DateTimeCreated=DateTimeCreated;
			model.UserCreator=UserCreator;
			model.DateTimeModified=DateTimeModified;
			model.UserModified=UserModified;
			model.State=State;
			model.OrgId=OrgId;

			Bsam.Core.Model.Models.BLL.Sys_Role bll=new Bsam.Core.Model.Models.BLL.Sys_Role();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
