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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
