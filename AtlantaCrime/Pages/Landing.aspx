<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Landing.aspx.cs" Inherits="AtlantaCrime.Pages.Landing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container">
        <br />
        <br />
        <h1>Atlanta Crime Statistics</h1>
            <p>Altanta crime statistics gives a detailed analysis into the crime rates in and around the Atlanta area.</p>
        <br />
            <div class="col-lg">
                <img runat="server" src="~/Images/crimescenetape.jpg " alt="Alternate Text" class="center-block" />
            </div>
            
        <br />
        <br />
            <h3>Recent Crimes</h3>
        <br />
            <asp:Literal ID="litTable" runat="server" />

    </div>
</asp:Content>
