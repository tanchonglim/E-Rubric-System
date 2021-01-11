<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseworkPage.aspx.cs" Inherits="E_Rubric_System.UI.CourseworkPage" MasterPageFile="Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="container">

                <br />
        <nav aria-label="breadcrumb">
          <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/UI/HomePage.aspx">Home</a></li>
            <li class="breadcrumb-item active" aria-current="page">Coursework</li>
          </ol>
        </nav>
        <br />

        <h1>Coursework List  <asp:Button ID="btnNewCoursework"  CssClass="btn btn-info" runat="server" OnClick="btnNewCoursework_Click" Text="New Coursework"  />
         </h1>

        <br />
        <br />
            
        <asp:Table ID="tblCourseworks" CssClass="table table-secondary" runat="server" >
            <asp:TableHeaderRow>
                <asp:TableHeaderCell> Coursework Title</asp:TableHeaderCell>
                <asp:TableHeaderCell ColumnSpan="2"> Action </asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>

    </div>
</asp:Content>
