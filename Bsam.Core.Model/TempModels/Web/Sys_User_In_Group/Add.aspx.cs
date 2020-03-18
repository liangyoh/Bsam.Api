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
namespace Bsam.Core.Model.Models.Web.Sys_User_In_Group
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserId.Text))
			{
				strErr+="UserId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserGroupId.Text))
			{
				strErr+="UserGroupId格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UserId=int.Parse(this.txtUserId.Text);
			int UserGroupId=int.Parse(this.txtUserGroupId.Text);

			Bsam.Core.Model.Models.Model.Sys_User_In_Group model=new Bsam.Core.Model.Models.Model.Sys_User_In_Group();
			model.UserId=UserId;
			model.UserGroupId=UserGroupId;

			Bsam.Core.Model.Models.BLL.Sys_User_In_Group bll=new Bsam.Core.Model.Models.BLL.Sys_User_In_Group();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
