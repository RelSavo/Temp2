<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReportCategoryMenuItems.aspx.cs" Inherits="DemoPages_ReportCategoryMenuItems" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <h1  class="BlueHeader">Menu Category Items</h1>
    
    <asp:ObjectDataSource ID="ODS_MenuCategoryItems" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="CategoryMenuItems_Report" TypeName="eRestaurantSystem.BLL.eRestaurantController"></asp:ObjectDataSource>
    <rsweb:ReportViewer ID="RV_MenuCategoryItems" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%" Height="800px">
        <LocalReport ReportPath="Reports\CategoryMenuItems.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ODS_MenuCategoryItems" Name="CategoryMenuItems" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
</asp:Content>

