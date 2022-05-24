<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioMenu.aspx.cs" Inherits="Recetario.MenuFormulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario Menu</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">

        <form id="form1" runat="server">
            <div class="row">
                <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </div>

            

            <div class="row">

                <div class="col-12 border border-primary p-2">
                    <span class="alert alert-primary m-0 p-2 px-4 text-uppercase float-start">Informacion menu</span>
                    <a href="FormularioMenu.aspx" class="btn btn-outline-dark float-end me-3">Menu</a>
                    <a href="FormularioPlato.aspx" class="btn btn-outline-dark float-end me-3">Plato</a>
                    <a href="FormularioReceta.aspx" class="btn btn-outline-dark float-end me-3">Receta</a>
                   
                </div>

            </div>

            <div class="row justify-content-between mt-5">

                <div class="col-7 border border-primary p-3">
                    <div class="row">
                        <div class="col">
                            <asp:Label ID="lblFuente" runat="server" CssClass="form-label" Text="Código receta"></asp:Label>
                            <asp:DropDownList ID="ddlCodReceta" AutoPostBack="false"  CssClass="form-control my-2" runat="server">
                            </asp:DropDownList>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblUbicacionFisica" runat="server" CssClass="form-label" Text="Nombre del plato del menu"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtNombre" runat="server"></asp:TextBox>  
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <asp:Label ID="lblPrecio" runat="server" CssClass="form-label" Text="Precio del menu"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtPrecio" runat="server"></asp:TextBox>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblComentario" runat="server" CssClass="form-label" Text="Comentario del menu"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtComentario" runat="server"></asp:TextBox>  
                        </div>
                    </div>

                    <div class="col-6">
                        <asp:Button ID="btnAgregarMenu" CssClass="btn btn-outline-primary" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    </div>
                </div>

                <div class="col-4 border border-primary p-3">

                    <asp:Label ID="lblCodMenuEmpty" runat="server" Text=""></asp:Label>
                    <asp:TextBox CssClass="form-control my-2" ID="txtCodMenu" runat="server"></asp:TextBox> 

                    <div class="d-grid gap-3 d-md-block float-end">
                        <asp:Button ID="btnModificarMenu" CssClass="btn btn-outline-warning" runat="server" Text="Editar" OnClick="btnAgregar_Click" Enabled="False" />
                        <asp:Button ID="FormularioPlato" CssClass="btn btn-outline-danger" runat="server" Text="Eliminar" OnClick="btnEliminarMenu_Click" />
                        <asp:Button ID="btnConsultarMenu" CssClass="btn btn-outline-success" runat="server" Text="Consultar" OnClick="btnConsultarMenu_Click" />
                    </div>

                </div>

            </div>

            <div class="row">

                <div class="col-12 border border-primary my-3 p-3">

                    <asp:DataGrid ID="gvMostrarMenu" CssClass="table table-bordered table-hover table-striped mt-3 text-center text-secondary" runat="server"></asp:DataGrid>

                </div>

            </div>

        </form>

    </div>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
