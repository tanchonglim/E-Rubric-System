<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RubricCreatePage.aspx.cs" Inherits="E_Rubric_System.UI.RubricCreatePage" MasterPageFile="Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="container">
        <br />
        <nav aria-label="breadcrumb">
          <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/UI/HomePage.aspx">Home</a></li>
            <li class="breadcrumb-item"><a href="/UI/RubricPage.aspx">Rubric</a></li>
            <li class="breadcrumb-item active" aria-current="page">Rubric Create</li>
          </ol>
        </nav>
        <br />

        <div style="display: flex; justify-content: space-between;">
            <div class="form-group" style="width: 200px;"> 
                <label for="dropDownRubricType">Rubric Type:</label>
                 <asp:DropDownList CssClass="custom-select" ID="dropDownRubricType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="analytic">Analytic Rubric</asp:ListItem>
                    <asp:ListItem Value="holistic">Holistic Rubric</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div> <br />
                <asp:Button ID="btnCreate" CssClass="btn btn-success" runat="server" Text="Create" OnClick="createNewRubric" />
             </div>
         </div>
        <div class="card text-white bg-info mb-3" >
            <div class="card-header">
               <div class="form-group">
                    <label for="txtRubricTitle"> Rubric Title:</label>
                    <asp:TextBox CssClass="form-control" ID="txtRubricTitle" runat="server" placeholder="Type rubric title..." Height="27px" Width="165px" ></asp:TextBox>
                </div>
            </div>
           
            <div class="card-body">
                <asp:Table  CssClass="table table-hover text-white" ID="tblRubric" runat="server">
                </asp:Table>
            
                <asp:Button CssClass="btn btn-secondary"  ID="btnAddRow" runat="server" OnClick="btnAddRow_Click" Text="Add Row" /> &nbsp; &nbsp;
                <asp:Button CssClass="btn btn-danger"  ID="btnRemoveRow" runat="server" OnClick="btnRemoveRow_Click" Text="Remove Last Row" />
            </div>
        </div>

    


        
            


    </div>
</asp:Content>