<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWithStaySignedIn.aspx.cs" Inherits="DemoCookies.LoginWithStaySignedIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="border:2px solid red; width:50%">
            <table align="center">
                <tr>
                    <td>UserName:</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" Font-Bold="true" ForeColor="YellowGreen" OnClick="btnLogin_Click" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" ForeColor="#ff0000" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:CheckBox ID="cbStay" runat="server" Text="Stay signedin" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMsg" runat="server" Text="Label1"></asp:Label>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
