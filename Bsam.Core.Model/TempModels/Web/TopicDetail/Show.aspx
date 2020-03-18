<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.TopicDetail.Show" Title="显示页" %>
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
		TopicId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTopicId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdLogo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdLogo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdContent
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdContent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdDetail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdDetail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdSectendDetail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdSectendDetail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdIsDelete
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdIsDelete" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdRead
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdRead" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdCommend
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdCommend" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdGood
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdGood" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdCreatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdCreatetime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdUpdatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdUpdatetime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdTop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdTop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdAuthor
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltdAuthor" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




