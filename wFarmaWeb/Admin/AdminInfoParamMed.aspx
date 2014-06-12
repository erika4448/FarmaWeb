<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/mstFarmaWeb.Master" CodeBehind="AdminInfoParamMed.aspx.vb" Inherits="wFarmaWeb.AdminInfoParamMed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="upnlAdminInfoParam" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <table align="center">
                <tr>
                    <td align="left">
                        <asp:Label ID="lblTitulo" runat="server" Text="ADMINISTRACIÓN INFORMACIÓN DEL SISTEMA" CssClass="lblTituloGral"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Panel ID="pnlTIpoInfo" runat="server">
                            <table align="center">
                                <tr>
                                    <td>

                                        <asp:Label ID="lblTipoInfo" runat="server" Text="Tipo Información"></asp:Label>

                                    </td>
                                    <td>

                                        <asp:DropDownList ID="ddlTipoInfo" runat="server" Style="height: 22px" AutoPostBack="True">
                                        </asp:DropDownList>

                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Panel ID="pnlGvInfoParam" runat="server">
                            <asp:GridView ID="gvInfoParam" runat="server" AutoGenerateColumns="False" DataKeyNames="mipmIdInfoPMed" DataSourceID="odsInfoParam" CssClass="gvGeneral">
                                <Columns>
                                    <asp:BoundField DataField="mipmValor" HeaderText="Nombre" SortExpression="mipmValor" />
                                    <asp:BoundField DataField="StrNomEstado" HeaderText="Estado" SortExpression="StrNomEstado" />
                                    <asp:ButtonField ButtonType="Button" CommandName="cmdEditar" Text="Editar" />
                                </Columns>
                            </asp:GridView>
                            <asp:ObjectDataSource ID="odsInfoParam" runat="server" SelectMethod="GetInfoParamMed" TypeName="wFarmaWeb.AdminInfoParamMed">
                                <SelectParameters>
                                    <asp:Parameter Name="parIdTipoInfo" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>

                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td align="center" class="auto-style1">
                        <asp:Button ID="btnNuevo" runat="server" CausesValidation="False" Text="Nuevo" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Panel ID="pnlInfoParamMed" runat="server" CssClass="pnlGeneral">
                            <table>
                                <tr>
                                    <td align="left">
                                        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                                    </td>
                                    <td>&nbsp;
                                    </td>
                                    <td align="left">

                                        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>

                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">

                                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

                                    </td>
                                    <td align="left">&nbsp;
                                    </td>
                                    <td align="left">

                                        <asp:DropDownList ID="ddlEstado" runat="server">
                                        </asp:DropDownList>

                                    </td>
                                </tr>
                                <tr>
                                    <td align="left"></td>
                                    <td>&nbsp;
                                    </td>
                                    <td align="left"></td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="3">&nbsp;
                                    <asp:Button ID="btnGuardar" runat="server" CausesValidation="False" Text="Guardar" />
                                        <asp:Button ID="btnCerrar" runat="server" CausesValidation="False" Text="Cerrar" />

                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
