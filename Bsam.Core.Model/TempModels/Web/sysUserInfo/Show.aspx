<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.sysUserInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		uID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uLoginName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluLoginName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uLoginPWD
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluLoginPWD" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uRealName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluRealName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uRemark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uCreateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluCreateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uUpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluUpdateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uLastErrTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluLastErrTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uErrorCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluErrorCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sex
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		age
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		birth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbirth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladdr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdIsDelete
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdIsDelete" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




