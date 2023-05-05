<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationObjectExamle.aspx.cs" Inherits="DemoCookies.ApplicationObjectExamle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Application Object Examle</h1>
            <br />
            Total User:<asp:Label ID="Label1" runat="server" Text="Label1" ForeColor="YellowGreen"></asp:Label>
            <br />
            Online User:<asp:Label ID="Label2" runat="server" Text="Label1" ForeColor="YellowGreen"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Sing Out" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
