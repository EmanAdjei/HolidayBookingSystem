<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StaffBooking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 class="text-left">|| Straight Walls Ltd ||</h1>
        <p class="text-left">&nbsp;</p>
        <h1 class="text-left">Login</h1>
        <p class="text-left">&nbsp;</p>
        <p class="text-left">
            <asp:Label ID="Label1" runat="server" Text="Staff ID"></asp:Label>
            &nbsp;:</p>
        <p class="lead">
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        </p>
        <p class="lead" style="text-align: left">
            Password :</p>
        <p class="lead">
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </p>
        <p class="lead" style="text-align: left">
            &nbsp;</p>
        <p class="lead">
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Log In" Height="40px" Width="99px" />
        </p>
    </div>

</asp:Content>
