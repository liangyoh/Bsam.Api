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
namespace Bsam.Core.Model.Models.Web.UserRole
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
		Bsam.Core.Model.Models.BLL.UserRole bll=new Bsam.Core.Model.Models.BLL.UserRole();
		Bsam.Core.Model.Models.Model.UserRole model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.chkIsDeleted.Checked=model.IsDeleted;
		this.txtUserId.Text=model.UserId.ToString();
		this.txtRoleId.Text=model.RoleId.ToString();
		this.txtCreateId.Text=model.CreateId.ToString();
		this.txtCreateBy.Text=model.CreateBy;
		this.txtCreateTime.Text=model.CreateTime.ToString();
		this.txtModifyId.Text=model.ModifyId.ToString();
		this.txtModifyBy.Text=model.ModifyBy;
		this.txtModifyTime.Text=model.ModifyTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserId.Text))
			{
				strErr+="UserId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRoleId.Text))
			{
				strErr+="RoleId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCreateId.Text))
			{
				strErr+="CreateId格式错误！\\n";	
			}
			if(this.txtCreateBy.Text.Trim().Length==0)
			{
				strErr+="CreateBy不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="CreateTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtModifyId.Text))
			{
				strErr+="ModifyId格式错误！\\n";	
			}
			if(this.txtModifyBy.Text.Trim().Length==0)
			{
				strErr+="ModifyBy不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtModifyTime.Text))
			{
				strErr+="ModifyTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			bool IsDeleted=this.chkIsDeleted.Checked;
			int UserId=int.Parse(this.txtUserId.Text);
			int RoleId=int.Parse(this.txtRoleId.Text);
			int CreateId=int.Parse(this.txtCreateId.Text);
			string CreateBy=this.txtCreateBy.Text;
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);
			int ModifyId=int.Parse(this.txtModifyId.Text);
			string ModifyBy=this.txtModifyBy.Text;
			DateTime ModifyTime=DateTime.Parse(this.txtModifyTime.Text);


			Bsam.Core.Model.Models.Model.UserRole model=new Bsam.Core.Model.Models.Model.UserRole();
			model.Id=Id;
			model.IsDeleted=IsDeleted;
			model.UserId=UserId;
			model.RoleId=RoleId;
			model.CreateId=CreateId;
			model.CreateBy=CreateBy;
			model.CreateTime=CreateTime;
			model.ModifyId=ModifyId;
			model.ModifyBy=ModifyBy;
			model.ModifyTime=ModifyTime;

			Bsam.Core.Model.Models.BLL.UserRole bll=new Bsam.Core.Model.Models.BLL.UserRole();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
