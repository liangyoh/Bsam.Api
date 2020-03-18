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
namespace Bsam.Core.Model.Models.Web.Inv_Rcv_Bill_Hd
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
		Bsam.Core.Model.Models.BLL.Inv_Rcv_Bill_Hd bll=new Bsam.Core.Model.Models.BLL.Inv_Rcv_Bill_Hd();
		Bsam.Core.Model.Models.Model.Inv_Rcv_Bill_Hd model=bll.GetModel();
		this.lblId.Text=model.Id.ToString();
		this.lblRcvType.Text=model.RcvType;
		this.lblRcvUserId.Text=model.RcvUserId.ToString();
		this.lblRcvUserName.Text=model.RcvUserName;
		this.lblRcvPhone.Text=model.RcvPhone;
		this.lblRcvDateTime.Text=model.RcvDateTime.ToString();
		this.lblRcvReason.Text=model.RcvReason;
		this.lblRcvAddress.Text=model.RcvAddress;
		this.lblRentSubject.Text=model.RentSubject;
		this.lblRentUserId.Text=model.RentUserId;
		this.lblRentUserName.Text=model.RentUserName;
		this.lblRentPhone.Text=model.RentPhone;
		this.lblRrcBillId.Text=model.RrcBillId.ToString();
		this.lblPlanRtnDateTime.Text=model.PlanRtnDateTime.ToString();
		this.lblActualRtnDateTime.Text=model.ActualRtnDateTime.ToString();
		this.lblBillStatus.Text=model.BillStatus;
		this.lblDateTimeCreated.Text=model.DateTimeCreated.ToString();
		this.lblUserCreator.Text=model.UserCreator;
		this.lblDateTimeModified.Text=model.DateTimeModified.ToString();
		this.lblUserModified.Text=model.UserModified;
		this.lblState.Text=model.State?"是":"否";
		this.lblOrgId.Text=model.OrgId;

	}


    }
}
