<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.Inv_District.Show" Title="显示页" %>
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
		DistrictCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDistrictCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DistrictName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDistrictName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DistrictDesc
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDistrictDesc" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DistrictStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDistrictStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Volume
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVolume" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		VolumeUnit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVolumeUnit" runat="server"></asp:Label>
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
	<tr>
	<td height="25" width="30%" align="right">
		OrgId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrgId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvId" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




