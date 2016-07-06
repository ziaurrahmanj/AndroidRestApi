<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlickrGallery.aspx.cs" Inherits="FlickrClient.FlickrGallery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="SearchTerm" runat="server"></asp:TextBox><asp:Button ID="SearchBtn" runat="server" Text="Search" OnClick="SearchBtn_Click" />
        <br />
        <asp:LinkButton ID="NextPageBtn" runat="server" OnClick="NextPageBtn_Click">Next Page>></asp:LinkButton>
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
