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
namespace Bsam.Core.Model.Models.Web.Advertisement
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
		Bsam.Core.Model.Models.BLL.Advertisement bll=new Bsam.Core.Model.Models.BLL.Advertisement();
		Bsam.Core.Model.Models.Model.Advertisement model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblImgUrl.Text=model.ImgUrl;
		this.lblTitle.Text=model.Title;
		this.lblUrl.Text=model.Url;
		this.lblRemark.Text=model.Remark;
		this.lblCreatedate.Text=model.Createdate.ToString();

	}


    }
}
