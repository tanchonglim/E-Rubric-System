<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseworkDetailPage.aspx.cs" Inherits="E_Rubric_System.UI.CourseworkDetailPage" MasterPageFile="Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
     <div class="container">

        <br />
        <nav aria-label="breadcrumb">
          <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/UI/HomePage.aspx">Home</a></li>
            <li class="breadcrumb-item"><a href="/UI/CourseworkPage.aspx">Coursework</a></li>
            <li class="breadcrumb-item active" aria-current="page">Coursework Detail</li>
          </ol>
        </nav>
        <br />


         <div class="card border-primary mb-3" >
            <div class="card-header">
                 <div class="d-flex justify-content-between">
                     <div class="form-group">
                    Coursework Title: 
                   <asp:Label ID="lblCourseworkName" runat="server" Text="Coursework Name"></asp:Label>
                </div>
                    <asp:Button CssClass="btn btn-primary" ID="btnGrade" runat="server" Text="View Submissions" OnClick="btnGrade_Click" />
                  </div>
               
            </div>
           
            <div class="card-body">
                <asp:Panel ID="Panel1" runat="server" Height="235px" Width="454px">
                    Due Date:
                    <asp:Label ID="lblCourseworkDue" runat="server" Text="12/12/2020"></asp:Label>
                    <br />
                    <br />
                    Number of Submission:
                    <asp:Label ID="lblNoFileSubmission" runat="server" Text="13"></asp:Label>
                    <br />
                    <br />
                    Rubric Attached:
                    <asp:Label ID="lblRubricAttached" runat="server" Text="None"> </asp:Label> 
                     <br />
                     <br />
                    <button type="button" runat="server" id="btnChange" class="btn btn-primary" data-toggle="modal" data-target="#rubricListModal">
                        Change Rubric
                    </button>
                    <asp:Button ID="btnView" CssClass="btn btn-primary" runat="server" Text="View Rubric" OnClick="btnView_Click" />
                    
                </asp:Panel>
               
            </div>
        </div>


        <!-- Modal -->
        <div class="modal fade" id="rubricListModal" tabindex="-1" aria-labelledby="rubricListModalLabel" aria-hidden="true">
          <div class="modal-dialog modal-lg modal-dialog-centered modal-dialog-scrollable">
            <div class="modal-content">
              <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Rubric List</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                  <span aria-hidden="true">&times;</span>
                </button>
              </div>
              <div class="modal-body">
                <asp:Table CssClass="table table-bordered " ID="tblRubrics" runat="server"  >
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell> Rubric Name </asp:TableHeaderCell>
                        <asp:TableHeaderCell> Rubric Type </asp:TableHeaderCell>
                        <asp:TableHeaderCell ColumnSpan="2"> Action </asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                </asp:Table>
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
              </div>
            </div>
          </div>
        </div>
       
       
    </div>
</asp:Content>