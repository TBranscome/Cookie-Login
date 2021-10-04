<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginCookies.aspx.cs" Inherits="Cookie_Login.LoginCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="login" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" Width="86px" OnClick="Button1_Click" />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Save Login?" />
        </div>
        <div id="content" style="display:none" runat="server">
            <h1>WELCOME</h1>
        </div>
    </form>
    
</body>
</html>
