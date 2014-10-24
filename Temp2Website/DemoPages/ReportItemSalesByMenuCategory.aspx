<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReportItemSalesByMenuCategory.aspx.cs" Inherits="DemoPages_ReportItemSalesByMenuCategory" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1  class="BlueHeader">Item Sales by Menu Category</h1>

    <asp:ObjectDataSource ID="ODS_ItemSalesByMenuCategory" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="TotalItemSalesByMenuCategory_Report" TypeName="eRestaurantSystem.BLL.eRestaurantController"></asp:ObjectDataSource>
    <rsweb:ReportViewer ID="RV_ItemSalesByMenuCategory" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
        <LocalReport ReportPath="Reports\ItemSalesByMenuCategory.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ODS_ItemSalesByMenuCategory" Name="ItemSalesByMenuCategory" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
</asp:Content>

