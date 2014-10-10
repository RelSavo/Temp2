<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RepeaterMenuCategories.aspx.cs" Inherits="DemoPages_RepeaterMenuCategories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Repeater Sample</h1>
    <h2>Our Menu Items</h2>

    <div class="row col-md-12">
        <asp:Repeater ID="rp_Categories" runat="server" DataSourceID="ods_MenuItemsByCategory">
            <ItemTemplate>
                <h3>
                    <image src='../Images/<%# Eval("Description") + "-1.png" %>' height="110"></image>
                    <%# Eval("Description") %>
                </h3>
                <div class="well">
                    <asp:Repeater ID="rp_MenuItems" runat="server"
                        DataSource='<%# Eval("MenuItem") %>'>
                        <ItemTemplate>
                            <h4 class="floatLeft"><%# Eval("Description") %></h4>
                            <span class="badge"><%# Eval("Calories") %></span>
                            <div class="clearfix"></div>
                            <h5><%# ((decimal)Eval("CurrentPrice")).ToString("C") %></h5>
                            <h5><%# Eval("Comment") %></h5>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        
    </div>    
    <asp:ObjectDataSource ID="ods_MenuItemsByCategory" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCategoryMenuItems" TypeName="eRestaurantSystem.BLL.eRestaurantController"></asp:ObjectDataSource>
</asp:Content>

