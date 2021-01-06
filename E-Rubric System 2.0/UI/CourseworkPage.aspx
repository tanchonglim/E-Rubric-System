<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseworkPage.aspx.cs" Inherits="E_Rubric_System.UI.CourseworkPage" %>

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
            height: 60px;
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
    	#view {
            height: 50px;
            width: 160px;
            background-color: #59CDFF; 
            font-size: 25px;
            color:white;
    	}

        #btnNewCoursework{
            color:white;
            font-size: 20px;
              background-color: #59CDFF; 
        }

        #tblCourseworks{
            text-align: center;
            align-items: center;
        }

    </style>
</head>
<body style="height: 499px">
    <form id="form1" runat="server">
        <div>
        <div class="iconbar">
            <asp:HyperLink class="hype" ID="HyperLink1" runat="server" NavigateUrl="~/UI/HomePage.aspx">Home</asp:HyperLink>
           <asp:HyperLink class="hype" ID="HyperLink2" runat="server" NavigateUrl="~/UI/RubricPage.aspx">Rubric</asp:HyperLink>
           <asp:HyperLink class="hype" ID="HyperLink3" runat="server" NavigateUrl="~/UI/CourseworkPage.aspx">Coursework</asp:HyperLink>
        </div>
        </div>
		<p style="width: 1247px; height: 62px; margin-top: 0px">
            &nbsp;</p>
        <p style="width: 1247px; height: 62px; margin-top: 0px">
            <strong>Coursework List&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>&nbsp;&nbsp;<asp:Button ID="btnNewCoursework" runat="server" OnClick="btnNewCoursework_Click" Text="New Coursework" Height="45px" />
            </p>
        <asp:Table ID="tblCourseworks" border="1"  runat="server" Width="1065px" Height="61px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell> Coursework Title</asp:TableHeaderCell>
                <asp:TableHeaderCell ColumnSpan="2"> Action </asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </form>
</body>
</html>
