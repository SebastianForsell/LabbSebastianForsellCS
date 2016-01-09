<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
        </p>
        <asp:ListBox ID="ListBox1" runat="server" Height="393px" Width="437px"></asp:ListBox>
    </form>
</body>
</html>

