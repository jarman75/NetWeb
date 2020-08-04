<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCoche.aspx.cs" Inherits="WebFormsApp.AddCoche" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
<asp:FormView runat="server" ID="addCocheForm"
    ItemType="Example.DAL.DataModels.Coche" 
    InsertMethod="addStudentForm_InsertItem" DefaultMode="Insert"
    RenderOuterTable="false" OnItemInserted="addCocheForm_ItemInserted">
    <InsertItemTemplate>
        <fieldset>
            <ol>
                <asp:DynamicEntity runat="server" Mode="Insert" />
            </ol>
            <asp:Button runat="server" Text="Insert" CommandName="Insert" />
            <asp:Button runat="server" Text="Cancel" CausesValidation="false" OnClick="Cancel_Click" />
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
</asp:Content>
