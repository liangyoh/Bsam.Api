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
namespace Bsam.Core.Model.Models.Web.Topic
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
		Bsam.Core.Model.Models.BLL.Topic bll=new Bsam.Core.Model.Models.BLL.Topic();
		Bsam.Core.Model.Models.Model.Topic model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txttLogo.Text=model.tLogo;
		this.txttName.Text=model.tName;
		this.txttDetail.Text=model.tDetail;
		this.txttAuthor.Text=model.tAuthor;
		this.txttSectendDetail.Text=model.tSectendDetail;
		this.chktIsDelete.Checked=model.tIsDelete;
		this.txttRead.Text=model.tRead.ToString();
		this.txttCommend.Text=model.tCommend.ToString();
		this.txttGood.Text=model.tGood.ToString();
		this.txttCreatetime.Text=model.tCreatetime.ToString();
		this.txttUpdatetime.Text=model.tUpdatetime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txttLogo.Text.Trim().Length==0)
			{
				strErr+="tLogo不能为空！\\n";	
			}
			if(this.txttName.Text.Trim().Length==0)
			{
				strErr+="tName不能为空！\\n";	
			}
			if(this.txttDetail.Text.Trim().Length==0)
			{
				strErr+="tDetail不能为空！\\n";	
			}
			if(this.txttAuthor.Text.Trim().Length==0)
			{
				strErr+="tAuthor不能为空！\\n";	
			}
			if(this.txttSectendDetail.Text.Trim().Length==0)
			{
				strErr+="tSectendDetail不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txttRead.Text))
			{
				strErr+="tRead格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttCommend.Text))
			{
				strErr+="tCommend格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttGood.Text))
			{
				strErr+="tGood格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txttCreatetime.Text))
			{
				strErr+="tCreatetime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txttUpdatetime.Text))
			{
				strErr+="tUpdatetime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string tLogo=this.txttLogo.Text;
			string tName=this.txttName.Text;
			string tDetail=this.txttDetail.Text;
			string tAuthor=this.txttAuthor.Text;
			string tSectendDetail=this.txttSectendDetail.Text;
			bool tIsDelete=this.chktIsDelete.Checked;
			int tRead=int.Parse(this.txttRead.Text);
			int tCommend=int.Parse(this.txttCommend.Text);
			int tGood=int.Parse(this.txttGood.Text);
			DateTime tCreatetime=DateTime.Parse(this.txttCreatetime.Text);
			DateTime tUpdatetime=DateTime.Parse(this.txttUpdatetime.Text);


			Bsam.Core.Model.Models.Model.Topic model=new Bsam.Core.Model.Models.Model.Topic();
			model.Id=Id;
			model.tLogo=tLogo;
			model.tName=tName;
			model.tDetail=tDetail;
			model.tAuthor=tAuthor;
			model.tSectendDetail=tSectendDetail;
			model.tIsDelete=tIsDelete;
			model.tRead=tRead;
			model.tCommend=tCommend;
			model.tGood=tGood;
			model.tCreatetime=tCreatetime;
			model.tUpdatetime=tUpdatetime;

			Bsam.Core.Model.Models.BLL.Topic bll=new Bsam.Core.Model.Models.BLL.Topic();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
