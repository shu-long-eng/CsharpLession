<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_20210320_課堂內容.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <th>欄位</th>
                    <th>欄位</th>
                </tr>
                <asp:Literal runat="server" ID="table">

                </asp:Literal>



                <%--<tr>
                    <td>第一列</td>
                    <td>第一列</td>
                </tr>
                <tr>
                    <td>第二列</td>
                    <td>第二列</td>
                </tr>--%>
            </table>
        </div>
    </form>
</body>
</html>
