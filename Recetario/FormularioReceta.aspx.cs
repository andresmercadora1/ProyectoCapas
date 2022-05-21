using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
using System.Data;
using System.Data.SqlClient;

namespace Recetario
{
    public partial class FormularioReceta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarReceta();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                return;
            }

            CEReceta oCeRecetaAdd = new CEReceta();
            CNReceta oCnRecetaAdd = new CNReceta();

            oCeRecetaAdd.Fuente_receta = txtFuente.Text;
            oCeRecetaAdd.Ubicacion_fisica_receta = txtUbicacionFisica.Text;
            oCeRecetaAdd.Lista_ingredientes_receta = txtIngrediente.Text;
            oCeRecetaAdd.Utensilios_receta = txtUtensilios.Text;
            oCeRecetaAdd.Comentario_receta = txtComentario.Text;
            oCeRecetaAdd.Tiempo_receta = Convert.ToDateTime(txtTiempo.Text);

            if (!txtCodReceta.Text.Equals(""))
            {
                oCeRecetaAdd.Cod_receta = Convert.ToInt32(txtCodReceta.Text);
                if (oCnRecetaAdd.modificar_receta(oCeRecetaAdd))
                {

                    lblResultado.CssClass = "alert alert-info d-block";
                    lblResultado.Text = "Receta actualizada correctamente";
                    clearCampos();
                    txtFuente.CssClass = "form-control my-2";
                    txtIngrediente.CssClass = "form-control my-2";
                    txtIngrediente.CssClass = "form-control my-2";
                    txtUtensilios.CssClass = "form-control my-2";
                    txtComentario.CssClass = "form-control my-2";
                    txtTiempo.CssClass = "form-control my-2";
                    txtUbicacionFisica.CssClass = "form-control my-2";
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    clearCampos();
                    mostrarReceta();
                }
            }
            else
            {
                if (oCnRecetaAdd.guardar_receta(oCeRecetaAdd))
                {

                    lblResultado.CssClass = "alert alert-info d-block";
                    lblResultado.Text = "Receta agregada correctamente";
                    clearCampos();
                    txtFuente.CssClass = "form-control my-2";
                    txtIngrediente.CssClass = "form-control my-2";
                    txtIngrediente.CssClass = "form-control my-2";
                    txtUtensilios.CssClass = "form-control my-2";
                    txtComentario.CssClass = "form-control my-2";
                    txtTiempo.CssClass = "form-control my-2";
                    txtUbicacionFisica.CssClass = "form-control my-2";;
                    mostrarReceta();
                }
            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (validarCodReceta())
            {
                return;
            }

            DataSet ds = consultarReceta();

            if (ds == null)
            {
                return;
            }

            txtFuente.Text = ds.Tables[0].Rows[0]["fuente_receta"].ToString();
            txtUbicacionFisica.Text = ds.Tables[0].Rows[0]["ubicacion_fisica_receta"].ToString();
            txtIngrediente.Text = ds.Tables[0].Rows[0]["lista_ingredientes_receta"].ToString();
            txtUtensilios.Text = ds.Tables[0].Rows[0]["utensilios_receta"].ToString();
            txtComentario.Text = ds.Tables[0].Rows[0]["comentario_receta"].ToString();
            txtTiempo.Text = ds.Tables[0].Rows[0]["tiempo_receta"].ToString();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarCodReceta())
            {
                return;
            }

            DataSet ds = consultarReceta();

            if (ds == null)
            {
                return;
            }

            CEReceta oCeRecetaDelete = new CEReceta();
            CNReceta oCnRecetaDelete = new CNReceta();
            oCeRecetaDelete.Cod_receta = Convert.ToInt32(txtCodReceta.Text);

            if (oCnRecetaDelete.eliminar_receta(oCeRecetaDelete))
            {
                lblCodRecetaEmpty.CssClass = "alert alert-info d-block";
                lblCodRecetaEmpty.Text = "La receta se elimino correctamente";
                mostrarReceta();
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
            }
            else
            {
                lblCodRecetaEmpty.CssClass = "alert alert-danger";
                lblCodRecetaEmpty.Text = "No se pudo elimino la receta";
            }

        }


        public void mostrarReceta()
        {
            CNReceta objGetReceta = new CNReceta();
            gvMostrar.DataSource = objGetReceta.mostrar_receta();
            gvMostrar.DataBind();
        }

        public void clearCampos()
        {
            txtFuente.Text = null;
            txtUbicacionFisica.Text = null;
            txtIngrediente.Text = null;
            txtUtensilios.Text = null;
            txtComentario.Text = null;
            txtTiempo.Text = null;
            lblError.CssClass = "";
            lblError.Text = "";
        }

        public bool validarCampos()
        {
            if (
                txtFuente.Text.Equals("") ||
                txtUbicacionFisica.Text.Equals("") ||
                txtIngrediente.Text.Equals("") ||
                txtUtensilios.Text.Equals("") ||
                txtComentario.Text.Equals("") ||
                txtTiempo.Text.Equals("")
            )
            {
                txtFuente.CssClass = "border border-danger form-control my-2";
                txtIngrediente.CssClass = "border border-danger form-control my-2";
                txtIngrediente.CssClass = "border border-danger form-control my-2";
                txtUtensilios.CssClass = "border border-danger form-control my-2";
                txtComentario.CssClass = "border border-danger form-control my-2";
                txtTiempo.CssClass = "border border-danger form-control my-2";
                txtUbicacionFisica.CssClass = "border border-danger form-control my-2";
                lblResultado.CssClass = "";
                lblResultado.Text = "";
                return true;
            }

            return false;
        }

        public bool validarCodReceta()
        {
            if (txtCodReceta.Text.Equals(""))
            {
                lblCodRecetaEmpty.CssClass = "alert alert-danger d-block";
                lblCodRecetaEmpty.Text = "Debes ingresar un codigo de receta";
                lblResultado.CssClass = "";
                lblResultado.Text = "";
                return true;
            }
            else
            {
                lblCodRecetaEmpty.CssClass = "";
                lblCodRecetaEmpty.Text = "";
                return false;
            }
        }

        public DataSet consultarReceta()
        {
            CEReceta oCeRecetaRead = new CEReceta();
            CNReceta oCnRecetaRead = new CNReceta();

            DataSet ds = new DataSet();
            oCeRecetaRead.Cod_receta = Convert.ToInt32(txtCodReceta.Text);
            ds = oCnRecetaRead.consultar_receta(oCeRecetaRead);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblCodRecetaEmpty.CssClass = "alert alert-danger d-block";
                lblCodRecetaEmpty.Text = "No hay una receta con ese codigo";
                return null;
            }

            return ds;
        }

    }
}