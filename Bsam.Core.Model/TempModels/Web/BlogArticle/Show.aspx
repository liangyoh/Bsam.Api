<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.BlogArticle.Show" Title="显示页" %>
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
		<asp:Label id="lblbID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bsubmitter
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbsubmitter" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		btitle
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbtitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bcategory
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbcategory" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bcontent
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbcontent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		btraffic
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbtraffic" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bcommentNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbcommentNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bUpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbUpdateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bCreateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbCreateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bRemark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsDeleted
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsDeleted" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




