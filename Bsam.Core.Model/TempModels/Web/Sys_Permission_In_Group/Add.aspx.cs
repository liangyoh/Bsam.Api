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
namespace Bsam.Core.Model.Models.Web.Sys_Permission_In_Group
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtPermissionId.Text))
			{
				strErr+="PermissionId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPermissionGroupId.Text))
			{
				strErr+="PermissionGroupId格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int PermissionId=int.Parse(this.txtPermissionId.Text);
			int PermissionGroupId=int.Parse(this.txtPermissionGroupId.Text);

			Bsam.Core.Model.Models.Model.Sys_Permission_In_Group model=new Bsam.Core.Model.Models.Model.Sys_Permission_In_Group();
			model.PermissionId=PermissionId;
			model.PermissionGroupId=PermissionGroupId;

			Bsam.Core.Model.Models.BLL.Sys_Permission_In_Group bll=new Bsam.Core.Model.Models.BLL.Sys_Permission_In_Group();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
