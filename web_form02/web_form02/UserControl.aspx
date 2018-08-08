<%@ Page Language="C#" Inherits="web_form02.UserControl" %>
<%@ Register Src="~/Footer.ascx" TagName="Footer" TagPrefix="Beyond" %>

<!DOCTYPE html>
<html>
<head runat="server">
        <meta http-equiv="content-type" content="text/html;charset=utf-8">
	<title>UserControl</title>
</head>
<body>
	<form id="form1" runat="server">
            <asp:Label id="id_label" runat="server"
                       Text="Custom Control By Beyond"/>
            <br/>
            <asp:Button id="id_btn" runat="server" OnClick="btnClicked" Text="Click Me" />
            
            <Beyond:Footer id="id_footer" runat="server">
            </Beyond:Footer>
	</form>
</body>
</html>
