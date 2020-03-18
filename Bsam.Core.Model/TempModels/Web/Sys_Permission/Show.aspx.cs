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
namespace Bsam.Core.Model.Models.Web.Sys_Permission
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
		Bsam.Core.Model.Models.BLL.Sys_Permission bll=new Bsam.Core.Model.Models.BLL.Sys_Permission();
		Bsam.Core.Model.Models.Model.Sys_Permission model=bll.GetModel();
		this.lblId.Text=model.Id.ToString();
		this.lblPermissionName.Text=model.PermissionName;
		this.lblPermissionDesc.Text=model.PermissionDesc;
		this.lblRequestType.Text=model.RequestType;
		this.lblClientType.Text=model.ClientType;
		this.lblModuleId.Text=model.ModuleId.ToString();
		this.lblDateTimeCreated.Text=model.DateTimeCreated.ToString();
		this.lblUserCreator.Text=model.UserCreator;
		this.lblDateTimeModified.Text=model.DateTimeModified.ToString();
		this.lblUserModified.Text=model.UserModified;
		this.lblState.Text=model.State?"是":"否";

	}


    }
}
