﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="winPage.aspx.cs" Inherits="A5_HiLo_Game.winPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p id="winGreeting" runat="server"></p>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Play Again?" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
