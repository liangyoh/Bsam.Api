﻿using System;
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
namespace Bsam.Core.Model.Models.Web.Sys_Module
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
			if(this.txtModuleType.Text.Trim().Length==0)
			{
				strErr+="ModuleType不能为空！\\n";	
			}
			if(this.txtModuleCode.Text.Trim().Length==0)
			{
				strErr+="ModuleCode不能为空！\\n";	
			}
			if(this.txtModuleName.Text.Trim().Length==0)
			{
				strErr+="ModuleName不能为空！\\n";	
			}
			if(this.txtModuleDesc.Text.Trim().Length==0)
			{
				strErr+="ModuleDesc不能为空！\\n";	
			}
			if(this.txtModuleConfig.Text.Trim().Length==0)
			{
				strErr+="ModuleConfig不能为空！\\n";	
			}
			if(this.txtPath.Text.Trim().Length==0)
			{
				strErr+="Path不能为空！\\n";	
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
			string ModuleType=this.txtModuleType.Text;
			string ModuleCode=this.txtModuleCode.Text;
			string ModuleName=this.txtModuleName.Text;
			string ModuleDesc=this.txtModuleDesc.Text;
			string ModuleConfig=this.txtModuleConfig.Text;
			string Path=this.txtPath.Text;
			DateTime DateTimeCreated=DateTime.Parse(this.txtDateTimeCreated.Text);
			string UserCreator=this.txtUserCreator.Text;
			DateTime DateTimeModified=DateTime.Parse(this.txtDateTimeModified.Text);
			string UserModified=this.txtUserModified.Text;
			bool State=this.chkState.Checked;

			Bsam.Core.Model.Models.Model.Sys_Module model=new Bsam.Core.Model.Models.Model.Sys_Module();
			model.Id=Id;
			model.ModuleType=ModuleType;
			model.ModuleCode=ModuleCode;
			model.ModuleName=ModuleName;
			model.ModuleDesc=ModuleDesc;
			model.ModuleConfig=ModuleConfig;
			model.Path=Path;
			model.DateTimeCreated=DateTimeCreated;
			model.UserCreator=UserCreator;
			model.DateTimeModified=DateTimeModified;
			model.UserModified=UserModified;
			model.State=State;

			Bsam.Core.Model.Models.BLL.Sys_Module bll=new Bsam.Core.Model.Models.BLL.Sys_Module();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
