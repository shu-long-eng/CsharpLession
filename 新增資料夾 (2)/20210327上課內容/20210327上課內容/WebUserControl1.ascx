﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="_20210327上課內容.WebUserControl1" %>

<div>
    <a runat="server" id="aLinkFirst" href="#">First</a>

    <a runat="server" id="aPage1" href="#">1</a>
    <a runat="server" id="aPage2" href="#">2</a>
    <a runat="server" id="aPage3" href="#">3</a>

    <a runat="server" id="aLinkLast" href="#">Last</a>
</div>
<div>
    <asp:Literal ID="ltCurrentPage" runat="server" ></asp:Literal>
    <asp:Literal ID="ltTotalPage" runat="server"  ></asp:Literal>
</div>