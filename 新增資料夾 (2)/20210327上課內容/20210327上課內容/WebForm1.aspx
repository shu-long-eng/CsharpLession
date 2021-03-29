<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_20210327上課內容.WebForm1" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1">
            <asp:Repeater ID="repList" runat="server">
                <ItemTemplate>
                    <tr>
                        <td>Val1</td>
                        <td>Val2</td>
                        <td>Val3</td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <uc1:WebUserControl1 runat="server" ID="ucPager" PagingSize="12"/>
    </form>
</body>
</html>
