<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<mvcEstudiantes.Models.EstudianteAsignatura>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Agregar asignatura a estudiante</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
                        
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IDEstudiante) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IDEstudiante) %>
                <%: Html.ValidationMessageFor(model => model.IDEstudiante) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IDAsignatura) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IDAsignatura) %>
                <%: Html.ValidationMessageFor(model => model.IDAsignatura) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Listado", "Index") %>
    </div>

</asp:Content>

