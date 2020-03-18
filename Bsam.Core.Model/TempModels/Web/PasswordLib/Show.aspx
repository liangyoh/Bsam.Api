<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.PasswordLib.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		PLID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPLID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsDeleted
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsDeleted" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plURL
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plPWD
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplPWD" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plAccountName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplAccountName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plErrorCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplErrorCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plHintPwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplHintPwd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plHintquestion
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplHintquestion" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plCreateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplCreateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plUpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplUpdateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plLastErrTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplLastErrTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		test
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltest" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




