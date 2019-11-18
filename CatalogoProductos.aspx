<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoProductos.aspx.cs" Inherits="TallerASP.NET.CatalogoProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery-3.4.1.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="IdProducto" Value="" runat="server" />

        <h1>Productos</h1>
        <div>
            Nombre: <asp:TextBox ID="NombreBox" runat="server" placeholder="nombre"/>
            <br />
            <br />
            Precio: <asp:TextBox ID="PrecioBox" runat="server" placeholder="precio"/>
            <br />
            <br />
            Stock: <asp:TextBox ID="StockBox" runat="server" placeholder="stock"/>
            <br />
            <br />
        </div>
        <div>
            <asp:Button ID="GuardarButton" Text="Guardar"  runat="server" OnClick="GuardarButton_Click" />
            <asp:Button ID="LimpiarButton" Text="Limpiar" runat="server" OnClick="LimpiarButton_Click" />
        </div>
        <div>
            <asp:GridView ID="ProductosGrid" runat="server"
                DataKeyNames="id, nombre, precio, stock"
                AllowPaging="false" AllowSorting="false" EnableViewState="true"
                AutoGenerateColumns="false" OnRowCommand="ProductosGrid_RowCommand">
                <EmptyDataTemplate>No se encuentran productos</EmptyDataTemplate>
                <Columns>
                    <asp:TemplateField HeaderText="NOMBRE">
                        <ItemTemplate>
                            <asp:LinkButton ID="ProductoLink" runat="server" 
                                CommandName="Seleccionar" 
                                CommandArgument="<%# Container.DataItemIndex %>" 
                                Text='<%# Eval("nombre") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="precio" HeaderText="PRECIO" />
                    <asp:BoundField DataField="stock" HeaderText="STOCK" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="DeleteButton" runat="server"
                                CommandName="Eliminar" 
                                CommandArgument="<%# Container.DataItemIndex %>"
                                Text="Remover"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
