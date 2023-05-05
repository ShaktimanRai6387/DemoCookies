<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBConnectionPage1.aspx.cs" Inherits="DemoCookies.DataBaseExample.DBConnectionPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="Show Record" OnClick="Button2_Click" /><br />
            <hr />
            <asp:GridView ID="GridView1" runat="server">
               <%-- <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id" />
                    <asp:BoundField HeaderText=" Name" DataField="Name" />
                    <asp:BoundField HeaderText="Class" DataField="Class" />
                    <asp:BoundField HeaderText="Section" DataField="Section" />
                    <asp:BoundField HeaderText="RoolNo" DataField="RoolNo" />
                </Columns>--%>
            </asp:GridView><br />
            <hr />
            <div>
                <h1>Execute Reader():</h1>
                <br />
            <asp:Button ID="btnExecuteReder" runat="server" Text="Search Data & Display"
                ForeColor="SeaGreen" BackColor="White" BorderStyle="Solid"
                Font-Size="Large" OnClick="btnExecuteReder_Click" />
                </div>
            <br />
            <hr />
            <div style="border:2px solid red">
                <h3>Select Student by RoolNo</h3>
                <br />
                <asp:Button ID="btnSearchRoolNo" runat="server" Text="Search Student by RoolNo" OnClick="btnSearchRoolNo_Click" />

            </div>
        </div>
    </form>
</body>
</html>
