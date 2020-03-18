<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.Inv_Rcv_Bill_Hd.Add" Title="增加页" %>

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
		<asp:TextBox id="txtId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRcvType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvUserId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRcvUserId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvUserName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRcvUserName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRcvPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvDateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRcvDateTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvReason
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRcvReason" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RcvAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRcvAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RentSubject
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRentSubject" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RentUserId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRentUserId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RentUserName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRentUserName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RentPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRentPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RrcBillId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRrcBillId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PlanRtnDateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPlanRtnDateTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActualRtnDateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtActualRtnDateTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BillStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBillStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DateTimeCreated
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDateTimeCreated" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserCreator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUserCreator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DateTimeModified
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDateTimeModified" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserModified
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUserModified" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		State
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkState" Text="State" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OrgId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOrgId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
