<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RubricDetailPage.aspx.cs" Inherits="E_Rubric_System.UI.RubricDetailPage" MasterPageFile="Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="container"> 
        <br />
        <nav aria-label="breadcrumb">
          <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/UI/HomePage.aspx">Home</a></li>
            <li class="breadcrumb-item"><a href="/UI/RubricPage.aspx">Rubric</a></li>
            <li class="breadcrumb-item active" aria-current="page">Rubric Detail</li>
          </ol>
        </nav>
        <br />
        
        <asp:Panel ID="viewMode" runat="server" Width="840px" >
            <asp:Button ID="btnEdit" CssClass="btn btn-info" runat="server" OnClick="goEditMode" Text="Edit" />
        </asp:Panel>
        <asp:Panel ID="editMode" runat="server"> 
            <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-info"  Text="Cancel" OnClick="enableViewMode" /> &nbsp;  &nbsp;
            <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-success"  Text="Update" OnClick="updateRubric" /> &nbsp;  &nbsp;
            <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-outline-danger"  Text="Delete" OnClick="deleteRubric" />
        </asp:Panel>
        
        <br />

        <div class="card text-white bg-info mb-3" >
            <div class="card-header">
               <div class="form-group">
                    <label for="txtRubricTitle"> Rubric Title:</label>
                   <asp:TextBox class="form-control" ID="txtRubricTitle" ReadOnly="true" runat="server"></asp:TextBox>
                </div>
            </div>
           
            <div class="card-body">
                <asp:Table CssClass="table table-hover text-white" ID="tblRubric" runat="server">
                </asp:Table>

                 <asp:Panel ID="editMode2" runat="server"> 
                   <asp:Button CssClass="btn btn-secondary"  ID="btnAddRow" runat="server" OnClick="btnAddRow_Click" Text="Add Row" /> &nbsp; &nbsp;
                    <asp:Button CssClass="btn btn-danger"  ID="btnRemoveRow" runat="server" OnClick="btnRemoveRow_Click" Text="Remove Last Row" />
                 </asp:Panel>
         
             </div>
        </div>

    </div>
</asp:Content>