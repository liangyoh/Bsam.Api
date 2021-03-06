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
namespace Bsam.Core.Model.Models.Web.Module
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtParentId.Text))
			{
				strErr+="ParentId格式错误！\\n";	
			}
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="Name不能为空！\\n";	
			}
			if(this.txtLinkUrl.Text.Trim().Length==0)
			{
				strErr+="LinkUrl不能为空！\\n";	
			}
			if(this.txtArea.Text.Trim().Length==0)
			{
				strErr+="Area不能为空！\\n";	
			}
			if(this.txtController.Text.Trim().Length==0)
			{
				strErr+="Controller不能为空！\\n";	
			}
			if(this.txtAction.Text.Trim().Length==0)
			{
				strErr+="Action不能为空！\\n";	
			}
			if(this.txtIcon.Text.Trim().Length==0)
			{
				strErr+="Icon不能为空！\\n";	
			}
			if(this.txtCode.Text.Trim().Length==0)
			{
				strErr+="Code不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderSort.Text))
			{
				strErr+="OrderSort格式错误！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCreateId.Text))
			{
				strErr+="CreateId格式错误！\\n";	
			}
			if(this.txtCreateBy.Text.Trim().Length==0)
			{
				strErr+="CreateBy不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="CreateTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtModifyId.Text))
			{
				strErr+="ModifyId格式错误！\\n";	
			}
			if(this.txtModifyBy.Text.Trim().Length==0)
			{
				strErr+="ModifyBy不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtModifyTime.Text))
			{
				strErr+="ModifyTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			bool IsDeleted=this.chkIsDeleted.Checked;
			int ParentId=int.Parse(this.txtParentId.Text);
			string Name=this.txtName.Text;
			string LinkUrl=this.txtLinkUrl.Text;
			string Area=this.txtArea.Text;
			string Controller=this.txtController.Text;
			string Action=this.txtAction.Text;
			string Icon=this.txtIcon.Text;
			string Code=this.txtCode.Text;
			int OrderSort=int.Parse(this.txtOrderSort.Text);
			string Description=this.txtDescription.Text;
			bool IsMenu=this.chkIsMenu.Checked;
			bool Enabled=this.chkEnabled.Checked;
			int CreateId=int.Parse(this.txtCreateId.Text);
			string CreateBy=this.txtCreateBy.Text;
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);
			int ModifyId=int.Parse(this.txtModifyId.Text);
			string ModifyBy=this.txtModifyBy.Text;
			DateTime ModifyTime=DateTime.Parse(this.txtModifyTime.Text);

			Bsam.Core.Model.Models.Model.Module model=new Bsam.Core.Model.Models.Model.Module();
			model.IsDeleted=IsDeleted;
			model.ParentId=ParentId;
			model.Name=Name;
			model.LinkUrl=LinkUrl;
			model.Area=Area;
			model.Controller=Controller;
			model.Action=Action;
			model.Icon=Icon;
			model.Code=Code;
			model.OrderSort=OrderSort;
			model.Description=Description;
			model.IsMenu=IsMenu;
			model.Enabled=Enabled;
			model.CreateId=CreateId;
			model.CreateBy=CreateBy;
			model.CreateTime=CreateTime;
			model.ModifyId=ModifyId;
			model.ModifyBy=ModifyBy;
			model.ModifyTime=ModifyTime;

			Bsam.Core.Model.Models.BLL.Module bll=new Bsam.Core.Model.Models.BLL.Module();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
