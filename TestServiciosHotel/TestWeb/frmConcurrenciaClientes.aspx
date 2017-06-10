<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmConcurrenciaClientes.aspx.cs" Inherits="TestWeb.frmConcurrenciaClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
            <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
            <asp:BoundField DataField="Pagado" HeaderText="R. Pagadas" />
            <asp:BoundField DataField="Anulado" HeaderText="R. Anuladas" />
            <asp:BoundField DataField="Reservado" HeaderText="R. Reservadas" />
            <asp:BoundField DataField="ApellidoMaterno" HeaderText="ApellidoMaterno" Visible="False" />
            <asp:BoundField DataField="ApellidoPaterno" HeaderText="ApellidoPaterno" Visible="False" />
            <asp:BoundField DataField="Correo" HeaderText="Correo" Visible="False" />
            <asp:BoundField DataField="Direccion" HeaderText="Direccion" Visible="False" />
            <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" Visible="False" />
            <asp:BoundField DataField="IdCliente" HeaderText="IdCliente" Visible="False" />
            <asp:BoundField DataField="IdTipoCliente" HeaderText="IdTipoCliente" Visible="False" />
            <asp:BoundField DataField="IdUbigeo" HeaderText="IdUbigeo" Visible="False" />
            <asp:BoundField DataField="NroDocumento" HeaderText="NroDocumento" Visible="False" />
            <asp:BoundField DataField="TelefonoCasa" HeaderText="TelefonoCasa" Visible="False" />
            <asp:BoundField DataField="TelefonoCelular" HeaderText="TelefonoCelular" Visible="False" />
        </Columns>
</asp:GridView>
</asp:Content>
