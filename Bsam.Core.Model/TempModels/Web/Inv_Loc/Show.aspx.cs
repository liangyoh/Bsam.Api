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
namespace Bsam.Core.Model.Models.Web.Inv_Loc
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
		Bsam.Core.Model.Models.BLL.Inv_Loc bll=new Bsam.Core.Model.Models.BLL.Inv_Loc();
		Bsam.Core.Model.Models.Model.Inv_Loc model=bll.GetModel();
		this.lblId.Text=model.Id.ToString();
		this.lblLocCode.Text=model.LocCode;
		this.lblLocName.Text=model.LocName;
		this.lblLocDesc.Text=model.LocDesc;
		this.lblLocStatus.Text=model.LocStatus;
		this.lblLocOrder.Text=model.LocOrder.ToString();
		this.lblVolume.Text=model.Volume.ToString();
		this.lblVolumeUnit.Text=model.VolumeUnit;
		this.lblDateTimeCreated.Text=model.DateTimeCreated.ToString();
		this.lblUserCreator.Text=model.UserCreator;
		this.lblDateTimeModified.Text=model.DateTimeModified.ToString();
		this.lblUserModified.Text=model.UserModified;
		this.lblState.Text=model.State?"是":"否";
		this.lblOrgId.Text=model.OrgId;
		this.lblDistrictId.Text=model.DistrictId.ToString();
		this.lblInvId.Text=model.InvId.ToString();

	}


    }
}
