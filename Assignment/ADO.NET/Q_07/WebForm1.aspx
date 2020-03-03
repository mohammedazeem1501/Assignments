<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q_07.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>

            <br />
            <br />
            <br />

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

            <br />
            <br />
            <br />
            <br />
            <br />
            <br />

            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
