<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="E_Rubric_System.UI.HomePage"  MasterPageFile="Site.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
   
    <div class="container">
        <br /><br /><br />
        <div runat="server" id="ccText" class="jumbotron">
            <h1 class="display-4">Course coordinator, Welcome to E-Rubric System</h1>
            <p class="lead">This is a very simple E-Rubric system.</p>
            <hr class="my-4">
            <p>Course coordinator can create, update and delete rubric. Course coordinator also can attach rubric to a coursework </p>
            <p class="lead">
             <a class="btn btn-outline-primary" href="/UI/Rubricpage.aspx" role="button">Create Rubric >></a>
            </p>
        </div>

        <div runat="server" id="lectText" class="jumbotron">
            <h1 class="display-4">Lecturer, Welcome to E-Rubric System</h1>
            <p class="lead">This is a very simple E-Rubric system.</p>
            <hr class="my-4">
            <p>Lecturer can give marks to students' coursework. </p>
            <p class="lead">
             <a class="btn btn-outline-primary" href="/UI/CourseworkPage.aspx" role="button">View All courseworks >></a>
            </p>
        </div>

        <div runat="server" id="stdText" class="jumbotron">
            <h1 class="display-4">Student, Welcome to E-Rubric System</h1>
            <p class="lead">This is a very simple E-Rubric system.</p>
            <hr class="my-4">
            <p>Student can submit their coursework, and view the marks given. </p>
            <p class="lead">
             <a class="btn btn-outline-primary" href="/UI/StudentCourseworkListPage.aspx" role="button">View All courseworks >></a>
            </p>
        </div>

    </div>

</asp:Content>