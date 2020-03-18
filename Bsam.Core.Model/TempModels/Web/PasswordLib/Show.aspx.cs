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
namespace Bsam.Core.Model.Models.Web.PasswordLib
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
					int PLID=(Convert.ToInt32(strid));
					ShowInfo(PLID);
				}
			}
		}
		
	private void ShowInfo(int PLID)
	{
		Bsam.Core.Model.Models.BLL.PasswordLib bll=new Bsam.Core.Model.Models.BLL.PasswordLib();
		Bsam.Core.Model.Models.Model.PasswordLib model=bll.GetModel(PLID);
		this.lblPLID.Text=model.PLID.ToString();
		this.lblIsDeleted.Text=model.IsDeleted?"是":"否";
		this.lblplURL.Text=model.plURL;
		this.lblplPWD.Text=model.plPWD;
		this.lblplAccountName.Text=model.plAccountName;
		this.lblplStatus.Text=model.plStatus.ToString();
		this.lblplErrorCount.Text=model.plErrorCount.ToString();
		this.lblplHintPwd.Text=model.plHintPwd;
		this.lblplHintquestion.Text=model.plHintquestion;
		this.lblplCreateTime.Text=model.plCreateTime.ToString();
		this.lblplUpdateTime.Text=model.plUpdateTime.ToString();
		this.lblplLastErrTime.Text=model.plLastErrTime.ToString();
		this.lbltest.Text=model.test;

	}


    }
}
