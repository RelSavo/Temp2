<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReservationByType.aspx.cs" Inherits="DemoPages_ReservationByType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!--Drop Down-->
    <asp:DropDownList ID="ddl_SpecialEvents" runat="server" DataSourceID="ODS_SpecialEvents" DataTextField="Description" DataValueField="EventCode" AppendDataBoundItems="True">
        <asp:ListItem Value="">Select Event</asp:ListItem>
    </asp:DropDownList>
    <asp:LinkButton ID="lkb_Select" runat="server">Select</asp:LinkButton>
    <asp:ObjectDataSource ID="ODS_SpecialEvents" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SpecialEvent_List" TypeName="eRestaurantSystem.BLL.eRestaurantController"></asp:ObjectDataSource>
    
    <asp:ObjectDataSource ID="ODS_Reservations" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Reservation_List" TypeName="eRestaurantSystem.BLL.eRestaurantController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ODS_ReservationsByEvent" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ReservationByEvent" TypeName="eRestaurantSystem.BLL.eRestaurantController">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddl_SpecialEvents" Name="eventCode" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
    <!--Grid View-->
    <asp:GridView ID="gv_Reservations" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ODS_ReservationsByEvent" ForeColor="#333333" GridLines="None" PageSize="15">
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
            <asp:TemplateField HeaderText="Party Size" SortExpression="NumberInParty">
                <ItemTemplate>
                    <asp:TextBox ID="tb_PartySize" runat="server" Text='<%# Bind("NumberInParty") %>' 
                        Columns="3">
                    </asp:TextBox>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Phone Number" SortExpression="ContactPhone">
                <ItemTemplate>
                    <asp:TextBox ID="tb_PhoneNumber" runat="server" Text='<%# Eval("ContactPhone") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ContactPhone" HeaderText="Phone Number" SortExpression="ContactPhone" />


            <asp:BoundField DataField="ReservationStatus" HeaderText="Status" SortExpression="ReservationStatus" />
            <asp:BoundField DataField="EventCode" HeaderText="Event Code" SortExpression="EventCode" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <EmptyDataTemplate>
            No data to display.
        </EmptyDataTemplate>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerSettings NextPageText="Next" PreviousPageText="Previous " />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_SpecialEvents">
        <Columns>
            <asp:BoundField DataField="EventCode" HeaderText="EventCode" SortExpression="EventCode" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:TemplateField HeaderText="Active" SortExpression="Active">
                <ItemTemplate>
                    <asp:CheckBox ID="cb_Active" runat="server" Checked='<%# Eval("Active") %>' Enabled="true" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

