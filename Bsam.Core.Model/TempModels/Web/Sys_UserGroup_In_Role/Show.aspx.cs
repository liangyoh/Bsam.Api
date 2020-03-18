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
namespace Bsam.Core.Model.Models.Web.Sys_UserGroup_In_Role
{
    public partial class Show : Page
    {        
        		public string strid=""; 
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
		Bsam.Core.Model.Models.BLL.Sys_UserGroup_In_Role bll=new Bsam.Core.Model.Models.BLL.Sys_UserGroup_In_Role();
		Bsam.Core.Model.Models.Model.Sys_UserGroup_In_Role model=bll.GetModel();
		this.lblUserGroupId.Text=model.UserGroupId.ToString();
		this.lblRoleId.Text=model.RoleId.ToString();

	}


    }
}
