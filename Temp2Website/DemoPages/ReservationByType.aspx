<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReservationByType.aspx.cs" Inherits="DemoPages_ReservationByType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!--Drop Down-->
    <asp:DropDownList ID="ddl_SpecialEvents" runat="server" DataSourceID="ODS_SpecialEvents" DataTextField="Description" DataValueField="EventCode"></asp:DropDownList>
    <asp:ObjectDataSource ID="ODS_SpecialEvents" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SpecialEvent_List" TypeName="eRestaurantSystem.BLL.eRestaurantController"></asp:ObjectDataSource>
    
    <!--Grid View-->
    <asp:GridView ID="gv_Reservations" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ODS_Reservations" ForeColor="#333333" GridLines="None" PageSize="15">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="ReservationID" HeaderText="ID" SortExpression="ReservationID">
            <HeaderStyle Width="30px" />
            </asp:BoundField>
            <asp:BoundField DataField="CustomerName" HeaderText="Customer" SortExpression="CustomerName">
            <HeaderStyle Width="175px" />
            </asp:BoundField>
            <asp:BoundField DataField="ReservationDate" DataFormatString="{0:MMM, dd yyyy}" HeaderText="Date" SortExpression="ReservationDate">
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="NumberInParty" HeaderText="Party Size" SortExpression="NumberInParty" >
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="ContactPhone" HeaderText="Phone Number" SortExpression="ContactPhone" />
            <asp:BoundField DataField="ReservationStatus" HeaderText="Status" SortExpression="ReservationStatus" />
            <asp:BoundField DataField="EventCode" HeaderText="Event Code" SortExpression="EventCode" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerSettings Mode="NextPreviousFirstLast" NextPageText="Next" PreviousPageText="Previous " />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ODS_Reservations" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Reservation_List" TypeName="eRestaurantSystem.BLL.eRestaurantController"></asp:ObjectDataSource>
</asp:Content>

