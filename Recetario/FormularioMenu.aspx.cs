using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace Recetario
{
    public partial class MenuFormulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarSelect();
            mostrarMenu();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                return;
            }

            CEMenu oCeMenu = new CEMenu();
            CNMenu oCnMenu = new CNMenu();

            oCeMenu.Cod_receta = Convert.ToInt32(ddlCodReceta.SelectedValue);
            oCeMenu.Nombre_menu = txtNombre.Text;
            oCeMenu.Precio_menu = Convert.ToDouble(txtPrecio.Text);
            oCeMenu.Comentario_menu = txtComentario.Text;

            if(!txtCodMenu.Text.Equals(""))
            {
                oCeMenu.Cod_menu = Convert.ToInt32(txtCodMenu.Text);
                if (oCnMenu.modificar_menu(oCeMenu))
                {

                    lblResultado.CssClass = "alert alert-info d-block";
                    lblResultado.Text = "Receta actualizada correctamente";
                    clearCampos();
                    ddlCodReceta.CssClass = "form-control my-2";
                    txtNombre.CssClass = "form-control my-2";
                    txtPrecio.CssClass = "form-control my-2";
                    txtComentario.CssClass = "form-control my-2";
                    btnAgregarMenu.Enabled = true;
                    btnModificarMenu.Enabled = false;
                    clearCampos();
                    mostrarMenu();
                }
            } else
            {
                if (oCnMenu.guardar_menu(oCeMenu))
                {
                    lblResultado.CssClass = "alert alert-info d-block";
                    lblResultado.Text = "Receta agregada correctamente";
                    clearCampos();
                    ddlCodReceta.CssClass = "form-control my-2";
                    txtNombre.CssClass = "form-control my-2";
                    txtPrecio.CssClass = "form-control my-2";
                    txtComentario.CssClass = "form-control my-2";
                    mostrarMenu();
                }
            }
        }

        protected void btnConsultarMenu_Click(object sender, EventArgs e)
        {
            if (validarCodMenu())
            {
                return;
            }

            DataSet ds = consultarMenu();

            if (ds == null)
            {
                return;
            }


            ddlCodReceta.SelectedValue = ds.Tables[0].Rows[0]["cod_receta"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["nombre_menu"].ToString();
            txtPrecio.Text = ds.Tables[0].Rows[0]["precio_menu"].ToString();
            txtComentario.Text = ds.Tables[0].Rows[0]["comentario_menu"].ToString();
            btnAgregarMenu.Enabled = false;
            btnModificarMenu.Enabled = true;
          

        }

        public void mostrarMenu()
        {

            CNMenu objGetMenu = new CNMenu();
            gvMostrarMenu.DataSource = objGetMenu.mostrar_menu();
            gvMostrarMenu.DataBind();
        }

        public void clearCampos()
        {
            ddlCodReceta.SelectedValue = null;
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtComentario.Text = "";
        }

        public bool validarCampos()
        {
            if (
                ddlCodReceta.SelectedValue.Equals("") ||
                txtNombre.Text.Equals("") ||
                txtPrecio.Text.Equals("") ||
                txtComentario.Text.Equals("")
            )
            {
                ddlCodReceta.CssClass = "border border-danger form-control my-2";
                txtNombre.CssClass = "border border-danger form-control my-2";
                txtPrecio.CssClass = "border border-danger form-control my-2";
                txtComentario.CssClass = "border border-danger form-control my-2";
                lblResultado.Text = "";
                return true;
            }

            return false;
        }

        public void llenarSelect()
        {
            if(!IsPostBack){
                CEMenu oCeMenu = new CEMenu();
                CEReceta oCeReceta = new CEReceta();
                CNReceta oCnReceta = new CNReceta();
                ddlCodReceta.DataSource = oCnReceta.consultar_cod_receta();
                ddlCodReceta.DataTextField = "cod_receta";
                ddlCodReceta.DataValueField = "cod_receta";
                ddlCodReceta.DataBind();
            }
            
        }

        public bool validarCodMenu()
        {
            if (txtCodMenu.Text.Equals(""))
            {
                lblCodMenuEmpty.CssClass = "alert alert-danger d-block";
                lblCodMenuEmpty.Text = "Debes ingresar un codigo de menu";
                lblResultado.CssClass = "";
                lblResultado.Text = "";
                return true;
            }
            else
            {
                lblCodMenuEmpty.CssClass = "";
                lblCodMenuEmpty.Text = "";
                return false;
            }
        }

        public DataSet consultarMenu()
        {
            CEMenu oCeMenu = new CEMenu();
            CNMenu oCnMenu = new CNMenu();

            DataSet ds = new DataSet();
            oCeMenu.Cod_menu = Convert.ToInt32(txtCodMenu.Text);
            ds = oCnMenu.consultar_menu(oCeMenu);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblCodMenuEmpty.CssClass = "alert alert-danger d-block";
                lblCodMenuEmpty.Text = "No hay una menu con ese codigo";
                return null;
            }

            return ds;
        }

        protected void btnEliminarMenu_Click(object sender, EventArgs e)
        {
            if (validarCodMenu())
            {
                return;
            }

            DataSet ds = consultarMenu();

            if (ds == null)
            {
                return;
            }

            CEMenu oCeMenuDelete = new CEMenu();
            CNMenu oCnMenuDelete = new CNMenu();
            oCeMenuDelete.Cod_menu = Convert.ToInt32(txtCodMenu.Text);

            if (oCnMenuDelete.eliminar_menu(oCeMenuDelete))
            {
                lblCodMenuEmpty.CssClass = "alert alert-info d-block";
                lblCodMenuEmpty.Text = "La menu se elimino correctamente";
                mostrarMenu();
                btnAgregarMenu.Enabled = true;
                btnModificarMenu.Enabled = false;
            }
            else
            {
                lblCodMenuEmpty.CssClass = "alert alert-danger";
                lblCodMenuEmpty.Text = "No se pudo elimino la menu";
            }
        }
    }
}