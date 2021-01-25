<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseworkSubmissionList.aspx.cs" Inherits="E_Rubric_System.UI.CourseworkSubmissionList" MasterPageFile="Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
   
    <div class="container">
        
        <br />
        <nav aria-label="breadcrumb">
          <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/UI/HomePage.aspx">Home</a></li>
            <li class="breadcrumb-item"><a href="/UI/CourseworkPage.aspx">Coursework</a></li>
            <li class="breadcrumb-item"><a runat="server" id="courseworkDetail" href="/UI/CourseworkDetailPage.aspx">Coursework Detail</a></li>
            <li class="breadcrumb-item active" aria-current="page">Coursework Submission List</li>
          </ol>
        </nav>
        <br />

        <asp:Table ID="tblSubmissions" CssClass="table table-secondary" runat="server" >
            <asp:TableHeaderRow>
                <asp:TableHeaderCell> Num </asp:TableHeaderCell>
                <asp:TableHeaderCell> Student </asp:TableHeaderCell>
                <asp:TableHeaderCell> Status </asp:TableHeaderCell>
                <asp:TableHeaderCell> Marks </asp:TableHeaderCell>
                <asp:TableHeaderCell> Grade </asp:TableHeaderCell>
                <asp:TableHeaderCell > Action </asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>

    </div>

</asp:Content>
