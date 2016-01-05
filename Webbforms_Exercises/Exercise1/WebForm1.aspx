<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Exercise1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>Simple Weight Converter</p>
    <form id="form1" runat="server">
        <asp:ListBox ID="fromList" runat="server" Height="76px" Width="74px">
            <asp:ListItem Value="gram">Gram</asp:ListItem>
            <asp:ListItem Value="hekto">Hektogram</asp:ListItem>
            <asp:ListItem Value="kilo">Kilogram</asp:ListItem>
            <asp:ListItem Value="milli">Milligram</asp:ListItem>
        </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; --&gt;
        <asp:ListBox ID="toList" runat="server" Height="76px" style="margin-left: 35px" Width="74px">
            <asp:ListItem Value="gram">Gram</asp:ListItem>
            <asp:ListItem Value="hekto">Hektogram</asp:ListItem>
            <asp:ListItem Value="kilo">Kilogram</asp:ListItem>
            <asp:ListItem Value="milli">Milligram</asp:ListItem>
        </asp:ListBox>
    <div>
    
    </div>
        <p>
            <asp:TextBox ID="weightInput" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="convertButton" runat="server" Font-Bold="True" ForeColor="Maroon" Height="54px" OnClick="Button1_Click" Text="Convert!" Width="131px" />
        <p>
            <asp:Label ID="convertResult" runat="server" Text="Resultat:"></asp:Label>
        </p>
    </form>
</body>
</html>
