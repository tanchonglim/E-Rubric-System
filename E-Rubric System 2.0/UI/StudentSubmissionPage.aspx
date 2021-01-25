<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentSubmissionPage.aspx.cs" Inherits="E_Rubric_System.UI.StudentCourseworkSubmissionPage" MasterPageFile="Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
   
    <div class="container">
       <br />
        <nav aria-label="breadcrumb">
          <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/UI/HomePage.aspx">Home</a></li>
            <li class="breadcrumb-item active"> <a href="/UI/StudentCourseworkListPage.aspx">Coursework</a> </li>
            <li class="breadcrumb-item active" aria-current="page">Coursework Submission</li>
          </ol>
        </nav>
        <br />

        <h1>Coursework Submission</h1>
         <br />
        
        
        <div class="card border-primary mb-3" >
          <div class="card-header" runat="server" id="courseworkTitle" >  </div>
          <div class="card-body">

            <div class="alert alert-dismissible alert-primary" runat="server" id="alert">
                <button type="button" class="close" data-dismiss="alert">&times;</button>
                 Please type something
            </div>

            <div class="card-text ">
                <table class="table table-bordered">
                    <tr> 
                        <th>Due Date</th>
                        <td runat="server" id="dueDate" > </td>
                    </tr>
                    <tr> 
                        <th>Status</th>
                        <td runat="server" id="status" >  Pending Submission </td>
                    </tr>
                    <tr> 
                        <th>Grade</th>
                        <td runat="server" id="grade" >  Not Graded </td>
                    </tr>
                    <tr>
                        <th>Time Remaining</th>
                        <td runat="server" id="timeRemain" >  - </td>
                    </tr>
                    <tr> 
                        <th>Marks</th>
                        <td runat="server" id="marks" >  - </td>
                    </tr>
                    <tr> 
                        <th>Submission</th>
                        <td >
                            <asp:TextBox ID="txtSubmissionText" Columns="60" Rows="10"  TextMode="MultiLine" runat="server" CausesValidation="False"></asp:TextBox> 
                        </td>
                    </tr>
                </table>
                <asp:Button ID="btnSubmit" CssClass="btn btn-success" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
          </div>
        </div>



    </div>

</asp:Content>
