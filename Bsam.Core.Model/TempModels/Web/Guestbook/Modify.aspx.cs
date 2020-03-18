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
namespace Bsam.Core.Model.Models.Web.Guestbook
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Bsam.Core.Model.Models.BLL.Guestbook bll=new Bsam.Core.Model.Models.BLL.Guestbook();
		Bsam.Core.Model.Models.Model.Guestbook model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtblogId.Text=model.blogId.ToString();
		this.txtcreatedate.Text=model.createdate.ToString();
		this.txtusername.Text=model.username;
		this.txtphone.Text=model.phone;
		this.txtQQ.Text=model.QQ;
		this.txtbody.Text=model.body;
		this.txtip.Text=model.ip;
		this.chkisshow.Checked=model.isshow;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtblogId.Text))
			{
				strErr+="blogId格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcreatedate.Text))
			{
				strErr+="createdate格式错误！\\n";	
			}
			if(this.txtusername.Text.Trim().Length==0)
			{
				strErr+="username不能为空！\\n";	
			}
			if(this.txtphone.Text.Trim().Length==0)
			{
				strErr+="phone不能为空！\\n";	
			}
			if(this.txtQQ.Text.Trim().Length==0)
			{
				strErr+="QQ不能为空！\\n";	
			}
			if(this.txtbody.Text.Trim().Length==0)
			{
				strErr+="body不能为空！\\n";	
			}
			if(this.txtip.Text.Trim().Length==0)
			{
				strErr+="ip不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int blogId=int.Parse(this.txtblogId.Text);
			DateTime createdate=DateTime.Parse(this.txtcreatedate.Text);
			string username=this.txtusername.Text;
			string phone=this.txtphone.Text;
			string QQ=this.txtQQ.Text;
			string body=this.txtbody.Text;
			string ip=this.txtip.Text;
			bool isshow=this.chkisshow.Checked;


			Bsam.Core.Model.Models.Model.Guestbook model=new Bsam.Core.Model.Models.Model.Guestbook();
			model.id=id;
			model.blogId=blogId;
			model.createdate=createdate;
			model.username=username;
			model.phone=phone;
			model.QQ=QQ;
			model.body=body;
			model.ip=ip;
			model.isshow=isshow;

			Bsam.Core.Model.Models.BLL.Guestbook bll=new Bsam.Core.Model.Models.BLL.Guestbook();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
