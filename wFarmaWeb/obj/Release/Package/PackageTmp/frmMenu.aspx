<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/mstFarmaWeb.Master" CodeBehind="frmMenu.aspx.vb" Inherits="wFarmaWeb.frmMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table align="center">
        <tr>
            <td align="center">
                <asp:HyperLink ID="hlkAdminTipoInfo" runat="server" NavigateUrl="~/Admin/AdminInfoParamMed.aspx">Administración Información del Sistema</asp:HyperLink>
                <br />
                <asp:HyperLink ID="hlkAdminMedica" runat="server" NavigateUrl="~/Medicamentos/medInfoMedicamentos.aspx">Administración Medicamentos</asp:HyperLink>

              <%--  <ul class="menu">
                  <li><a href="~/Admin/AdminInfoParamMed.aspx" class="active" target="_blank"><span>Administración Información del Sistema</span></a></li>
                  <li><a href="~/Medicamentos/medInfoMedicamentos.aspx" target="_blank"><span>Administración Medicamentos</span></a></li>
                </ul>--%>

            </td>
        </tr>
    </table>
</asp:Content>
