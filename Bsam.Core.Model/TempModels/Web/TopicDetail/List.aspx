<%@ Page Title="TopicDetail" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.TopicDetail.List" %>
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
                    BorderWidth="1px" DataKeyNames="Id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="TopicId" HeaderText="TopicId" SortExpression="TopicId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdLogo" HeaderText="tdLogo" SortExpression="tdLogo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdName" HeaderText="tdName" SortExpression="tdName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdContent" HeaderText="tdContent" SortExpression="tdContent" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdDetail" HeaderText="tdDetail" SortExpression="tdDetail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdSectendDetail" HeaderText="tdSectendDetail" SortExpression="tdSectendDetail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdIsDelete" HeaderText="tdIsDelete" SortExpression="tdIsDelete" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdRead" HeaderText="tdRead" SortExpression="tdRead" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdCommend" HeaderText="tdCommend" SortExpression="tdCommend" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdGood" HeaderText="tdGood" SortExpression="tdGood" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdCreatetime" HeaderText="tdCreatetime" SortExpression="tdCreatetime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdUpdatetime" HeaderText="tdUpdatetime" SortExpression="tdUpdatetime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdTop" HeaderText="tdTop" SortExpression="tdTop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tdAuthor" HeaderText="tdAuthor" SortExpression="tdAuthor" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
