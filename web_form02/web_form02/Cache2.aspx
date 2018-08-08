<%@ Page Language="C#" Inherits="web_form02.Cache2" %>
<%@ OutputCache Duration="60" VaryByParam="id_input_girlname" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Cache2</title>
</head>
<body>
	<form id="form1" runat="server">
            <asp:TextBox id="id_input_girlname" runat="server"></asp:TextBox>
            <asp:Button id="id_btn" runat="server" OnClick="btnClicked" Text="Click Me" ></asp:Button>
	</form>
</body>
</html>
