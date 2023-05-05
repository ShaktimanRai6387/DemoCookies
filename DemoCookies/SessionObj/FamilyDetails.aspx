<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FamilyDetails.aspx.cs" Inherits="DemoCookies.SessionObj.FamilyDetails" %>

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
            <h1>familyDetails</h1>
            <table class="auto-style1">
                <tr>
                    <td>SpouseName:</td>
                    <td>
                        <asp:TextBox ID="txtSpouseName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>FatherName:</td>
                    <td>
                        <asp:TextBox ID="txtFatherName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>MotherName:</td>
                    <td>
                        <asp:TextBox ID="txtMotherName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Children(if any):</td>
                    <td>
                        <asp:TextBox ID="txtChildren" runat="server"></asp:TextBox>
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
