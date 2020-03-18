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
namespace Bsam.Core.Model.Models.Web.Permission
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
		Bsam.Core.Model.Models.BLL.Permission bll=new Bsam.Core.Model.Models.BLL.Permission();
		Bsam.Core.Model.Models.Model.Permission model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtCode.Text=model.Code;
		this.txtName.Text=model.Name;
		this.chkIsButton.Checked=model.IsButton;
		this.chkIsHide.Checked=model.IsHide;
		this.txtFunc.Text=model.Func;
		this.txtPid.Text=model.Pid.ToString();
		this.txtMid.Text=model.Mid.ToString();
		this.txtOrderSort.Text=model.OrderSort.ToString();
		this.txtIcon.Text=model.Icon;
		this.txtDescription.Text=model.Description;
		this.chkEnabled.Checked=model.Enabled;
		this.txtCreateId.Text=model.CreateId.ToString();
		this.txtCreateBy.Text=model.CreateBy;
		this.txtCreateTime.Text=model.CreateTime.ToString();
		this.txtModifyId.Text=model.ModifyId.ToString();
		this.txtModifyBy.Text=model.ModifyBy;
		this.txtModifyTime.Text=model.ModifyTime.ToString();
		this.chkIsDeleted.Checked=model.IsDeleted;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCode.Text.Trim().Length==0)
			{
				strErr+="Code不能为空！\\n";	
			}
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="Name不能为空！\\n";	
			}
			if(this.txtFunc.Text.Trim().Length==0)
			{
				strErr+="Func不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPid.Text))
			{
				strErr+="Pid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMid.Text))
			{
				strErr+="Mid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderSort.Text))
			{
				strErr+="OrderSort格式错误！\\n";	
			}
			if(this.txtIcon.Text.Trim().Length==0)
			{
				strErr+="Icon不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
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
			string Code=this.txtCode.Text;
			string Name=this.txtName.Text;
			bool IsButton=this.chkIsButton.Checked;
			bool IsHide=this.chkIsHide.Checked;
			string Func=this.txtFunc.Text;
			int Pid=int.Parse(this.txtPid.Text);
			int Mid=int.Parse(this.txtMid.Text);
			int OrderSort=int.Parse(this.txtOrderSort.Text);
			string Icon=this.txtIcon.Text;
			string Description=this.txtDescription.Text;
			bool Enabled=this.chkEnabled.Checked;
			int CreateId=int.Parse(this.txtCreateId.Text);
			string CreateBy=this.txtCreateBy.Text;
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);
			int ModifyId=int.Parse(this.txtModifyId.Text);
			string ModifyBy=this.txtModifyBy.Text;
			DateTime ModifyTime=DateTime.Parse(this.txtModifyTime.Text);
			bool IsDeleted=this.chkIsDeleted.Checked;


			Bsam.Core.Model.Models.Model.Permission model=new Bsam.Core.Model.Models.Model.Permission();
			model.Id=Id;
			model.Code=Code;
			model.Name=Name;
			model.IsButton=IsButton;
			model.IsHide=IsHide;
			model.Func=Func;
			model.Pid=Pid;
			model.Mid=Mid;
			model.OrderSort=OrderSort;
			model.Icon=Icon;
			model.Description=Description;
			model.Enabled=Enabled;
			model.CreateId=CreateId;
			model.CreateBy=CreateBy;
			model.CreateTime=CreateTime;
			model.ModifyId=ModifyId;
			model.ModifyBy=ModifyBy;
			model.ModifyTime=ModifyTime;
			model.IsDeleted=IsDeleted;

			Bsam.Core.Model.Models.BLL.Permission bll=new Bsam.Core.Model.Models.BLL.Permission();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
