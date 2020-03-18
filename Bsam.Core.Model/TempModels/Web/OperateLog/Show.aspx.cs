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
namespace Bsam.Core.Model.Models.Web.OperateLog
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
		Bsam.Core.Model.Models.BLL.OperateLog bll=new Bsam.Core.Model.Models.BLL.OperateLog();
		Bsam.Core.Model.Models.Model.OperateLog model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblIsDeleted.Text=model.IsDeleted?"是":"否";
		this.lblArea.Text=model.Area;
		this.lblController.Text=model.Controller;
		this.lblAction.Text=model.Action;
		this.lblIPAddress.Text=model.IPAddress;
		this.lblDescription.Text=model.Description;
		this.lblLogTime.Text=model.LogTime.ToString();
		this.lblLoginName.Text=model.LoginName;
		this.lblUserId.Text=model.UserId.ToString();

	}


    }
}
