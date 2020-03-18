<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.Topic.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tLogo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltLogo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tDetail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltDetail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tAuthor
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltAuthor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tSectendDetail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltSectendDetail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tIsDelete
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltIsDelete" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tRead
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltRead" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tCommend
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltCommend" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tGood
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltGood" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tCreatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltCreatetime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tUpdatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltUpdatetime" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




