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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Bsam.Core.Model.Models.Web.BlogArticle
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int bID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(bID);
				}
			}
		}
			
	private void ShowInfo(int bID)
	{
		Bsam.Core.Model.Models.BLL.BlogArticle bll=new Bsam.Core.Model.Models.BLL.BlogArticle();
		Bsam.Core.Model.Models.Model.BlogArticle model=bll.GetModel(bID);
		this.lblbID.Text=model.bID.ToString();
		this.txtbsubmitter.Text=model.bsubmitter;
		this.txtbtitle.Text=model.btitle;
		this.txtbcategory.Text=model.bcategory;
		this.txtbcontent.Text=model.bcontent;
		this.txtbtraffic.Text=model.btraffic.ToString();
		this.txtbcommentNum.Text=model.bcommentNum.ToString();
		this.txtbUpdateTime.Text=model.bUpdateTime.ToString();
		this.txtbCreateTime.Text=model.bCreateTime.ToString();
		this.txtbRemark.Text=model.bRemark;
		this.chkIsDeleted.Checked=model.IsDeleted;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtbsubmitter.Text.Trim().Length==0)
			{
				strErr+="bsubmitter不能为空！\\n";	
			}
			if(this.txtbtitle.Text.Trim().Length==0)
			{
				strErr+="btitle不能为空！\\n";	
			}
			if(this.txtbcategory.Text.Trim().Length==0)
			{
				strErr+="bcategory不能为空！\\n";	
			}
			if(this.txtbcontent.Text.Trim().Length==0)
			{
				strErr+="bcontent不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtbtraffic.Text))
			{
				strErr+="btraffic格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtbcommentNum.Text))
			{
				strErr+="bcommentNum格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtbUpdateTime.Text))
			{
				strErr+="bUpdateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtbCreateTime.Text))
			{
				strErr+="bCreateTime格式错误！\\n";	
			}
			if(this.txtbRemark.Text.Trim().Length==0)
			{
				strErr+="bRemark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int bID=int.Parse(this.lblbID.Text);
			string bsubmitter=this.txtbsubmitter.Text;
			string btitle=this.txtbtitle.Text;
			string bcategory=this.txtbcategory.Text;
			string bcontent=this.txtbcontent.Text;
			int btraffic=int.Parse(this.txtbtraffic.Text);
			int bcommentNum=int.Parse(this.txtbcommentNum.Text);
			DateTime bUpdateTime=DateTime.Parse(this.txtbUpdateTime.Text);
			DateTime bCreateTime=DateTime.Parse(this.txtbCreateTime.Text);
			string bRemark=this.txtbRemark.Text;
			bool IsDeleted=this.chkIsDeleted.Checked;


			Bsam.Core.Model.Models.Model.BlogArticle model=new Bsam.Core.Model.Models.Model.BlogArticle();
			model.bID=bID;
			model.bsubmitter=bsubmitter;
			model.btitle=btitle;
			model.bcategory=bcategory;
			model.bcontent=bcontent;
			model.btraffic=btraffic;
			model.bcommentNum=bcommentNum;
			model.bUpdateTime=bUpdateTime;
			model.bCreateTime=bCreateTime;
			model.bRemark=bRemark;
			model.IsDeleted=IsDeleted;

			Bsam.Core.Model.Models.BLL.BlogArticle bll=new Bsam.Core.Model.Models.BLL.BlogArticle();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
