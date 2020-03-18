<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.TopicDetail.Modify" Title="修改页" %>
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
		<asp:label id="lblId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TopicId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTopicId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdLogo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttdLogo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttdName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdContent
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttdContent" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdDetail
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttdDetail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdSectendDetail
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttdSectendDetail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdIsDelete
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chktdIsDelete" Text="tdIsDelete" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdRead
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttdRead" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdCommend
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttdCommend" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdGood
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttdGood" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdCreatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txttdCreatetime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdUpdatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txttdUpdatetime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdTop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttdTop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tdAuthor
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttdAuthor" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

