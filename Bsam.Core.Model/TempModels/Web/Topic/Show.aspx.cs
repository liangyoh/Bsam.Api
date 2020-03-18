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
namespace Bsam.Core.Model.Models.Web.Topic
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
		Bsam.Core.Model.Models.BLL.Topic bll=new Bsam.Core.Model.Models.BLL.Topic();
		Bsam.Core.Model.Models.Model.Topic model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lbltLogo.Text=model.tLogo;
		this.lbltName.Text=model.tName;
		this.lbltDetail.Text=model.tDetail;
		this.lbltAuthor.Text=model.tAuthor;
		this.lbltSectendDetail.Text=model.tSectendDetail;
		this.lbltIsDelete.Text=model.tIsDelete?"是":"否";
		this.lbltRead.Text=model.tRead.ToString();
		this.lbltCommend.Text=model.tCommend.ToString();
		this.lbltGood.Text=model.tGood.ToString();
		this.lbltCreatetime.Text=model.tCreatetime.ToString();
		this.lbltUpdatetime.Text=model.tUpdatetime.ToString();

	}


    }
}
