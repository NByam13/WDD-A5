<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="winPage.aspx.cs" Inherits="A5_HiLo_Game.winPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HiLo Game</title>
</head>
<body id="win">
    <div id="form-container">
        <h1>The Hi-Lo Game</h1>
        <form id="form1" runat="server">
            <p id="winGreeting" runat="server"></p>
            <asp:Button ID="replay" runat="server" Text="Play Again?" OnClick="replay_Click" />
        </form>
    </div>
</body>
</html>
