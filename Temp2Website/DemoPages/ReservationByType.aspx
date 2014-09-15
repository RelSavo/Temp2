<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReservationByType.aspx.cs" Inherits="DemoPages_ReservationByType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:DropDownList ID="ddl_SpecialEvents" runat="server" DataSourceID="ODS_SpecialEvents" DataTextField="Description" DataValueField="EventCode"></asp:DropDownList>
    <asp:ObjectDataSource ID="ODS_SpecialEvents" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SpecialEvent_List" TypeName="eRestaurantSystem.BLL.eRestaurantController"></asp:ObjectDataSource>
</asp:Content>

