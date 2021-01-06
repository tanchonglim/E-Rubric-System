<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseworkDetailPage.aspx.cs" Inherits="E_Rubric_System.UI.CourseworkDetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .iconbar {
            width: 100%;
            background-color: #59CDFF; 
            overflow: auto;
            border: medium solid black;
            height: 61px;
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
    	#attrubric {
            height: 50px;
            width: 160px;
            background-color: #59CDFF; 
            font-size: 25px;
            color:white;
    	}

        .table{
            text-align:center;
            align-items: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="iconbar">
            <asp:HyperLink class="hype" ID="HyperLink1" runat="server" NavigateUrl="~/UI/HomePage.aspx">Home</asp:HyperLink>
            <asp:HyperLink class="hype" ID="HyperLink2" runat="server" NavigateUrl="~/UI/RubricPage.aspx">Rubric</asp:HyperLink>
            <asp:HyperLink class="hype" ID="HyperLink3" runat="server" NavigateUrl="~/UI/CourseworkPage.aspx">Coursework</asp:HyperLink>
        </div>
        <p>
            <asp:Label ID="lblCourseworkName" runat="server" Text="SCSJ1234 ASSIGNMENT 1"></asp:Label>
        </p>
       
        <asp:Table ID="Table1" runat="server" Height="106px" Width="1000px">
            <asp:TableRow>
                <asp:TableCell> 
                     <asp:Panel ID="Panel1" runat="server" Height="235px" Width="454px">
                        <br />
                        <br />
                        Due Date:
                        <asp:Label ID="lblCourseworkDue" runat="server" Text="12/12/2020"></asp:Label>
                        <br />
                        <br />
                        Number of Submission:
                        <asp:Label ID="lblNoFileSubmission" runat="server" Text="13"></asp:Label>
                        <br />
                        <br />
                        Rubric Attached:
                         <asp:Label ID="lblRubricAttached" runat="server" Text="None"></asp:Label>
                 </asp:Panel>
                </asp:TableCell>
                 <asp:TableCell> 
                     <asp:Table CssClass="table" ID="tblRubrics" border="1" runat="server"  Width="500px">
                          <asp:TableHeaderRow>
                              <asp:TableHeaderCell> Rubric Name </asp:TableHeaderCell>
                              <asp:TableHeaderCell ColumnSpan="2"> Action </asp:TableHeaderCell>
                          </asp:TableHeaderRow>
                     </asp:Table>
                 </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
