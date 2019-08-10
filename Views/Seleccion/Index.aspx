<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<mvcEstudiantes.Models.EstudianteAsignatura>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Listado de seleccion
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Listado de Seleccion</h2>
         <p>
        <%: Html.ActionLink("Agregar asignatura a estudiante", "Create") %>
    </p>
    <table style="width: 70%;">
        <tr>
            <th>
            </th>
            <th>
                ID
            </th>
            <th>
                IDEstudiante
            </th>
            <th>
                IDAsignatura
            </th>
            <th>
                Estudiante
            </th>
            <th>
                Asignatura
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.ID }) %>
                |
                <%: Html.ActionLink("Detalle", "Detail", new { id=item.ID })%>
                |
                <%: Html.ActionLink("Borrar", "Delete", new { id=item.ID })%>
            </td>
            <td>
                <%: item.ID %>
            </td>
            <td>
                <%: item.IDEstudiante %>
            </td>
            <td>
                <%: item.IDAsignatura %>
            </td>
            <td>
                <%: string.Format("{0} {1}", item.Estudiante.Nombre , item.Estudiante.Apellido)  %>
            </td>
            <td>
                <%: item.Asignaturas.Nombre  %>
            </td>
        </tr>
        <% } %>
    </table>
    <p>
        <%: Html.ActionLink("Agregar asignatura a estudiante", "Create") %>
    </p>
</asp:Content>
