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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(int Id)
	{
		Bsam.Core.Model.Models.BLL.Advertisement bll=new Bsam.Core.Model.Models.BLL.Advertisement();
		Bsam.Core.Model.Models.Model.Advertisement model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtImgUrl.Text=model.ImgUrl;
		this.txtTitle.Text=model.Title;
		this.txtUrl.Text=model.Url;
		this.txtRemark.Text=model.Remark;
		this.txtCreatedate.Text=model.Createdate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int Id=int.Parse(this.lblId.Text);
			string ImgUrl=this.txtImgUrl.Text;
			string Title=this.txtTitle.Text;
			string Url=this.txtUrl.Text;
			string Remark=this.txtRemark.Text;
			DateTime Createdate=DateTime.Parse(this.txtCreatedate.Text);


			Bsam.Core.Model.Models.Model.Advertisement model=new Bsam.Core.Model.Models.Model.Advertisement();
			model.Id=Id;
			model.ImgUrl=ImgUrl;
			model.Title=Title;
			model.Url=Url;
			model.Remark=Remark;
			model.Createdate=Createdate;

			Bsam.Core.Model.Models.BLL.Advertisement bll=new Bsam.Core.Model.Models.BLL.Advertisement();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
