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
namespace Bsam.Core.Model.Models.Web.Permission
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
		Bsam.Core.Model.Models.BLL.Permission bll=new Bsam.Core.Model.Models.BLL.Permission();
		Bsam.Core.Model.Models.Model.Permission model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblCode.Text=model.Code;
		this.lblName.Text=model.Name;
		this.lblIsButton.Text=model.IsButton?"是":"否";
		this.lblIsHide.Text=model.IsHide?"是":"否";
		this.lblFunc.Text=model.Func;
		this.lblPid.Text=model.Pid.ToString();
		this.lblMid.Text=model.Mid.ToString();
		this.lblOrderSort.Text=model.OrderSort.ToString();
		this.lblIcon.Text=model.Icon;
		this.lblDescription.Text=model.Description;
		this.lblEnabled.Text=model.Enabled?"是":"否";
		this.lblCreateId.Text=model.CreateId.ToString();
		this.lblCreateBy.Text=model.CreateBy;
		this.lblCreateTime.Text=model.CreateTime.ToString();
		this.lblModifyId.Text=model.ModifyId.ToString();
		this.lblModifyBy.Text=model.ModifyBy;
		this.lblModifyTime.Text=model.ModifyTime.ToString();
		this.lblIsDeleted.Text=model.IsDeleted?"是":"否";

	}


    }
}
