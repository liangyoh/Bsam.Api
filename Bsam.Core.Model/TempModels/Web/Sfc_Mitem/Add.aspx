﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.Sfc_Mitem.Add" Title="增加页" %>

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
		MitemCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMitemCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MitemName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMitemName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MitemDesc
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMitemDesc" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MitemType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMitemType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Brand
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBrand" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Buyer
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBuyer" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DutyPerson
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDutyPerson" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SupplierId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSupplierId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DefaultInvId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDefaultInvId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Uom
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUom" runat="server" Width="200px"></asp:TextBox>
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
