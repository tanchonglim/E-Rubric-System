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
            Rubric Title:
            <asp:TextBox ID="txtRubricTitle" runat="server" placeholder="Type rubric title..." Height="27px" Width="165px" ></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="createNewRubric" Height="35px" Width="139px" />
        </p>
        <div style="margin-left: 40px; height: 267px;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Table ID="tblRubric" runat="server" border="1" Height="399px" Width="853px">
                <asp:TableRow>
                   <asp:TableHeaderCell> Criteria </asp:TableHeaderCell>
                     <asp:TableHeaderCell> Excellent (5) </asp:TableHeaderCell>
                     <asp:TableHeaderCell> Good (4) </asp:TableHeaderCell>
                     <asp:TableHeaderCell> Satisfactory (3) </asp:TableHeaderCell>
                     <asp:TableHeaderCell> Fair (2) </asp:TableHeaderCell>
                     <asp:TableHeaderCell> Poor (1) </asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell> <asp:TextBox ID="txtCriteria1" runat="server" placeholder="Type description..." TextMode="MultiLine"></asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtExcel1" runat="server" placeholder="Type description..." TextMode="MultiLine"></asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtGood1" runat="server" placeholder="Type description..." TextMode="MultiLine"></asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtStatis1" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtFair1" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtPoor1" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                </asp:TableRow>

                 <asp:TableRow>
                    <asp:TableCell> <asp:TextBox ID="txtCriteria2" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtExcel2" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtGood2" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtStatis2" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtFair2" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtPoor2" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                </asp:TableRow>

                 <asp:TableRow>
                    <asp:TableCell> <asp:TextBox ID="txtCriteria3" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtExcel3" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtGood3" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtStatis3" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtFair3" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtPoor3" runat="server" placeholder="Type description..." TextMode="MultiLine"> </asp:TextBox> </asp:TableCell>
                </asp:TableRow>

            </asp:Table>
        </div>
    </form>
</body>
</html>
