<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datasource4.aspx.cs" Inherits="web_form_01.Datasource4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db2ConnectionString %>" SelectCommand="SELECT * FROM [girl]"></asp:SqlDataSource>
        <asp:BulletedList ID="BulletedList1" runat="server" DataSourceID="SqlDataSource1" 
            DataTextField="name" DataValueField="id">
        </asp:BulletedList>
    </form>
</body>
</html>
