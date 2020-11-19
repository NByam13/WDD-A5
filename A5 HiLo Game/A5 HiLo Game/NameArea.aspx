<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NameArea.aspx.cs" Inherits="A5_HiLo_Game.NameArea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HiLo Game</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>Hi There! Please enter a name!</p>
        <div>
              <asp:TextBox ID="Username" runat="server" OnTextChanged="Username_TextChanged" Type="string">
              </asp:TextBox>
              <asp:Button ID="Enter1" runat="server" Text="Enter username" OnClick="Enter1_Click" Width="105px" />
              <asp:RequiredFieldValidator ID="ValUsername" 
              runat="server" ControlToValidate ="Username"
              ErrorMessage="Please enter a valid Name!" >
              </asp:RequiredFieldValidator>
        </div>
    </form>
</body>
</html>
