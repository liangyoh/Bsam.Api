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
namespace Bsam.Core.Model.Models.Web.Sfc_Mitem
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
		Bsam.Core.Model.Models.BLL.Sfc_Mitem bll=new Bsam.Core.Model.Models.BLL.Sfc_Mitem();
		Bsam.Core.Model.Models.Model.Sfc_Mitem model=bll.GetModel();
		this.lblId.Text=model.Id.ToString();
		this.lblMitemCode.Text=model.MitemCode;
		this.lblMitemName.Text=model.MitemName;
		this.lblMitemDesc.Text=model.MitemDesc;
		this.lblMitemType.Text=model.MitemType;
		this.lblBrand.Text=model.Brand;
		this.lblBuyer.Text=model.Buyer;
		this.lblDutyPerson.Text=model.DutyPerson;
		this.lblSupplierId.Text=model.SupplierId.ToString();
		this.lblDefaultInvId.Text=model.DefaultInvId.ToString();
		this.lblUom.Text=model.Uom;
		this.lblDateTimeCreated.Text=model.DateTimeCreated.ToString();
		this.lblUserCreator.Text=model.UserCreator;
		this.lblDateTimeModified.Text=model.DateTimeModified.ToString();
		this.lblUserModified.Text=model.UserModified;
		this.lblState.Text=model.State?"是":"否";
		this.lblOrgId.Text=model.OrgId;

	}


    }
}
