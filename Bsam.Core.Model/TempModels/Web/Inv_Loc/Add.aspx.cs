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
namespace Bsam.Core.Model.Models.Web.Inv_Loc
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtId.Text))
			{
				strErr+="Id格式错误！\\n";	
			}
			if(this.txtLocCode.Text.Trim().Length==0)
			{
				strErr+="LocCode不能为空！\\n";	
			}
			if(this.txtLocName.Text.Trim().Length==0)
			{
				strErr+="LocName不能为空！\\n";	
			}
			if(this.txtLocDesc.Text.Trim().Length==0)
			{
				strErr+="LocDesc不能为空！\\n";	
			}
			if(this.txtLocStatus.Text.Trim().Length==0)
			{
				strErr+="LocStatus不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtLocOrder.Text))
			{
				strErr+="LocOrder格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtVolume.Text))
			{
				strErr+="Volume格式错误！\\n";	
			}
			if(this.txtVolumeUnit.Text.Trim().Length==0)
			{
				strErr+="VolumeUnit不能为空！\\n";	
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
			if(!PageValidate.IsNumber(txtDistrictId.Text))
			{
				strErr+="DistrictId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInvId.Text))
			{
				strErr+="InvId格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.txtId.Text);
			string LocCode=this.txtLocCode.Text;
			string LocName=this.txtLocName.Text;
			string LocDesc=this.txtLocDesc.Text;
			string LocStatus=this.txtLocStatus.Text;
			int LocOrder=int.Parse(this.txtLocOrder.Text);
			int Volume=int.Parse(this.txtVolume.Text);
			string VolumeUnit=this.txtVolumeUnit.Text;
			DateTime DateTimeCreated=DateTime.Parse(this.txtDateTimeCreated.Text);
			string UserCreator=this.txtUserCreator.Text;
			DateTime DateTimeModified=DateTime.Parse(this.txtDateTimeModified.Text);
			string UserModified=this.txtUserModified.Text;
			bool State=this.chkState.Checked;
			string OrgId=this.txtOrgId.Text;
			int DistrictId=int.Parse(this.txtDistrictId.Text);
			int InvId=int.Parse(this.txtInvId.Text);

			Bsam.Core.Model.Models.Model.Inv_Loc model=new Bsam.Core.Model.Models.Model.Inv_Loc();
			model.Id=Id;
			model.LocCode=LocCode;
			model.LocName=LocName;
			model.LocDesc=LocDesc;
			model.LocStatus=LocStatus;
			model.LocOrder=LocOrder;
			model.Volume=Volume;
			model.VolumeUnit=VolumeUnit;
			model.DateTimeCreated=DateTimeCreated;
			model.UserCreator=UserCreator;
			model.DateTimeModified=DateTimeModified;
			model.UserModified=UserModified;
			model.State=State;
			model.OrgId=OrgId;
			model.DistrictId=DistrictId;
			model.InvId=InvId;

			Bsam.Core.Model.Models.BLL.Inv_Loc bll=new Bsam.Core.Model.Models.BLL.Inv_Loc();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
