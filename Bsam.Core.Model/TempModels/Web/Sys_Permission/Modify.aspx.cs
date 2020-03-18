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
namespace Bsam.Core.Model.Models.Web.Sys_Permission
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
		Bsam.Core.Model.Models.BLL.Sys_Permission bll=new Bsam.Core.Model.Models.BLL.Sys_Permission();
		Bsam.Core.Model.Models.Model.Sys_Permission model=bll.GetModel();
		this.txtId.Text=model.Id.ToString();
		this.txtPermissionName.Text=model.PermissionName;
		this.txtPermissionDesc.Text=model.PermissionDesc;
		this.txtRequestType.Text=model.RequestType;
		this.txtClientType.Text=model.ClientType;
		this.txtModuleId.Text=model.ModuleId.ToString();
		this.txtDateTimeCreated.Text=model.DateTimeCreated.ToString();
		this.txtUserCreator.Text=model.UserCreator;
		this.txtDateTimeModified.Text=model.DateTimeModified.ToString();
		this.txtUserModified.Text=model.UserModified;
		this.chkState.Checked=model.State;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtId.Text))
			{
				strErr+="Id格式错误！\\n";	
			}
			if(this.txtPermissionName.Text.Trim().Length==0)
			{
				strErr+="PermissionName不能为空！\\n";	
			}
			if(this.txtPermissionDesc.Text.Trim().Length==0)
			{
				strErr+="PermissionDesc不能为空！\\n";	
			}
			if(this.txtRequestType.Text.Trim().Length==0)
			{
				strErr+="RequestType不能为空！\\n";	
			}
			if(this.txtClientType.Text.Trim().Length==0)
			{
				strErr+="ClientType不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtModuleId.Text))
			{
				strErr+="ModuleId格式错误！\\n";	
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

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.txtId.Text);
			string PermissionName=this.txtPermissionName.Text;
			string PermissionDesc=this.txtPermissionDesc.Text;
			string RequestType=this.txtRequestType.Text;
			string ClientType=this.txtClientType.Text;
			int ModuleId=int.Parse(this.txtModuleId.Text);
			DateTime DateTimeCreated=DateTime.Parse(this.txtDateTimeCreated.Text);
			string UserCreator=this.txtUserCreator.Text;
			DateTime DateTimeModified=DateTime.Parse(this.txtDateTimeModified.Text);
			string UserModified=this.txtUserModified.Text;
			bool State=this.chkState.Checked;


			Bsam.Core.Model.Models.Model.Sys_Permission model=new Bsam.Core.Model.Models.Model.Sys_Permission();
			model.Id=Id;
			model.PermissionName=PermissionName;
			model.PermissionDesc=PermissionDesc;
			model.RequestType=RequestType;
			model.ClientType=ClientType;
			model.ModuleId=ModuleId;
			model.DateTimeCreated=DateTimeCreated;
			model.UserCreator=UserCreator;
			model.DateTimeModified=DateTimeModified;
			model.UserModified=UserModified;
			model.State=State;

			Bsam.Core.Model.Models.BLL.Sys_Permission bll=new Bsam.Core.Model.Models.BLL.Sys_Permission();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
