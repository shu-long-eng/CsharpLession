<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page.aspx.cs" Inherits="_20210321_網頁練習.page" %>

<%@ Register Src="~/uc.ascx" TagPrefix="uc1" TagName="uc" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:uc runat="server" id="uc" ucName="1"/><br />
            <uc1:uc runat="server" id="uc1" ucName="2"/>
        </div>
    </form>
</body>
</html>
