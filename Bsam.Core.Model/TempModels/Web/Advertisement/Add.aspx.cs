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
namespace Bsam.Core.Model.Models.Web.Advertisement
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtImgUrl.Text.Trim().Length==0)
			{
				strErr+="ImgUrl不能为空！\\n";	
			}
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="Title不能为空！\\n";	
			}
			if(this.txtUrl.Text.Trim().Length==0)
			{
				strErr+="Url不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreatedate.Text))
			{
				strErr+="Createdate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ImgUrl=this.txtImgUrl.Text;
			string Title=this.txtTitle.Text;
			string Url=this.txtUrl.Text;
			string Remark=this.txtRemark.Text;
			DateTime Createdate=DateTime.Parse(this.txtCreatedate.Text);

			Bsam.Core.Model.Models.Model.Advertisement model=new Bsam.Core.Model.Models.Model.Advertisement();
			model.ImgUrl=ImgUrl;
			model.Title=Title;
			model.Url=Url;
			model.Remark=Remark;
			model.Createdate=Createdate;

			Bsam.Core.Model.Models.BLL.Advertisement bll=new Bsam.Core.Model.Models.BLL.Advertisement();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
