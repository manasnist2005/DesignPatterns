<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TestWebForm.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gvTest" OnDataBinding="gvTest_onDataBinding" runat="server">

    </asp:GridView>
         
    </div>
    </form>
</body>
</html>
