<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.Sys_Module.Show" Title="显示页" %>
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
		ModuleType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModuleType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModuleCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModuleCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModuleName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModuleName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModuleDesc
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModuleDesc" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModuleConfig
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModuleConfig" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Path
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPath" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DateTimeCreated
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDateTimeCreated" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserCreator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserCreator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DateTimeModified
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDateTimeModified" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserModified
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserModified" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		State
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblState" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




