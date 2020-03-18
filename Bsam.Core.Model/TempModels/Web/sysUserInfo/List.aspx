<%@ Page Title="sysUserInfo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.sysUserInfo.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="uID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="uLoginName" HeaderText="uLoginName" SortExpression="uLoginName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uLoginPWD" HeaderText="uLoginPWD" SortExpression="uLoginPWD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uRealName" HeaderText="uRealName" SortExpression="uRealName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uStatus" HeaderText="uStatus" SortExpression="uStatus" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uRemark" HeaderText="uRemark" SortExpression="uRemark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uCreateTime" HeaderText="uCreateTime" SortExpression="uCreateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uUpdateTime" HeaderText="uUpdateTime" SortExpression="uUpdateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uLastErrTime" HeaderText="uLastErrTime" SortExpression="uLastErrTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uErrorCount" HeaderText="uErrorCount" SortExpression="uErrorCount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="name" HeaderText="name" SortExpression="name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sex" HeaderText="sex" SortExpression="sex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="age" HeaderText="age" SortExpression="age" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="birth" HeaderText="birth" SortExpression="birth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="addr" HeaderText="addr" SortExpression="addr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdIsDelete" HeaderText="tdIsDelete" SortExpression="tdIsDelete" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="uID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="uID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
