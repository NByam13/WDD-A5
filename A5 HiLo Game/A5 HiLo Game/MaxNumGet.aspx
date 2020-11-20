<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaxNumGet.aspx.cs" Inherits="A5_HiLo_Game.MaxNumGet" %>
 <!--Name: Nikola Ristic & Nick--> 
 <!--Program Name: A5-Hilo Game--> 
 <!--File Name: MaxNumGet.aspx--> 
 <!--Purpose: The purpose of this program is to ask the user for their name --> 
 <!--which the user enters, and if its valid, proceeds to the next page of  -->
 <!--the program                             								-->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Tell the program the title of the page -->
<head runat="server">
    <title>HiLo Game</title>
    <link href="./Styles/A5styles.css" type="text/css" rel="stylesheet"/>
</head>
<body>
    <div class="form-container">
        <h1>The Hi-Lo Game</h1>
        <!-- Create a form that will be run at the server -->
        <form id="form2" runat="server">
            <!-- Used to display greeting to user and tell them to input a max number -->
            <p id="greeting" runat="server"></p>
            <!--  Create a textbox that will be run at the server and allow user input-->
            <asp:TextBox ID="maxNum" runat="server"></asp:TextBox>
            <!--  Create a textbox that will be run at the server and allow the user to press, which will make the program validate the textbox-->
            <asp:Button ID="Enter1" runat="server" Text="Enter max number!" OnClick="Enter1_Click" Width="130px" style="height: 25px" />
            <div class="error">
                <!-- CompareValidator is used to determine if the input in the textbox(number in this case) is greater then or equal to 2, and if its not, tell the user its not valid-->
                <asp:CompareValidator ID="ValMax" 
                runat="server"  Operator="GreaterThanEqual" ControlToValidate ="maxNum"
                Type="Integer" SetFocusOnError="true" 
                ValueToCompare="2" ErrorMessage="Please enter a valid integer"
                ForeColor="Red"/>
                <!-- RequiredFieldValidator is used to determine if the input in the textbox(number in this case) is valid, and if its not, tell the user its not valid-->
                <asp:RequiredFieldValidator ID="notEmptyMax"
                runat="server"
                ControlToValidate="maxNum"
                ErrorMessage="Please Enter a Number Greater Than 1!" 
                ForeColor="Red" />
            </div>
        </form>
    </div>
</body>
</html>
