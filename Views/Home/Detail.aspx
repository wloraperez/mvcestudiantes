<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<mvcEstudiantes.Models.Estudiante>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalle
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalle de Estudiante</h2>

    <fieldset>
        <legend>Datos del estudiante</legend>
        
        <div class="display-label">ID</div>
        <div class="display-field"><%: Model.ID %></div>
        
        <div class="display-label">Nombre</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label">Apellido</div>
        <div class="display-field"><%: Model.Apellido %></div>
        
        <div class="display-label">Cedula</div>
        <div class="display-field"><%: Model.Cedula %></div>
        
        <div class="display-label">Telefono</div>
        <div class="display-field"><%: Model.Telefono %></div>
        
        <div class="display-label">Email</div>
        <div class="display-field"><%: Model.Email %></div>
        
        <div class="display-label">FechaNacimiento</div>
        <div class="display-field"><%: String.Format("{0:d}", Model.FechaNacimiento) %></div>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.ID }) %> |
        <%: Html.ActionLink("Back to List", "List") %>
    </p>

</asp:Content>

