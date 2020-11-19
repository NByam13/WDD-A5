<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NameArea.aspx.cs" Inherits="A5_HiLo_Game.NameArea" %>
 <!--Name: Nikola Ristic & Nick--> 
 <!--Program Name: A5-Hilo Game--> 
 <!--File Name: NameArea.aspx--> 
 <!--Purpose: The purpose of this program is to ask the user for their name --> 
 <!--which the user enters, and if its valid, proceeds to the next page of  -->
 <!--the program                             								-->

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Tell the program the title of the page -->
<head runat="server">
    <title>HiLo Game</title>
</head>
<body>
    <!-- Create a form that will be run at the server -->
    <form id="form1" runat="server">
        <!-- Ask the user for input -->
        <p>Hi There! Please enter a name!</p>
        <div>
              <!--  Create a textbox that will be run at the server and allow user input-->
              <asp:TextBox ID="Username" runat="server" OnTextChanged="Username_TextChanged" Type="string">
              </asp:TextBox>
              <!--  Create a textbox that will be run at the server and allow the user to press, which will make the program validate the textbox-->
              <asp:Button ID="Enter1" runat="server" Text="Enter username" OnClick="Enter1_Click" Width="105px" />
              <!-- RequiredFieldValidator is used to determine if the input in the textbox(username in this case) is valid, and if its not, tell the user-->
              <asp:RequiredFieldValidator ID="ValUsername" 
              runat="server" ControlToValidate ="Username"
              ErrorMessage="Please enter a valid Name!" >
              </asp:RequiredFieldValidator>
        </div>
    </form>
</body>
</html>
