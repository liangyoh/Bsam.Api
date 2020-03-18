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
namespace Bsam.Core.Model.Models.Web.TopicDetail
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtTopicId.Text))
			{
				strErr+="TopicId格式错误！\\n";	
			}
			if(this.txttdLogo.Text.Trim().Length==0)
			{
				strErr+="tdLogo不能为空！\\n";	
			}
			if(this.txttdName.Text.Trim().Length==0)
			{
				strErr+="tdName不能为空！\\n";	
			}
			if(this.txttdContent.Text.Trim().Length==0)
			{
				strErr+="tdContent不能为空！\\n";	
			}
			if(this.txttdDetail.Text.Trim().Length==0)
			{
				strErr+="tdDetail不能为空！\\n";	
			}
			if(this.txttdSectendDetail.Text.Trim().Length==0)
			{
				strErr+="tdSectendDetail不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txttdRead.Text))
			{
				strErr+="tdRead格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttdCommend.Text))
			{
				strErr+="tdCommend格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttdGood.Text))
			{
				strErr+="tdGood格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txttdCreatetime.Text))
			{
				strErr+="tdCreatetime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txttdUpdatetime.Text))
			{
				strErr+="tdUpdatetime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttdTop.Text))
			{
				strErr+="tdTop格式错误！\\n";	
			}
			if(this.txttdAuthor.Text.Trim().Length==0)
			{
				strErr+="tdAuthor不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int TopicId=int.Parse(this.txtTopicId.Text);
			string tdLogo=this.txttdLogo.Text;
			string tdName=this.txttdName.Text;
			string tdContent=this.txttdContent.Text;
			string tdDetail=this.txttdDetail.Text;
			string tdSectendDetail=this.txttdSectendDetail.Text;
			bool tdIsDelete=this.chktdIsDelete.Checked;
			int tdRead=int.Parse(this.txttdRead.Text);
			int tdCommend=int.Parse(this.txttdCommend.Text);
			int tdGood=int.Parse(this.txttdGood.Text);
			DateTime tdCreatetime=DateTime.Parse(this.txttdCreatetime.Text);
			DateTime tdUpdatetime=DateTime.Parse(this.txttdUpdatetime.Text);
			int tdTop=int.Parse(this.txttdTop.Text);
			string tdAuthor=this.txttdAuthor.Text;

			Bsam.Core.Model.Models.Model.TopicDetail model=new Bsam.Core.Model.Models.Model.TopicDetail();
			model.TopicId=TopicId;
			model.tdLogo=tdLogo;
			model.tdName=tdName;
			model.tdContent=tdContent;
			model.tdDetail=tdDetail;
			model.tdSectendDetail=tdSectendDetail;
			model.tdIsDelete=tdIsDelete;
			model.tdRead=tdRead;
			model.tdCommend=tdCommend;
			model.tdGood=tdGood;
			model.tdCreatetime=tdCreatetime;
			model.tdUpdatetime=tdUpdatetime;
			model.tdTop=tdTop;
			model.tdAuthor=tdAuthor;

			Bsam.Core.Model.Models.BLL.TopicDetail bll=new Bsam.Core.Model.Models.BLL.TopicDetail();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
