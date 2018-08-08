<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="web_form_01.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fileUpload" runat="server" />
            <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="上传" />
            <asp:Literal ID="literal" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
