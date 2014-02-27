<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PortalReportAdmin.aspx.cs" Inherits="ReportingPortal.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Search_area">
        <asp:Label ID="Label1" runat="server" Text="Report search"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox CssClass="textbox" ID="SearchReport" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button class="btn" ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Report" />
        <br />
        <br />


        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Style="margin-left: 0px" Width="178px" AllowPaging="True" Height="153px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    <div id="Add_area">
        <br/>
        <asp:Label ID="Lable1" runat="server" Text="Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox CssClass="textbox" ID="UploadName" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
        <br />
        <asp:Label ID="Lable2" runat="server" Text="Data Source"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox CssClass="textbox" ID="UploadDataSource" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Lable3" runat="server" Text="Business Owner"></asp:Label>
        &nbsp;<asp:TextBox CssClass="textbox" ID="UploadBussOwner" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Lable4" runat="server" Text="JIRA Ticket"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox CssClass="textbox" ID="UploadJIRATicket" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="File Search"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox CssClass="textbox" ID="UploadFileSearch" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button class="btn" ID="Browse" runat="server" Text="Browse" OnClick="Browse_Click" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox CssClass="textbox" ID="UploadDesc" runat="server" Width="250px" Height="80px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="HiddenParameters" runat="server" Text="Hidden Parameters" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button class="btn" ID="Upload" runat="server" Text="Upload" OnClick="Upload_Click" />
    </div>
</asp:Content>
