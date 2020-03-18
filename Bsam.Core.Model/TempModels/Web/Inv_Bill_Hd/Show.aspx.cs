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
namespace Bsam.Core.Model.Models.Web.Inv_Bill_Hd
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
		Bsam.Core.Model.Models.BLL.Inv_Bill_Hd bll=new Bsam.Core.Model.Models.BLL.Inv_Bill_Hd();
		Bsam.Core.Model.Models.Model.Inv_Bill_Hd model=bll.GetModel();
		this.lblId.Text=model.Id.ToString();
		this.lblBillType.Text=model.BillType;
		this.lblPlanQty.Text=model.PlanQty.ToString();
		this.lblActualQty.Text=model.ActualQty.ToString();
		this.lblSrcBillId.Text=model.SrcBillId.ToString();
		this.lblSrcBillNo.Text=model.SrcBillNo;
		this.lblInvId.Text=model.InvId.ToString();
		this.lblInvCode.Text=model.InvCode;
		this.lblInvName.Text=model.InvName;
		this.lblInvAddress.Text=model.InvAddress;
		this.lblRcvUser.Text=model.RcvUser;
		this.lblRcvDateTime.Text=model.RcvDateTime.ToString();
		this.lblRcvReason.Text=model.RcvReason;
		this.lblRcvAddress.Text=model.RcvAddress;
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
