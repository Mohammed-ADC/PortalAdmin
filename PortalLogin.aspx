<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PortalLogin.aspx.cs" Inherits="ReportingPortal.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <div id="Middle_area">


        <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>

        <br />

        <asp:TextBox CssClass="textbox" ID="LName" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <br />

        <asp:TextBox CssClass="textbox" ID="LPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button Class="btn" ID="Button2" runat="server" Text="Login"  OnClick="Button2_Click" />

        <br />


    </div>


</asp:Content>
