<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUpdateDelete.aspx.cs" Inherits="DemoCookies.AddUpdateDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>ID:</td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Class:</td>
                    <td>
                        <asp:TextBox ID="txtClass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Section:</td>
                    <td>
                        <asp:TextBox ID="txtSection" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>RoolNo:</td>
                    <td>
                        <asp:TextBox ID="txtRoolNo" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" BackColor="Red" OnClick="btnInsert_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" BackColor="green" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" BackColor="blue" OnClick="btnDelete_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" ForeColor="YellowGreen"></asp:Label>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
