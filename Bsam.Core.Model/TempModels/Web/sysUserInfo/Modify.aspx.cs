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
namespace Bsam.Core.Model.Models.Web.sysUserInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int uID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(uID);
				}
			}
		}
			
	private void ShowInfo(int uID)
	{
		Bsam.Core.Model.Models.BLL.sysUserInfo bll=new Bsam.Core.Model.Models.BLL.sysUserInfo();
		Bsam.Core.Model.Models.Model.sysUserInfo model=bll.GetModel(uID);
		this.lbluID.Text=model.uID.ToString();
		this.txtuLoginName.Text=model.uLoginName;
		this.txtuLoginPWD.Text=model.uLoginPWD;
		this.txtuRealName.Text=model.uRealName;
		this.txtuStatus.Text=model.uStatus.ToString();
		this.txtuRemark.Text=model.uRemark;
		this.txtuCreateTime.Text=model.uCreateTime.ToString();
		this.txtuUpdateTime.Text=model.uUpdateTime.ToString();
		this.txtuLastErrTime.Text=model.uLastErrTime.ToString();
		this.txtuErrorCount.Text=model.uErrorCount.ToString();
		this.txtname.Text=model.name;
		this.txtsex.Text=model.sex.ToString();
		this.txtage.Text=model.age.ToString();
		this.txtbirth.Text=model.birth.ToString();
		this.txtaddr.Text=model.addr;
		this.chktdIsDelete.Checked=model.tdIsDelete;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuLoginName.Text.Trim().Length==0)
			{
				strErr+="uLoginName不能为空！\\n";	
			}
			if(this.txtuLoginPWD.Text.Trim().Length==0)
			{
				strErr+="uLoginPWD不能为空！\\n";	
			}
			if(this.txtuRealName.Text.Trim().Length==0)
			{
				strErr+="uRealName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtuStatus.Text))
			{
				strErr+="uStatus格式错误！\\n";	
			}
			if(this.txtuRemark.Text.Trim().Length==0)
			{
				strErr+="uRemark不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtuCreateTime.Text))
			{
				strErr+="uCreateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtuUpdateTime.Text))
			{
				strErr+="uUpdateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtuLastErrTime.Text))
			{
				strErr+="uLastErrTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtuErrorCount.Text))
			{
				strErr+="uErrorCount格式错误！\\n";	
			}
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsex.Text))
			{
				strErr+="sex格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtage.Text))
			{
				strErr+="age格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtbirth.Text))
			{
				strErr+="birth格式错误！\\n";	
			}
			if(this.txtaddr.Text.Trim().Length==0)
			{
				strErr+="addr不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int uID=int.Parse(this.lbluID.Text);
			string uLoginName=this.txtuLoginName.Text;
			string uLoginPWD=this.txtuLoginPWD.Text;
			string uRealName=this.txtuRealName.Text;
			int uStatus=int.Parse(this.txtuStatus.Text);
			string uRemark=this.txtuRemark.Text;
			DateTime uCreateTime=DateTime.Parse(this.txtuCreateTime.Text);
			DateTime uUpdateTime=DateTime.Parse(this.txtuUpdateTime.Text);
			DateTime uLastErrTime=DateTime.Parse(this.txtuLastErrTime.Text);
			int uErrorCount=int.Parse(this.txtuErrorCount.Text);
			string name=this.txtname.Text;
			int sex=int.Parse(this.txtsex.Text);
			int age=int.Parse(this.txtage.Text);
			DateTime birth=DateTime.Parse(this.txtbirth.Text);
			string addr=this.txtaddr.Text;
			bool tdIsDelete=this.chktdIsDelete.Checked;


			Bsam.Core.Model.Models.Model.sysUserInfo model=new Bsam.Core.Model.Models.Model.sysUserInfo();
			model.uID=uID;
			model.uLoginName=uLoginName;
			model.uLoginPWD=uLoginPWD;
			model.uRealName=uRealName;
			model.uStatus=uStatus;
			model.uRemark=uRemark;
			model.uCreateTime=uCreateTime;
			model.uUpdateTime=uUpdateTime;
			model.uLastErrTime=uLastErrTime;
			model.uErrorCount=uErrorCount;
			model.name=name;
			model.sex=sex;
			model.age=age;
			model.birth=birth;
			model.addr=addr;
			model.tdIsDelete=tdIsDelete;

			Bsam.Core.Model.Models.BLL.sysUserInfo bll=new Bsam.Core.Model.Models.BLL.sysUserInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
