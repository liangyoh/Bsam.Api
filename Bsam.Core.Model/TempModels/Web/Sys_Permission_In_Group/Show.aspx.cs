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
namespace Bsam.Core.Model.Models.Web.Sys_Permission_In_Group
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
		Bsam.Core.Model.Models.BLL.Sys_Permission_In_Group bll=new Bsam.Core.Model.Models.BLL.Sys_Permission_In_Group();
		Bsam.Core.Model.Models.Model.Sys_Permission_In_Group model=bll.GetModel();
		this.lblPermissionId.Text=model.PermissionId.ToString();
		this.lblPermissionGroupId.Text=model.PermissionGroupId.ToString();

	}


    }
}
