<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<mvcEstudiantes.Models.EstudianteAsignatura>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Detalle Seleccion Asignatura
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Detalle Seleccion Asignatura</h2>
    <fieldset>
        <legend>Fields</legend>
        <div class="display-label">
            ID</div>
        <div class="display-field">
            <%: Model.ID %></div>
        <div class="display-label">
            IDEstudiante</div>
        <div class="display-field">
            <%: Model.IDEstudiante %></div>
        <div class="display-label">
            IDAsignatura</div>
        <div class="display-field">
            <%: Model.IDAsignatura %></div>
        <div class="display-label">
            Estudiante</div>
        <div class="display-field">
            <%: string.Format("{0} {1}", Model.Estudiante.Nombre, Model.Estudiante.Apellido)%></div>
        <div class="display-label">
            Cedula Estudiante</div>
        <div class="display-field">
            <%: Model.Estudiante.Cedula  %></div>
        <div class="display-label">
            Fecha de Nacimiento Estudiante</div>
        <div class="display-field">
            <%: Model.Estudiante.FechaNacimiento.Value.ToShortDateString()  %></div>
        <div class="display-label">
            Telefono Estudiante</div>
        <div class="display-field">
            <%: Model.Estudiante.Telefono %></div>
        <div class="display-label">
            Mail Estudiante</div>
        <div class="display-field">
            <%: Model.Estudiante.Email %></div>
        <div class="display-label">
            Asignatura</div>
        <div class="display-field">
            <%: Model.Asignaturas.Nombre  %></div>
        <div class="display-label">
            Horario Asignatura</div>
        <div class="display-field">
            <%: Model.Asignaturas.Horario  %></div>
    </fieldset>
    <p>
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.ID }) %>
        |
        <%: Html.ActionLink("Listado de seleccion", "Index") %>
    </p>
</asp:Content>
