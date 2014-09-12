<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="XMLGridView.aspx.cs" Inherits="XMLGridView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:GridView ID="GV_XMLDemo" runat="server" DataSourceID="XMLDS_XMLDemo"></asp:GridView>
    <asp:XmlDataSource ID="XMLDS_XMLDemo" runat="server" DataFile="~/XMLFiles/XMLDemo.xml" TransformFile="~/XMLFiles/XSLTDemo.xslt"></asp:XmlDataSource>
</asp:Content>

