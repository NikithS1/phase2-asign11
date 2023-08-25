<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="YourNamespace.Articles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Articles</h2>
    <asp:Repeater ID="articleRepeater" runat="server">
        <ItemTemplate>
            <div>
                <h3><%# Eval("Title") %></h3>
                <p><%# Eval("Content") %></p>
                <p>Publish Date: <%# Eval("PublishDate") %></p>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>





