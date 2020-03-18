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
namespace Bsam.Core.Model.Models.Web.PasswordLib
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtplURL.Text.Trim().Length==0)
			{
				strErr+="plURL不能为空！\\n";	
			}
			if(this.txtplPWD.Text.Trim().Length==0)
			{
				strErr+="plPWD不能为空！\\n";	
			}
			if(this.txtplAccountName.Text.Trim().Length==0)
			{
				strErr+="plAccountName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtplStatus.Text))
			{
				strErr+="plStatus格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtplErrorCount.Text))
			{
				strErr+="plErrorCount格式错误！\\n";	
			}
			if(this.txtplHintPwd.Text.Trim().Length==0)
			{
				strErr+="plHintPwd不能为空！\\n";	
			}
			if(this.txtplHintquestion.Text.Trim().Length==0)
			{
				strErr+="plHintquestion不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtplCreateTime.Text))
			{
				strErr+="plCreateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtplUpdateTime.Text))
			{
				strErr+="plUpdateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtplLastErrTime.Text))
			{
				strErr+="plLastErrTime格式错误！\\n";	
			}
			if(this.txttest.Text.Trim().Length==0)
			{
				strErr+="test不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			bool IsDeleted=this.chkIsDeleted.Checked;
			string plURL=this.txtplURL.Text;
			string plPWD=this.txtplPWD.Text;
			string plAccountName=this.txtplAccountName.Text;
			int plStatus=int.Parse(this.txtplStatus.Text);
			int plErrorCount=int.Parse(this.txtplErrorCount.Text);
			string plHintPwd=this.txtplHintPwd.Text;
			string plHintquestion=this.txtplHintquestion.Text;
			DateTime plCreateTime=DateTime.Parse(this.txtplCreateTime.Text);
			DateTime plUpdateTime=DateTime.Parse(this.txtplUpdateTime.Text);
			DateTime plLastErrTime=DateTime.Parse(this.txtplLastErrTime.Text);
			string test=this.txttest.Text;

			Bsam.Core.Model.Models.Model.PasswordLib model=new Bsam.Core.Model.Models.Model.PasswordLib();
			model.IsDeleted=IsDeleted;
			model.plURL=plURL;
			model.plPWD=plPWD;
			model.plAccountName=plAccountName;
			model.plStatus=plStatus;
			model.plErrorCount=plErrorCount;
			model.plHintPwd=plHintPwd;
			model.plHintquestion=plHintquestion;
			model.plCreateTime=plCreateTime;
			model.plUpdateTime=plUpdateTime;
			model.plLastErrTime=plLastErrTime;
			model.test=test;

			Bsam.Core.Model.Models.BLL.PasswordLib bll=new Bsam.Core.Model.Models.BLL.PasswordLib();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
