<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="實作登入.aspx.cs" Inherits="_20210328上課內容.實作登入" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:PlaceHolder ID="plc1" runat="server">
        Name:<asp:TextBox ID="txtAccount" runat="server"></asp:TextBox><br />
        Password:<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </asp:PlaceHolder>
        <asp:PlaceHolder ID="plc2" runat="server" Visible="false">
            <asp:Literal ID="Literal2" runat="server"></asp:Literal>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
        </asp:PlaceHolder>
    </form>
</body>
</html>
