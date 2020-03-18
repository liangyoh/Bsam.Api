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
namespace Bsam.Core.Model.Models.Web.sysUserInfo
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
					int uID=(Convert.ToInt32(strid));
					ShowInfo(uID);
				}
			}
		}
		
	private void ShowInfo(int uID)
	{
		Bsam.Core.Model.Models.BLL.sysUserInfo bll=new Bsam.Core.Model.Models.BLL.sysUserInfo();
		Bsam.Core.Model.Models.Model.sysUserInfo model=bll.GetModel(uID);
		this.lbluID.Text=model.uID.ToString();
		this.lbluLoginName.Text=model.uLoginName;
		this.lbluLoginPWD.Text=model.uLoginPWD;
		this.lbluRealName.Text=model.uRealName;
		this.lbluStatus.Text=model.uStatus.ToString();
		this.lbluRemark.Text=model.uRemark;
		this.lbluCreateTime.Text=model.uCreateTime.ToString();
		this.lbluUpdateTime.Text=model.uUpdateTime.ToString();
		this.lbluLastErrTime.Text=model.uLastErrTime.ToString();
		this.lbluErrorCount.Text=model.uErrorCount.ToString();
		this.lblname.Text=model.name;
		this.lblsex.Text=model.sex.ToString();
		this.lblage.Text=model.age.ToString();
		this.lblbirth.Text=model.birth.ToString();
		this.lbladdr.Text=model.addr;
		this.lbltdIsDelete.Text=model.tdIsDelete?"是":"否";

	}


    }
}
