<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioReceta.aspx.cs" Inherits="Recetario.FormularioReceta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recetario</title>
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
                    <span class="alert alert-primary m-0 p-2 px-4 text-uppercase float-start">Informacion receta</span>
                    <a href="FormularioMenu.aspx" class="btn btn-outline-dark float-end me-3">Menu</a>
                    <a href="FormularioMenu.aspx" class="btn btn-outline-dark float-end me-3">Plato</a>
                    <a href="FormularioReceta.aspx" class="btn btn-outline-dark float-end me-3">Receta</a>
                   
                </div>

            </div>

            <div class="row justify-content-between mt-5">

                <div class="col-7 border border-primary p-3">
                    <div class="row">
                        <div class="col">
                            <asp:Label ID="lblFuente" runat="server" CssClass="form-label" Text="Fuente"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtFuente" runat="server"></asp:TextBox>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblUbicacionFisica" runat="server" CssClass="form-label" Text="Ubicación Fisica"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtUbicacionFisica" runat="server"></asp:TextBox>  
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <asp:Label ID="Label1" runat="server" CssClass="form-label" Text="Lista de ingrediente"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtIngrediente" runat="server"></asp:TextBox>
                        </div>
                        <div class="col">
                            <asp:Label ID="Label2" runat="server" CssClass="form-label" Text="Utensilios"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtUtensilios" runat="server"></asp:TextBox>  
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <asp:Label ID="Label3" runat="server" CssClass="form-label" Text="Comentario"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtComentario" runat="server"></asp:TextBox>
                        </div>
                        <div class="col">
                            <asp:Label ID="Label4" runat="server" CssClass="form-label" Text="Tiempo de preparación"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtTiempo" runat="server"></asp:TextBox>  
                        </div>
                    </div>
                    <div class="col-6">
                        <asp:Button ID="btnAgregar" OnClick="btnAgregar_Click" CssClass="btn btn-outline-primary" runat="server" Text="Agregar" />
                    </div>
                </div>
                
                <div class="col-4 border border-primary p-3">

                    <asp:Label ID="lblCodRecetaEmpty" runat="server" Text=""></asp:Label>
                    <asp:TextBox CssClass="form-control my-2" ID="txtCodReceta" runat="server"></asp:TextBox> 

                    <div class="d-grid gap-3 d-md-block float-end">
                        <asp:Button ID="btnModificar" OnClick="btnAgregar_Click" CssClass="btn btn-outline-warning" runat="server" Text="Editar" Enabled="False" />
                        <asp:Button ID="Button2" OnClick="btnEliminar_Click" CssClass="btn btn-outline-danger" runat="server" Text="Eliminar" />
                        <asp:Button ID="btnConsultar" OnClick="btnConsultar_Click" CssClass="btn btn-outline-success" runat="server" Text="Consultar" />
                    </div>

                </div>

            </div>

            <div class="row">

                <div class="col-12 border border-primary my-3 p-3">

                    <asp:DataGrid ID="gvMostrar" CssClass="table table-bordered table-hover table-striped mt-3 text-center text-secondary" runat="server"></asp:DataGrid>

                </div>

            </div>

        </form>

    </div>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
