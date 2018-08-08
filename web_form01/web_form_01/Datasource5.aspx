<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datasource5.aspx.cs" Inherits="web_form_01.Datasource5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:ListBox ID="id_listBox" runat="server" AutoPostBack="true" 
                            OnSelectedIndexChanged="id_listBox_SelectedIndexChanged">
                        </asp:ListBox>
                    </td>

                    <td>
                        <asp:DropDownList ID="id_dropDown" runat="server" AutoPostBack="true" 
                            OnSelectedIndexChanged="id_dropDown_SelectedIndexChanged" >
                        </asp:DropDownList>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="id_label_1_listBox" runat="server">
                        </asp:Label>
                    </td>

                    <td>
                        <asp:Label ID="id_label_2_dropDown" runat="server">
                        </asp:Label>
                    </td>
                </tr>

                <tr>
                    <td style="height:20px;background:pink;">
                    </td>

                    <td style="height:20px;background:pink;">
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:RadioButtonList ID="id_radioBtn" runat="server" AutoPostBack="true" 
                            OnSelectedIndexChanged="id_radioBtn_SelectedIndexChanged">
                        </asp:RadioButtonList>
                    </td>

                    <td>
                        <asp:CheckBoxList ID="id_checkBox" runat="server" AutoPostBack="true" 
                            OnSelectedIndexChanged="id_checkBox_SelectedIndexChanged">
                        </asp:CheckBoxList>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="id_label_3_radioBtn" runat="server"></asp:Label>
                    </td>

                    <td>
                        <asp:Label ID="id_label_4_checkBox" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
