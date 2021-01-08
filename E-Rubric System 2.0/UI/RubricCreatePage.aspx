<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RubricCreatePage.aspx.cs" Inherits="E_Rubric_System.UI.RubricCreatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .iconbar {
            width: 100%;
            background-color: #59CDFF; 
            overflow: auto;
            border: solid;
            border-color:black;
	}
    .hype {
            float: left; 
            text-align: center; 
            width: 30%;
            padding: 12px 0; 
            transition: all 0.3s ease; 
            color: white; 
            font-size: 30px; 
            text-decoration: none;
    }
    #btnCreate {
            background-color: #59CDFF; 
            font-size: 20px;
            color:white;
   	}

     textarea{
        height: 100px;
    }
  
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div class="iconbar">
            <asp:HyperLink class="hype" ID="HyperLink1" runat="server" NavigateUrl="~/UI/HomePage.aspx">Home</asp:HyperLink>
            <asp:HyperLink class="hype" ID="HyperLink2" runat="server" NavigateUrl="~/UI/RubricPage.aspx">Rubric</asp:HyperLink>
           <asp:HyperLink class="hype" ID="HyperLink3" runat="server" NavigateUrl="~/UI/CourseworkPage.aspx">Coursework</asp:HyperLink>
        </div>
        </div>
        <p style="height: 39px; margin-left: 40px;">
            Rubric Type:
            <asp:DropDownList ID="dropDownRubricType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="analytic">Analytic Rubric</asp:ListItem>
                <asp:ListItem Value="holistic">Holistic Rubric</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="height: 39px; margin-left: 40px;">
            Rubric Title:
            <asp:TextBox ID="txtRubricTitle" runat="server" placeholder="Type rubric title..." Height="27px" Width="165px" ></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="createNewRubric" Height="35px" Width="139px" />
        </p>
        <div style="margin-left: 40px; height: 267px;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnAddRow" runat="server" OnClick="btnAddRow_Click" Text="Add Row" />
&nbsp;<asp:Table ID="tblRubric" runat="server" border="1"  Width="853px">
            </asp:Table>
            
        </div>
    </form>
</body>
</html>
