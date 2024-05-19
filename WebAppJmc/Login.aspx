<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebAppJmc.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1"  runat="server">
        <div>
            <asp:Label Text="Username" ID="lblUsername" runat="server" />
            <asp:TextBox ID="txtUsername" runat="server" />
           
        </div>
        <div>
             <asp:Label  Text="Password" ID="lblPassword" runat="server" />
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" />
        </div>
        <div>
            <asp:Button Text="LOGIN" ID="btnLogin" runat="server" />
        </div>
        
    </form>
</body>
</html>
