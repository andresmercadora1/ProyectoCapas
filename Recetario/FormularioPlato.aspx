<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioPlato.aspx.cs" Inherits="Recetario.FormularioPlato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
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
                    <span class="alert alert-primary m-0 p-2 px-4 text-uppercase float-start">Informacion Plato</span>
                    <a href="FormularioMenu.aspx" class="btn btn-outline-dark float-end me-3">Menu</a>
                    <a href="FormularioPlato.aspx" class="btn btn-outline-dark float-end me-3">Plato</a>
                    <a href="FormularioReceta.aspx" class="btn btn-outline-dark float-end me-3">Receta</a>
                   
                </div>

            </div>

            <div class="row justify-content-between mt-5">

                <div class="col-7 border border-primary p-3">
                    <div class="row">
                        <div class="col">
                            <asp:Label ID="lblFuente" runat="server" CssClass="form-label" Text="Código Receta"></asp:Label>
                            <asp:DropDownList ID="ddlCodReceta" AutoPostBack="false"  CssClass="form-control my-2" runat="server">
                            </asp:DropDownList>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblUbicacionFisica" runat="server" CssClass="form-label" Text="Tipo de Plato"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtTipoPlato" runat="server"></asp:TextBox>  
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <asp:Label ID="lblPrecio" runat="server" CssClass="form-label" Text="Ingredientes Principales"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtIngredietes" runat="server"></asp:TextBox>
                        </div>
                        <div class="col">
                            <asp:Label ID="Label4" runat="server" CssClass="form-label" Text="Precio del Plato"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtprecio" runat="server"></asp:TextBox>  
                        </div>
                     
                    </div>

                    <div class="row">
                         <div class="col">
                            <asp:Label ID="lblComentario" runat="server" CssClass="form-label" Text="Comentario del Plato"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtComentario" runat="server"></asp:TextBox>  
                        </div>
                        <div class="col">
                            <asp:Label ID="Label1" runat="server" CssClass="form-label" Text="Nombre del Plato"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtnombre" runat="server"></asp:TextBox>
                        </div>
                        
                    </div>
                    <div class="row">
                        <div class="col">
                            <asp:Label ID="Label2" runat="server" CssClass="form-label" Text="Calorias de Plato"></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtcalorias" runat="server"></asp:TextBox>  
                        </div>
                        <div class="col">
                            <asp:Label ID="Label3" runat="server" CssClass="form-label" Text="Cantida de ingredientes por Plato "></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtcaningP" runat="server"></asp:TextBox>
                        </div>
                        
                    </div>

                    <div class="row">
                        <div class="col">
                            <asp:Label ID="Label5" runat="server" CssClass="form-label" Text="Porción del Plato "></asp:Label>
                            <asp:TextBox CssClass="form-control my-2" ID="txtPorcion" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-6">
                        <asp:Button ID="btnAgregarPlato" CssClass="btn btn-outline-primary" runat="server" Text="Agregar" OnClick="btnAgregarPlato_Click" />
                    </div>
                </div>

                <div class="col-4 border border-primary p-3">

                    <asp:Label ID="lblCodPlatoEmpty" runat="server" Text=""></asp:Label>
                    <asp:TextBox CssClass="form-control my-2" ID="txtcodPlato" runat="server"></asp:TextBox> 

                    <div class="d-grid gap-3 d-md-block float-end">
                        <asp:Button ID="btnModificarPlato" CssClass="btn btn-outline-warning" runat="server" Text="Editar" OnClick="btnAgregarPlato_Click" Enabled="False" />
                        <asp:Button ID="btnEliminarPlato" CssClass="btn btn-outline-danger" runat="server" Text="Eliminar" OnClick="btnEliminarPlato_Click" />
                        <asp:Button ID="btnConsultarPlato" CssClass="btn btn-outline-success" runat="server" Text="Consultar" OnClick="btnConsultarPlato_Click" />
                    </div>

                </div>

            </div>

            <div class="row">

                <div class="col-12 border border-primary my-3 p-3">

                    <asp:DataGrid ID="gvMostrarPlato" CssClass="table table-bordered table-hover table-striped mt-3 text-center text-secondary" runat="server"></asp:DataGrid>

                </div>

            </div>

        </form>

    </div>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
