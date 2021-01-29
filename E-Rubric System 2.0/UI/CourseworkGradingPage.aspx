<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseworkGradingPage.aspx.cs" Inherits="E_Rubric_System.UI.CourseworkGradingPage"  MasterPageFile="Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
   
    <div class="container">
        
        <br />
        <nav aria-label="breadcrumb">
          <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/UI/HomePage.aspx">Home</a></li>
            <li class="breadcrumb-item"><a href="/UI/CourseworkPage.aspx">Coursework</a></li>
            <li class="breadcrumb-item"><a runat="server" id="courseworkDetail" href="/UI/CourseworkDetailPage.aspx">Coursework Detail</a></li>
            <li class="breadcrumb-item"><a runat="server" id="courseworkSubmission" href="/UI/CourseworkSubmissionList.aspx">Coursework Submission List</a></li>
            <li class="breadcrumb-item active" aria-current="page">Submission Grading</li>
          </ol>
        </nav>
        <br />

                <div class="card border-secondary mb-3" >
                  <div class="card-header"> Student's submission </div>
                  <div class="card-body">
                      <table class="table">
                          <tr>
                              <th>Coursework Due Date: </th>
                              <td runat="server" id="courseworkDue"></td>
                          </tr>
                          <tr>
                              <th>Submission Date: </th>
                              <td runat="server" id="submissionDate"></td>
                          </tr>
                          <tr>
                              <th>Submission Status: </th>
                              <td runat="server" id="submissionStatus"></td>
                          </tr>
                          <tr>
                              <th>Marks: </th>
                              <td runat="server" id="marks"></td>
                          </tr>
                          <tr>
                              <th>Grade: </th>
                              <td runat="server" id="grade"></td>
                          </tr>
                      </table>
                    <asp:TextBox ID="txtSubmissionText" ReadOnly="true" TextMode="MultiLine" Width="100%" Rows="10" runat="server"></asp:TextBox>
                  </div>
                </div>
            
             
                 <div class="card border-secondary mb-3" >
                  <div class="card-header"> Grading Rubric </div>
                  <div class="card-body">
                    <asp:Table CssClass="table table-bordered" ID="tblGrading" runat="server"> 
                        
                    </asp:Table>
                      <asp:Button ID="btnSubmit" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="btnGrade_Click" />
                  </div>
                </div>
                 
            
        

    </div>

</asp:Content>
