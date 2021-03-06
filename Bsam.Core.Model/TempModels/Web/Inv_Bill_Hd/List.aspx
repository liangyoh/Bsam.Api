﻿<%@ Page Title="Inv_Bill_Hd" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Bsam.Core.Model.Models.Web.Inv_Bill_Hd.List" %>
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
                    BorderWidth="1px" DataKeyNames="" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BillType" HeaderText="BillType" SortExpression="BillType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PlanQty" HeaderText="PlanQty" SortExpression="PlanQty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ActualQty" HeaderText="ActualQty" SortExpression="ActualQty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SrcBillId" HeaderText="SrcBillId" SortExpression="SrcBillId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SrcBillNo" HeaderText="SrcBillNo" SortExpression="SrcBillNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvId" HeaderText="InvId" SortExpression="InvId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvCode" HeaderText="InvCode" SortExpression="InvCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvName" HeaderText="InvName" SortExpression="InvName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvAddress" HeaderText="InvAddress" SortExpression="InvAddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RcvUser" HeaderText="RcvUser" SortExpression="RcvUser" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RcvDateTime" HeaderText="RcvDateTime" SortExpression="RcvDateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RcvReason" HeaderText="RcvReason" SortExpression="RcvReason" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RcvAddress" HeaderText="RcvAddress" SortExpression="RcvAddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BillStatus" HeaderText="BillStatus" SortExpression="BillStatus" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DateTimeCreated" HeaderText="DateTimeCreated" SortExpression="DateTimeCreated" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserCreator" HeaderText="UserCreator" SortExpression="UserCreator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DateTimeModified" HeaderText="DateTimeModified" SortExpression="DateTimeModified" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserModified" HeaderText="UserModified" SortExpression="UserModified" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="State" HeaderText="State" SortExpression="State" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OrgId" HeaderText="OrgId" SortExpression="OrgId" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="" DataNavigateUrlFormatString="Show.aspx?"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="" DataNavigateUrlFormatString="Modify.aspx?"
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
