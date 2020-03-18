<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.Inv_Rcv_Bill_Hd.Show" Title="显示页" %>
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
		RcvType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRcvType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvUserId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRcvUserId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvUserName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRcvUserName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRcvPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvDateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRcvDateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvReason
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRcvReason" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRcvAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RentSubject
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRentSubject" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RentUserId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRentUserId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RentUserName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRentUserName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RentPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRentPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RrcBillId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRrcBillId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PlanRtnDateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPlanRtnDateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActualRtnDateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActualRtnDateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BillStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBillStatus" runat="server"></asp:Label>
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
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




