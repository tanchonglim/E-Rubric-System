<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="E_Rubric_System.UI.HomePage"  MasterPageFile="Site.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
   
    <div class="container">
        <br /><br /><br />
        <div class="jumbotron">
            <h1 class="display-4">Welcome to E-Rubric System</h1>
            <p class="lead">This is a very simple E-Rubric system.</p>
            <hr class="my-4">
            <p>User can create, update and delete rubric. User also can attach rubric to a coursework </p>
            <p class="lead">
             <a class="btn btn-outline-info" href="/UI/Rubricpage.aspx" role="button">Create Rubric >></a>
            </p>
        </div>
    </div>

</asp:Content>