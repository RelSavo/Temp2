<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClockPicker.aspx.cs" Inherits="DemoPages_ClockPicker" %>

<%@ Register src="../UserControls/MessageUserControl.ascx" tagname="MessageUserControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="well">
        <div class="pull-right col-mid-5">
            <h4>
                <small>Last Bill Date/Time</small>
                <!--"ItemType="System.DateTime" will add the "Item.ToShortDataString()"-->
                <asp:Repeater ID="RP_BillDateRepeater" runat="server" 
                    DataSourceID="ODS_BillDateRepeater" 
                    ItemType="System.DateTime"> 
                    <ItemTemplate>
                        <b class="label label-primary"><%# Item.ToShortDateString() %></b>
                        <b class="label label-info"><%#Item.ToShortTimeString() %></b>
                    </ItemTemplate>
                </asp:Repeater>

                <asp:ObjectDataSource ID="ODS_BillDateRepeater" runat="server" 
                    OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetLastBillDate" 
                    TypeName="eRestaurantSystem.BLL.eRestaurantController">
                </asp:ObjectDataSource>

            </h4>
        </div>
        <h4>Mock Date/Time</h4>
        <asp:LinkButton ID="LKB_MockTime" Cssclass="btn btn-primary" runat="server">Post-Back new Date/Time</asp:LinkButton>
        <asp:LinkButton ID="LKB_MockLastBillingDateTime" CssClass="btn btn-default" runat="server" OnClick="LKB_MockLastBillingDateTime_Click">Set to last-bill Date/Time</asp:LinkButton>
        &nbsp;
        &nbsp;

        <asp:TextBox ID="TB_SearchDate" runat="server" 
            TextMode="Date" 
            Text="2014-10-27">
        </asp:TextBox>
        <asp:TextBox ID="TB_SearchTime" runat="server" 
            TextMode="Time" 
            Text="13:00"
            CssClass="clockpicker">
        </asp:TextBox>


        <% //Add Clock Picker %>
        <script src="../Scripts/clockpicker.js"></script>
        <script type="text/javascript">
            $('.clockpicker').clockpicker({ donetext: 'Accept' });
        </script>
        <link itemprop="url" href="../Content/standalone.css" rel="stylesheet"/>
        <link itemprop="url" href="../Content/clockpicker.css" rel="stylesheet" />


        &nbsp;
        &nbsp;
        <uc1:MessageUserControl ID="MessageUserControl" runat="server" />
    </div>    
</asp:Content>

