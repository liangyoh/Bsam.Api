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
namespace Bsam.Core.Model.Models.Web.Guestbook
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
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		Bsam.Core.Model.Models.BLL.Guestbook bll=new Bsam.Core.Model.Models.BLL.Guestbook();
		Bsam.Core.Model.Models.Model.Guestbook model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblblogId.Text=model.blogId.ToString();
		this.lblcreatedate.Text=model.createdate.ToString();
		this.lblusername.Text=model.username;
		this.lblphone.Text=model.phone;
		this.lblQQ.Text=model.QQ;
		this.lblbody.Text=model.body;
		this.lblip.Text=model.ip;
		this.lblisshow.Text=model.isshow?"是":"否";

	}


    }
}
