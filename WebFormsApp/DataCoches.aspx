﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataCoches.aspx.cs" Inherits="WebFormsApp.DataCoches" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<asp:HyperLink NavigateUrl="~/AddCoche" Text="Añadir nuevo coche" runat="server" />
<asp:GridView ID="cochesGrid" runat="server"
        ItemType="Example.DAL.DataModels.Coche" DataKeyNames="Id"
        SelectMethod="cochesGrid_GetData"
        UpdateMethod="cochesGrid_UpdateItem"
        DeleteMethod="cochesGrid_DeleteItem"
        AutoGenerateColumns="false"
        AutoGenerateEditButton="true"
        AutoGenerateDeleteButton="true">
        <Columns>
            <asp:DynamicField DataField="Id" />
            <asp:DynamicField DataField="Marca" />
            <asp:DynamicField DataField="Modelo" />
            <asp:DynamicField DataField="NumeroPuertas" />
            <asp:DynamicField DataField="TipoCombustible" />
            <asp:DynamicField DataField="PrecioAlquilerDia" />
        </Columns>
    </asp:GridView>
</asp:Content>
