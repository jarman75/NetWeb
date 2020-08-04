<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>WebForms .NET</h1>
        
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Coches</h2>
            <p>
                Lista de coches disponibles par alquilar.
            </p>
            <p>
                <a class="btn btn-default" href="/DataCoches.aspx">Ver &raquo;</a>
            </p>
        </div>
        
    </div>

</asp:Content>
