<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server">Id</asp:Label>
        <asp:TextBox ID="editid" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
         <asp:Label ID="Label2" runat="server">Name</asp:Label>
        <asp:TextBox ID="editnm" runat="server"></asp:TextBox>
        <br /><br />
         <asp:Label ID="Label3" runat="server">Email</asp:Label>
        <asp:TextBox ID="editeml" runat="server"></asp:TextBox>
        <br /><br />
         <asp:Label ID="Label4" runat="server">Phone</asp:Label>
        <asp:TextBox ID="editpn" runat="server"></asp:TextBox>
        <br /><br />

        <asp:Button runat="server" ID="editnow" Text="Edit" OnClick="editnow_Click"  />

    
    </div>
    </form>
</body>
</html>
