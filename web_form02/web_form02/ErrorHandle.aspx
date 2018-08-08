<%@ Page Language="C#" Inherits="web_form02.ErrorHandle"
Trace="true"
%>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>ErrorHandle</title>
</head>
<body>
	<form id="form1" runat="server">
            <asp:Label id="id_label" runat="server" Text="Tracing_ErrorHandle_Debug">
            </asp:Label>
            <hr/><br/>
            <asp:DropDownList id="id_dropDown" runat="server" AutoPostBack="true"
                              OnSelectedIndexChanged="id_dropDown_SelectedIndexChanged">
            </asp:DropDownList>
            <hr/><br/>
            <asp:Label id="id_label2" runat="server">
            </asp:Label>
            <hr/><br/>
            <asp:HyperLink id="id_link" runat="server" NavigateUrl="NotExsit.html">
                Link To Not Exsit
            </asp:HyperLink>
	</form>
</body>
</html>
