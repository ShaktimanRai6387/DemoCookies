<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalDetails.aspx.cs" Inherits="DemoCookies.SessionObj.PersonalDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .auto-style1{
            width:50%;
            border-style:solid;
            border-width:1px
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Personal Details</h1>
            <table class="auto-style1">
                <tr>
                    <td>FirstName:</td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>LastName:</td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Mobile:</td>
                    <td>
                        <asp:TextBox  ID="txtMobile" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>  
                <tr>
                    <td>
                        <asp:Button ID="btnNextPage" runat="server" Text="Next Page" OnClick="btnNextPage_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
