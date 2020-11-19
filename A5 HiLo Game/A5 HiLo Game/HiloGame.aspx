<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiloGame.aspx.cs" Inherits="A5_HiLo_Game.HiloGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p id="Gamegreeting" runat="server"></p>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="ChoiceBox" runat="server"></asp:TextBox>
            <asp:Button ID="choiceCheck" runat="server" Text="Make a Guess!" Width="159px" />
        </div>
    </form>
</body>
</html>
