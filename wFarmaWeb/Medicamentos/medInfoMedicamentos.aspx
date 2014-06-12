<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/mstFarmaWeb.Master" CodeBehind="medInfoMedicamentos.aspx.vb" Inherits="wFarmaWeb.medInfoMedicamentos" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td align="center">
                <asp:Label ID="lblTitulo" runat="server" Text="ADMINISTRACIÓN MEDICAMENTOS" CssClass="lblTituloGral"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">&nbsp;
            </td>
        </tr>
        <tr>
            <td align="left">&nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlBuscaMedica" runat="server">
                    <table align="center">
                        <tr>
                            <td align="left">

                                <asp:Label ID="lblNomMedicaBus" runat="server" Text="Nombre Medicamento"></asp:Label>

                            </td>
                            <td align="left">

                                <asp:TextBox ID="txtMedicaBus" runat="server"></asp:TextBox>

                            </td>
                            <td align="left">

                                <asp:Button ID="btnBuscar" runat="server" CausesValidation="False" Text="Buscar" />

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
                <asp:Panel ID="pnlGvResultados" runat="server">
                    <asp:GridView ID="gvMedicamentos" runat="server" AutoGenerateColumns="False" CssClass="gvGeneral" DataKeyNames="mmedIdMedicamento">
                        <Columns>
                            <asp:BoundField DataField="mmedIdMedicamento" HeaderText="ID" SortExpression="mmedIdMedicamento" />
                            <asp:BoundField DataField="mmedCodigoCUM" HeaderText="Código CUM" SortExpression="mmedCodigoCUM" />
                            <asp:BoundField DataField="mipmRegistroSani" HeaderText="Registro Sanitario" SortExpression="mipmRegistroSani" />
                            <asp:BoundField DataField="mmedNombre" HeaderText="Nombre" SortExpression="mmedNombre" />
                            <asp:BoundField DataField="StrNomEntidad" HeaderText="Entidad" SortExpression="StrNomEntidad" />
                            <asp:BoundField DataField="mipmVidaUtil" HeaderText="Vida Útil" SortExpression="mipmVidaUtil" />
                            <asp:BoundField DataField="StrViaAdmin" HeaderText="Vía Administración" SortExpression="StrViaAdmin" />
                            <asp:ButtonField ButtonType="Button" CommandName="cmdEditar" Text="Editar" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>&nbsp;
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CausesValidation="False" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;
            </td>
        </tr>
        <tr>
            <td align="center">
                <table align="center">
                    <tr>
                        <td align="center">
                            <asp:Panel ID="pnlInfoMedicamentos" runat="server" CssClass="pnlGeneral">
                                <table align="center">
                                    <tr>
                                        <td align="left">
                                            <asp:Label ID="lblCodCUM" runat="server" Text="Código CUM"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td align="left">
                                            <asp:Label ID="lblNombre" runat="server" Text="Nombre Medicamento"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            <asp:TextBox ID="txtCodCUM" runat="server"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            <asp:Label ID="lblEntidad" runat="server" Text="Entidad"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td align="left">
                                            <asp:Label ID="lblVidaUtil" runat="server" Text="Vida Útil"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            <asp:DropDownList ID="ddlEntidad" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtVidaUtil" runat="server" Width="30px"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtVidaUtil_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="txtVidaUtil">
                                            </asp:FilteredTextBoxExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            <asp:Label ID="lblRegSanita" runat="server" Text="Registro Sanitario"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td align="left">
                                            <asp:Label ID="lblFormaFarma" runat="server" Text="Forma Farmacéutica"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            <asp:TextBox ID="txtRegSanita" runat="server"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td align="left">
                                            <asp:DropDownList ID="ddlFormaFarma" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            <asp:Label ID="lblTipoConcentra" runat="server" Text="Tipo Concentración"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td align="left">
                                            <asp:Label ID="lblViaAdmin" runat="server" Text="Vía Administración"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            <asp:DropDownList ID="ddlTipoConcentra" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td align="left">
                                            <asp:DropDownList ID="ddlViaAdmin" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            <asp:Label ID="lblTipoMedica" runat="server" Text="Tipo Medicamento"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td align="left">
                                            <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            <asp:DropDownList ID="ddlTipoMedica" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td align="left">
                                            <asp:DropDownList ID="ddlEstado" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="3" align="center">
                                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CausesValidation="False" />
                                            <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" />
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
