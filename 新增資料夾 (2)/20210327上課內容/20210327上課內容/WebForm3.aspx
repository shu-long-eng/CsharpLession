<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="_20210327上課內容.WebForm3" %>

<%@ Register Src="~/WebUserControl2.ascx" TagPrefix="uc1" TagName="WebUserControl2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:WebUserControl2 runat="server" ID="WebUserControl2" />
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click"/>
</asp:Content>
