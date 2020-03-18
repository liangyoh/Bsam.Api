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
namespace Bsam.Core.Model.Models.Web.TopicDetail
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
		Bsam.Core.Model.Models.BLL.TopicDetail bll=new Bsam.Core.Model.Models.BLL.TopicDetail();
		Bsam.Core.Model.Models.Model.TopicDetail model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblTopicId.Text=model.TopicId.ToString();
		this.lbltdLogo.Text=model.tdLogo;
		this.lbltdName.Text=model.tdName;
		this.lbltdContent.Text=model.tdContent;
		this.lbltdDetail.Text=model.tdDetail;
		this.lbltdSectendDetail.Text=model.tdSectendDetail;
		this.lbltdIsDelete.Text=model.tdIsDelete?"是":"否";
		this.lbltdRead.Text=model.tdRead.ToString();
		this.lbltdCommend.Text=model.tdCommend.ToString();
		this.lbltdGood.Text=model.tdGood.ToString();
		this.lbltdCreatetime.Text=model.tdCreatetime.ToString();
		this.lbltdUpdatetime.Text=model.tdUpdatetime.ToString();
		this.lbltdTop.Text=model.tdTop.ToString();
		this.lbltdAuthor.Text=model.tdAuthor;

	}


    }
}
