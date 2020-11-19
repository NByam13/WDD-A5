<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiloGame.aspx.cs" Inherits="A5_HiLo_Game.HiloGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<%-- Tell the program the title of the page --%>
<head runat="server">
    <title>HiLo Game</title>
</head>
<body>
    <%-- Create a for that will be run at the server --%>
    <form id="form1" runat="server">
      <p id="Gamegreeting" runat="server"></p>
        <div>
            <asp:TextBox ID="ChoiceBox" runat="server" OnTextChanged="ChoiceBox_TextChanged"></asp:TextBox>
            <asp:Button ID="choiceCheck" runat="server" Text="Make a Guess!" Width="159px" OnClick="choiceCheck_Click" />

        </div>
        <div>
            <asp:RequiredFieldValidator ID="notEmptyMax"
                runat="server"
                ControlToValidate="ChoiceBox"
                ErrorMessage="Please Enter a Valid Number!" 
                ForeColor="Red"/>
        </div>
    </form>
</body>
</html>
