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
namespace Bsam.Core.Model.Models.Web.BlogArticle
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
					int bID=(Convert.ToInt32(strid));
					ShowInfo(bID);
				}
			}
		}
		
	private void ShowInfo(int bID)
	{
		Bsam.Core.Model.Models.BLL.BlogArticle bll=new Bsam.Core.Model.Models.BLL.BlogArticle();
		Bsam.Core.Model.Models.Model.BlogArticle model=bll.GetModel(bID);
		this.lblbID.Text=model.bID.ToString();
		this.lblbsubmitter.Text=model.bsubmitter;
		this.lblbtitle.Text=model.btitle;
		this.lblbcategory.Text=model.bcategory;
		this.lblbcontent.Text=model.bcontent;
		this.lblbtraffic.Text=model.btraffic.ToString();
		this.lblbcommentNum.Text=model.bcommentNum.ToString();
		this.lblbUpdateTime.Text=model.bUpdateTime.ToString();
		this.lblbCreateTime.Text=model.bCreateTime.ToString();
		this.lblbRemark.Text=model.bRemark;
		this.lblIsDeleted.Text=model.IsDeleted?"是":"否";

	}


    }
}
