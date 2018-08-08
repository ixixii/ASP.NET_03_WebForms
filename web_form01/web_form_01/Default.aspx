<%@ Page Title="Home Page" Language="C#" 
    MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="web_form_01._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET Web Form</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <%-------------------------------------%>
    <hr/>
    <div>
            <asp:Label ID="id_lable" runat="server">
            </asp:Label>

            <asp:Button ID="id_btn" runat="server" Text="Click Me"
                onclick="id_btn_Click" />
        </div>


    <%-------------------------------------%>
    <hr/>
    <div>
        
        Enter Name: <asp:TextBox ID="id_input" runat="server"
></asp:TextBox>    
        <asp:Button ID="id_btn2" runat="server"
            OnClick="id_btn2_Click" Text="Submit"/>
        <br/>
        <asp:Label ID="id_label2" runat="server" />
    </div>
    
      <%-------------------------------------%>
    <hr/>
    <div>
        <asp:GridView ID="id_gridView" runat="server"></asp:GridView>
        <br />
        <br />
        <br />
        <asp:TreeView ID="id_treeView1" runat="server" Height="365px" ImageSet="Arrows" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" Width="360px">
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <Nodes>
                <asp:TreeNode Text="RootNode" Value="RootNode">
                    <asp:TreeNode Text="HomeNode" Value="HomeNode"></asp:TreeNode>
                    <asp:TreeNode Text="ProductNode" Value="ProductNode"></asp:TreeNode>
                    <asp:TreeNode Text="AboutNode" Value="AboutNode">
                        <asp:TreeNode Text="CompanyNode" Value="CompanyNode"></asp:TreeNode>
                        <asp:TreeNode Text="ContactNode" Value="ContactNode"></asp:TreeNode>
                    </asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>


        


        <asp:Label ID="id_label3" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="id_input3" runat="server"></asp:TextBox>
        <br />
         

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>















    <hr/>
    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
