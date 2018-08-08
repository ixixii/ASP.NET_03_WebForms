<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datasource2.aspx.cs" Inherits="web_form_01.Datasource2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="border:1px dashed teal;">
        
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="getGirls" TypeName="web_form_01.Girl">

        </asp:ObjectDataSource>

        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
        </asp:GridView>

            </div>


        <div style="border:1px dashed teal;">
            <hr style="height: 154px"/>







            <hr/>
        </div>

    </form>
</body>
</html>
