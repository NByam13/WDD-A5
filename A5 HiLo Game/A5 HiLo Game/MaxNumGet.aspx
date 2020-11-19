<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaxNumGet.aspx.cs" Inherits="A5_HiLo_Game.MaxNumGet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p id="greeting" runat="server"></p>
        <div>
            <asp:TextBox ID="maxNum" runat="server"></asp:TextBox>
              <asp:Button ID="Enter1" runat="server" Text="Enter max number!" OnClick="Enter1_Click" Width="146px" />
              <asp:CompareValidator ID="ValMax" 
              runat="server"  Operator="GreaterThanEqual" ControlToValidate ="maxNum"
              Type="Integer" SetFocusOnError="true" 
              ValueToCompare="2" ErrorMessage="Please enter a valid integer">
              </asp:CompareValidator>
        </div>
    </form>
</body>
</html>
