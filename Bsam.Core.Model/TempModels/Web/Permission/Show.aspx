<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.Permission.Show" Title="显示页" %>
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
		Code
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsButton
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsButton" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsHide
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsHide" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Func
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFunc" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Pid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Mid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OrderSort
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrderSort" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Icon
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIcon" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Description
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDescription" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Enabled
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEnabled" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreateId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCreateId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreateBy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCreateBy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCreateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModifyId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModifyId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModifyBy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModifyBy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModifyTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModifyTime" runat="server"></asp:Label>
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




