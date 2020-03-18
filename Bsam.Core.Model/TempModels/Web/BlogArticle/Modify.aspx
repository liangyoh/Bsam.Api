<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.BlogArticle.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		bID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblbID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bsubmitter
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbsubmitter" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		btitle
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbtitle" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bcategory
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbcategory" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bcontent
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbcontent" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		btraffic
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbtraffic" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bcommentNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbcommentNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bUpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtbUpdateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bCreateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtbCreateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bRemark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsDeleted
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsDeleted" Text="IsDeleted" runat="server" Checked="False" />
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

