<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
    
    </div>
        <asp:TextBox ID="txnm" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="User Email"></asp:Label>
        <br />
        <asp:TextBox ID="txeml" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="User Phone"></asp:Label>
        <br />
        <asp:TextBox ID="txpn" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>

        <br /><br />
        <asp:Label ID="lblid" runat="server">Remove Id</asp:Label>
        <asp:TextBox ID="rid" runat="server"></asp:TextBox>
        <asp:Button ID="btnrmv" runat="server" Text="Delete" OnClick="btnrmv_Click" />

        <br /><br />
        <asp:Label ID="lbiid2" runat="server">Edit Id</asp:Label>
        <asp:TextBox ID="eid"  runat="server"></asp:TextBox>
        <asp:Button ID="btnedit" runat="server" Text="Edit" OnClick="btnedit_Click"/>

    </form>
</body>
</html>
