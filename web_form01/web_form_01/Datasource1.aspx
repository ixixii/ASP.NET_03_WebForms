<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datasource1.aspx.cs" Inherits="web_form_01.Datasource1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    

<body>
    <form id="form1" runat="server">
        <h2>Simple SQL Data Source</h2>
        <div style="border: 1px dashed teal;">
            <asp:SqlDataSource runat="server" ID="id_datasource11" 
                ProviderName="System.Data.SqlClient" 
                ConnectionString="Data Source=DESKTOP-1G3JHJP;database=db2;Integrated Security=True;" 
                SelectCommand="select * from girl" >
            </asp:SqlDataSource>

            <asp:GridView runat="server" ID="id_gridview11" DataSourceID="id_datasource11"></asp:GridView>
        </div>


        <h2>Conditional SQL Data Source age >13</h2>
        <div style="border: 1px dashed teal;">
            <asp:SqlDataSource runat="server" ID="id_datasource12" 
                ProviderName="System.Data.SqlClient" 
                ConnectionString="Data Source=DESKTOP-1G3JHJP;database=db2;Integrated Security=True;" 
                SelectCommand="select * from girl" 
                FilterExpression="age >13"              
                >
            </asp:SqlDataSource>

            <asp:GridView runat="server" ID="GridView12" DataSourceID="id_datasource12"></asp:GridView>
        </div>


        <h2>联动效果演示Demo</h2>
        <div style="border: 1px dashed teal;">
            <asp:SqlDataSource runat="server" ID="id_datasource2" 
                ProviderName="System.Data.SqlClient" 
                ConnectionString="Data Source=DESKTOP-1G3JHJP;database=db2;Integrated Security=True;" 
                SelectCommand="select distinct age from girl" >
            </asp:SqlDataSource>

            <asp:DropDownList ID="id_dropDown" runat="server" 
                AutoPostBack="true" DataSourceID="id_datasource2" DataTextField="age" >
            </asp:DropDownList>
        </div>

        <div style="border: 1px dashed teal;">
            <asp:SqlDataSource runat="server" ID="id_datasource3" 
                ProviderName="System.Data.SqlClient" 
                ConnectionString="Data Source=DESKTOP-1G3JHJP;database=db2;Integrated Security=True;" 
                SelectCommand="select * from girl where age=@select_age" >
                <SelectParameters>
                    <asp:ControlParameter ControlID="id_dropDown" 
                        Name="select_age" PropertyName="SelectedValue" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:GridView ID="id_gridView2" runat="server" DataSourceID="id_datasource3" >
            </asp:GridView>
        </div>
    </form>
</body>
</html>
