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
namespace Bsam.Core.Model.Models.Web.OperateLog
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtArea.Text.Trim().Length==0)
			{
				strErr+="Area不能为空！\\n";	
			}
			if(this.txtController.Text.Trim().Length==0)
			{
				strErr+="Controller不能为空！\\n";	
			}
			if(this.txtAction.Text.Trim().Length==0)
			{
				strErr+="Action不能为空！\\n";	
			}
			if(this.txtIPAddress.Text.Trim().Length==0)
			{
				strErr+="IPAddress不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLogTime.Text))
			{
				strErr+="LogTime格式错误！\\n";	
			}
			if(this.txtLoginName.Text.Trim().Length==0)
			{
				strErr+="LoginName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserId.Text))
			{
				strErr+="UserId格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			bool IsDeleted=this.chkIsDeleted.Checked;
			string Area=this.txtArea.Text;
			string Controller=this.txtController.Text;
			string Action=this.txtAction.Text;
			string IPAddress=this.txtIPAddress.Text;
			string Description=this.txtDescription.Text;
			DateTime LogTime=DateTime.Parse(this.txtLogTime.Text);
			string LoginName=this.txtLoginName.Text;
			int UserId=int.Parse(this.txtUserId.Text);

			Bsam.Core.Model.Models.Model.OperateLog model=new Bsam.Core.Model.Models.Model.OperateLog();
			model.IsDeleted=IsDeleted;
			model.Area=Area;
			model.Controller=Controller;
			model.Action=Action;
			model.IPAddress=IPAddress;
			model.Description=Description;
			model.LogTime=LogTime;
			model.LoginName=LoginName;
			model.UserId=UserId;

			Bsam.Core.Model.Models.BLL.OperateLog bll=new Bsam.Core.Model.Models.BLL.OperateLog();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
