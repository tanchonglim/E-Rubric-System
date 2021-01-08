<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RubricPage.aspx.cs" Inherits="E_Rubric_System.UI.WebForm1" %>

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
    #btnNewRubric, #btn, btn {
            background-color: #59CDFF; 
            font-size: 20px;
            color:white;
   	}
    .table{
        text-align: center;
        align-items: center;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div class="iconbar">
            <asp:HyperLink CssClass="hype" ID="HyperLink1" runat="server" NavigateUrl="~/UI/HomePage.aspx">Home</asp:HyperLink>
            <asp:HyperLink CssClass="hype" ID="HyperLink2" runat="server" NavigateUrl="~/UI/RubricPage.aspx">Rubric</asp:HyperLink>
            <asp:HyperLink CssClass="hype" ID="HyperLink3" runat="server" NavigateUrl="~/UI/CourseworkPage.aspx">Coursework</asp:HyperLink>
        </div>
        </div>
        <p>
&nbsp;&nbsp;&nbsp;</p>
        <p>
            <strong>Rubric List</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnNewRubric" runat="server" OnClick="gotoRubricCreatePage" Text="New Rubric" Height="30px" Width="140px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <asp:Table ID="tblRubrics" CssClass="table" runat="server" border="1"  Height="60px" Width="991px">
            <asp:TableRow>
                <asp:TableHeaderCell> Rubric Title</asp:TableHeaderCell>
                 <asp:TableHeaderCell> Rubric Type  </asp:TableHeaderCell>
                <asp:TableHeaderCell> Action  </asp:TableHeaderCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
