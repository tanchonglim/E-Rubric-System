<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RubricPage.aspx.cs" Inherits="E_Rubric_System.UI.WebForm1" MasterPageFile="Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="container">
        <br />
        <nav aria-label="breadcrumb">
          <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/UI/HomePage.aspx">Home</a></li>
            <li class="breadcrumb-item active" aria-current="page">Rubric</li>
          </ol>
        </nav>
        <br />

        <h1> Rubric List <asp:Button ID="btnNewRubric" CssClass="btn btn-info" runat="server" OnClick="gotoRubricCreatePage" Text="New Rubric" /> </h1>
         
        <br />
        <br />
        
        <asp:Table ID="tblRubrics" CssClass="table table-secondary" runat="server" >
            <asp:TableRow>
                <asp:TableHeaderCell> Rubric Title</asp:TableHeaderCell>
                    <asp:TableHeaderCell> Rubric Type  </asp:TableHeaderCell>
                <asp:TableHeaderCell> Action  </asp:TableHeaderCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>