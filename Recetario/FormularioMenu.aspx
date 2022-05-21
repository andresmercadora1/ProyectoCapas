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

                    <a href="FormularioMenu.aspx" class="btn btn-outline-dark float-end me-3">Menu</a>
                    <a href="FormularioMenu.aspx" class="btn btn-outline-dark float-end me-3">Plato</a>
                    <a href="FormularioReceta.aspx" class="btn btn-outline-dark float-end me-3">Receta</a>
                   
                </div>

            </div>

            <div class="row justify-content-between mt-5">

                <div class="col-7 border border-primary p-3">
                    <div class="row">
                        <div class="col">
                            <asp:Label ID="lblFuente" runat="server" CssClass="form-label" Text="Código receta"></asp:Label>
                            <asp:DropDownList ID="DropDownList1" CssClass="form-control my-2" runat="server">
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
                        <asp:Button ID="btnAgregar" CssClass="btn btn-outline-primary" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    </div>
                </div>

            </div>

            <div class="row">

             

            </div>

        </form>

    </div>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
