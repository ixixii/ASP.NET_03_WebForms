<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="web_form_01.Contact" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<%-------------------------------------%>
    <hr/>
        <h3>File Upload</h3>
        <asp:FileUpload ID="id_uploader" runat="server"/>
        <asp:Button ID="id_btn4" runat="server"  Text="Upload" onclick="id_btn4_Click" />
        <asp:Label ID="id_label4" runat="server" />

    </asp:Content>