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
namespace Bsam.Core.Model.Models.Web.Sfc_Production_Bom
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		Bsam.Core.Model.Models.BLL.Sfc_Production_Bom bll=new Bsam.Core.Model.Models.BLL.Sfc_Production_Bom();
		Bsam.Core.Model.Models.Model.Sfc_Production_Bom model=bll.GetModel();
		this.txtId.Text=model.Id.ToString();
		this.txtProductId.Text=model.ProductId.ToString();
		this.txtMitemId.Text=model.MitemId.ToString();
		this.txtReqQty.Text=model.ReqQty.ToString();
		this.txtVersion.Text=model.Version;
		this.txtVersionDesc.Text=model.VersionDesc;
		this.txtBatchNo.Text=model.BatchNo;
		this.txtDateTimeCreated.Text=model.DateTimeCreated.ToString();
		this.txtUserCreator.Text=model.UserCreator;
		this.txtDateTimeModified.Text=model.DateTimeModified.ToString();
		this.txtUserModified.Text=model.UserModified;
		this.chkState.Checked=model.State;
		this.txtOrgId.Text=model.OrgId;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtId.Text))
			{
				strErr+="Id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtProductId.Text))
			{
				strErr+="ProductId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMitemId.Text))
			{
				strErr+="MitemId格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtReqQty.Text))
			{
				strErr+="ReqQty格式错误！\\n";	
			}
			if(this.txtVersion.Text.Trim().Length==0)
			{
				strErr+="Version不能为空！\\n";	
			}
			if(this.txtVersionDesc.Text.Trim().Length==0)
			{
				strErr+="VersionDesc不能为空！\\n";	
			}
			if(this.txtBatchNo.Text.Trim().Length==0)
			{
				strErr+="BatchNo不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDateTimeCreated.Text))
			{
				strErr+="DateTimeCreated格式错误！\\n";	
			}
			if(this.txtUserCreator.Text.Trim().Length==0)
			{
				strErr+="UserCreator不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDateTimeModified.Text))
			{
				strErr+="DateTimeModified格式错误！\\n";	
			}
			if(this.txtUserModified.Text.Trim().Length==0)
			{
				strErr+="UserModified不能为空！\\n";	
			}
			if(this.txtOrgId.Text.Trim().Length==0)
			{
				strErr+="OrgId不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.txtId.Text);
			int ProductId=int.Parse(this.txtProductId.Text);
			int MitemId=int.Parse(this.txtMitemId.Text);
			decimal ReqQty=decimal.Parse(this.txtReqQty.Text);
			string Version=this.txtVersion.Text;
			string VersionDesc=this.txtVersionDesc.Text;
			string BatchNo=this.txtBatchNo.Text;
			DateTime DateTimeCreated=DateTime.Parse(this.txtDateTimeCreated.Text);
			string UserCreator=this.txtUserCreator.Text;
			DateTime DateTimeModified=DateTime.Parse(this.txtDateTimeModified.Text);
			string UserModified=this.txtUserModified.Text;
			bool State=this.chkState.Checked;
			string OrgId=this.txtOrgId.Text;


			Bsam.Core.Model.Models.Model.Sfc_Production_Bom model=new Bsam.Core.Model.Models.Model.Sfc_Production_Bom();
			model.Id=Id;
			model.ProductId=ProductId;
			model.MitemId=MitemId;
			model.ReqQty=ReqQty;
			model.Version=Version;
			model.VersionDesc=VersionDesc;
			model.BatchNo=BatchNo;
			model.DateTimeCreated=DateTimeCreated;
			model.UserCreator=UserCreator;
			model.DateTimeModified=DateTimeModified;
			model.UserModified=UserModified;
			model.State=State;
			model.OrgId=OrgId;

			Bsam.Core.Model.Models.BLL.Sfc_Production_Bom bll=new Bsam.Core.Model.Models.BLL.Sfc_Production_Bom();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
