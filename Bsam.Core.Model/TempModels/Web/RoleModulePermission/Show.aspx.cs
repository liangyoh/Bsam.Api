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
namespace Bsam.Core.Model.Models.Web.RoleModulePermission
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int Id=(Convert.ToInt32(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(int Id)
	{
		Bsam.Core.Model.Models.BLL.RoleModulePermission bll=new Bsam.Core.Model.Models.BLL.RoleModulePermission();
		Bsam.Core.Model.Models.Model.RoleModulePermission model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblIsDeleted.Text=model.IsDeleted?"是":"否";
		this.lblRoleId.Text=model.RoleId.ToString();
		this.lblModuleId.Text=model.ModuleId.ToString();
		this.lblPermissionId.Text=model.PermissionId.ToString();
		this.lblCreateId.Text=model.CreateId.ToString();
		this.lblCreateBy.Text=model.CreateBy;
		this.lblCreateTime.Text=model.CreateTime.ToString();
		this.lblModifyId.Text=model.ModifyId.ToString();
		this.lblModifyBy.Text=model.ModifyBy;
		this.lblModifyTime.Text=model.ModifyTime.ToString();

	}


    }
}
