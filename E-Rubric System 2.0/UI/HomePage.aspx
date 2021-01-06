<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="E_Rubric_System.UI.HomePage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            height: 76px;
            width: 127px;
        }
        #Button2 {
            height: 66px;
            width: 112px;
        }
        #btnRubric, #btnCoursework {
            padding: 2rem 1rem;
            background-color: #59CDFF; 
            font-size: 30px;
            color:white;
        }
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
    	.center {
            width: 100%;
            height: 500px;
            display: flex;
            align-items: center;
            justify-content: center;
    	}

    

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div class="iconbar">
            <asp:HyperLink class="hype" ID="HyperLink1" runat="server" NavigateUrl="~/UI/HomePage.aspx" text-de>Home</asp:HyperLink>
            <asp:HyperLink class="hype" ID="HyperLink2" runat="server" NavigateUrl="~/UI/RubricPage.aspx">Rubric</asp:HyperLink>
            <asp:HyperLink class="hype" ID="HyperLink3" runat="server" NavigateUrl="~/UI/CourseworkPage.aspx">Coursework</asp:HyperLink>
        </div>
        </div>
        <div class="center">

            <asp:Button ID="btnRubric" runat="server" OnClick="gotoRubricPage" Text="Rubric" /> &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCoursework" runat="server" Text="Coursework" OnClick="gotoCourseworkPage" />
            
            
        </div>
    </form>
</body>
</html>
