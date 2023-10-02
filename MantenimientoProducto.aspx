<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MantenimientoProducto.aspx.cs" Inherits="WebApplicationMantenimientoProductos.MantenimientoProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">

            <div class="row">
                <div class="col-12">
                    <asp:Label ID="Lbl_Mensaje" runat="server" Text="Label"></asp:Label>
                </div>
            </div>

            <div class="row">
                <div class="col-2">
                    <div class="mb-3">
                        <asp:Label ID="Label1" runat="server" Text="ID producto:" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="Txt_ProductoId" runat="server" type="number" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-4">
                    <div class="mb-3">
                        <asp:Label ID="Label2" runat="server" Text="Nombre:" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="Txt_Nombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-3">
                    <div class="mb-3">
                        <asp:Label ID="Label3" runat="server" Text="Precio:" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="Txt_Precio" runat="server" type="number" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-12">
                    <div class="btn-group">
                        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn btn-info" OnClick="Btn_Consultar_Click" />
                        <asp:Button ID="Btn_Agregar" runat="server" Text="Añadir" CssClass="btn btn-primary" OnClick="Btn_Agregar_Click" />
                        <asp:Button ID="Btn_Modificar" runat="server" Text="Modificar" CssClass="btn btn-warning" />
                        <asp:Button ID="Btn_Descontinuar" runat="server" Text="Descontinuar" CssClass="btn btn-danger" />
                        <asp:Button ID="Btn_Grabar" runat="server" Text="Grabar" CssClass="btn btn-success" OnClick="Btn_Grabar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
