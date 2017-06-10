<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmListarReservaFechaEstado.aspx.cs" Inherits="TestWeb.frmListarReservaFechaEstado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style8 {
        width: 145px;
    }
    .auto-style9 {
        width: 145px;
        height: 26px;
    }
    .auto-style10 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style8">Fecha Inicio:</td>
        <td>
            <asp:TextBox ID="txtInicio" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Fecha Fin:</td>
        <td>
            <asp:TextBox ID="txtFin" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">Estado:</td>
        <td class="auto-style10">
            <asp:DropDownList ID="cboEstado" runat="server">
                <asp:ListItem Selected="True">Todos</asp:ListItem>
                <asp:ListItem Value="1">Reservado</asp:ListItem>
                <asp:ListItem Value="2">Pagado</asp:ListItem>
                <asp:ListItem Value="3">Anulado</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td>
            <asp:Button ID="btnConsultar" runat="server" OnClick="btnBuscar_Click" Text="Consultar" />
        </td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td>
            <asp:GridView ID="gvReservas" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="IdReserva" HeaderText="Código" />
                    <asp:BoundField DataField="DescripcionEstadoReserva" HeaderText="Estado" />
                    <asp:BoundField DataField="NombreCliente" HeaderText="Nombre" />
                    <asp:BoundField DataField="FechaRegistro" DataFormatString="{0:M/d/yyyy}" HeaderText="Fecha Registro" />
                    <asp:BoundField DataField="FechaInicioReserva" DataFormatString="{0:M/d/yyyy}" HeaderText="Inicio Reserva" />
                    <asp:BoundField DataField="FechaFinReserva" DataFormatString="{0:M/d/yyyy}" HeaderText="Fin Reserva" />
                    <asp:BoundField DataField="FechaIngreso" DataFormatString="{0:M/d/yyyy}" HeaderText="Fecha Ingreso" Visible="False" />
                    <asp:BoundField DataField="FechaSalida" HeaderText="Fecha Salida" Visible="False" />
                    <asp:BoundField DataField="IdCliente" HeaderText="IdCliente" Visible="False" />
                    <asp:BoundField DataField="IdEstadoReserva" HeaderText="IdEstadoReserva" Visible="False" />
                    <asp:BoundField DataField="IdHabitacion" HeaderText="IdHabitacion" Visible="False" />
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>
