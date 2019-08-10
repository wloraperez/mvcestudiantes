<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<mvcEstudiantes.Models.EstudianteAsignatura>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Editar seleccion
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar seleccion</h2>

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
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

