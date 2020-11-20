<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiloGame.aspx.cs" Inherits="A5_HiLo_Game.HiloGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Tell the program the title of the page -->
<head runat="server">
    <title>HiLo Game</title>
</head>
<body>
    <div class="form-container">
        <!-- Create a for that will be run at the server -->
        <h1>The Hi-Lo Game</h1>
        <form id="form3" runat="server" >
            <p id="Gamegreeting" runat="server"></p>
            <asp:TextBox ID="ChoiceBox" runat="server" OnTextChanged="ChoiceBox_TextChanged" OnInit="ChoiceBox_TextChanged"></asp:TextBox>
            <asp:Button ID="choiceCheck" runat="server" Text="Make a Guess!" Width="130px" style="height: 25px" OnClick="choiceCheck_Click" />
            <div class="error">
                <asp:RangeValidator 
                    id="rangeCheck1"
                    ControlToValidate="ChoiceBox" 
                    Type="Integer"
                    Text="Sorry, the value entered must be an integer in the range."
                    ForeColor="red"
                    runat="server" />
                <asp:RequiredFieldValidator ID="notEmptyMax"
                    runat="server"
                    ControlToValidate="ChoiceBox"
                    ErrorMessage="Please Enter a Valid Number!" 
                    ForeColor="Red"/>
            </div>
    </form>
    </div>
</body>
</html>
