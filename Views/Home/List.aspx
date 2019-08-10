<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<mvcEstudiantes.Models.Estudiante>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Listado
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Lista de estudiante</h2>
    <table>
        <tr>
            <th>
                ID
            </th>
            <th>
                Nombre
            </th>
            <th>
                Apellido
            </th>
            <th style="width: 30%;">
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: item.ID %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: item.Apellido %>
            </td>
            <td style="width: 30%;">
                <%: Html.ActionLink("Editar", "Edit", new { id=item.ID }) %>
                |
                <%: Html.ActionLink("Detalle", "Detail", new { id=item.ID })%>
                |
                <%: Html.ActionLink("Eliminar", "Delete", new { id=item.ID }) %>
            </td>
        </tr>
        <% } %>
    </table>
    <p>
        <%: Html.ActionLink("Agregar Estudiante", "Create") %>
    </p>
</asp:Content>
