<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_20210327_課堂作業.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
            <ItemTemplate>
                <p>
                    ID:<%# Eval("ID") %>
                    Name:<%# Eval("Name") %>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </p>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
