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
		Bsam.Core.Model.Models.BLL.Sys_User_In_Group bll=new Bsam.Core.Model.Models.BLL.Sys_User_In_Group();
		Bsam.Core.Model.Models.Model.Sys_User_In_Group model=bll.GetModel();
		this.txtUserId.Text=model.UserId.ToString();
		this.txtUserGroupId.Text=model.UserGroupId.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
