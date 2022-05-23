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
    public partial class FormularioPlato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarSelect();
            mostrarPlato();
        }

        protected void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                return;
            }

            CEPlato oCePlato = new CEPlato();
            CNPlato oCnPlato = new CNPlato();

            oCePlato.Tipo_plato = txtTipoPlato.Text;
            oCePlato.Cod_receta = Convert.ToInt32(ddlCodReceta.SelectedValue);
            oCePlato.Ingredientes_principal_plato = txtIngredietes.Text;
            oCePlato.Precio_plato = Convert.ToDouble(txtprecio.Text);
            oCePlato.Nombre_plato = txtnombre.Text;
            oCePlato.Calorias_plato = txtcalorias.Text;
            oCePlato.Cant_util_ing_por_plato = Convert.ToDouble(txtcaningP.Text);
            oCePlato.Unidad_medida_por_plato = (txtPorcion.Text);
            oCePlato.Comentario_adicional_plato = (txtComentario.Text);

            if (!txtcodPlato.Text.Equals(""))
            {
                oCePlato.Cod_plato = Convert.ToInt32(txtcodPlato.Text);
                if (oCnPlato.modificar_plato(oCePlato))
                {

                    lblResultado.CssClass = "alert alert-info d-block";
                    lblResultado.Text = "Plato actualizada correctamente";
                    clearCampos();
                    ddlCodReceta.CssClass = "form-control my-2";
                    txtTipoPlato.CssClass = "form-control my-2";
                    txtIngredietes.CssClass = "form-control my-2";
                    txtPorcion.CssClass = "form-control my-2";
                    txtComentario.CssClass = "form-control my-2";
                    txtnombre.CssClass = "form-control my-2";
                    txtcalorias.CssClass = "form-control my-2";
                    txtcaningP.CssClass = "form-control my-2";

                    btnAgregarPlato.Enabled = true;
                    btnModificarPlato.Enabled = false;
                    clearCampos();
                    mostrarPlato();
                }
            }
            else
            {
                if (oCnPlato.guardar_plato(oCePlato))
                {

                    lblResultado.CssClass = "alert alert-info d-block";
                    lblResultado.Text = "Receta agregada correctamente";
                    clearCampos();
                    txtTipoPlato.CssClass = "form-control my-2";
                txtIngredietes.CssClass = "form-control my-2";
                txtprecio.CssClass = "form-control my-2";
                txtnombre.CssClass = "form-control my-2";
                txtComentario.CssClass = "form-control my-2";
                txtcalorias.CssClass = "form-control my-2";
                txtcaningP.CssClass = "form-control my-2"; ;
                txtPorcion.CssClass = "form-control my-2"; ;
                    mostrarPlato();
                }
        }

    }

        public bool validarCampos()
        {
            if (
                txtTipoPlato.Text.Equals("") ||
                txtIngredietes.Text.Equals("") ||
                txtComentario.Text.Equals("") ||
                txtnombre.Text.Equals("") ||
                txtcalorias.Text.Equals("") ||
                txtcaningP.Text.Equals("") ||
                txtprecio.Text.Equals("") ||
                txtPorcion.Text.Equals("") 
            )
            {
                txtTipoPlato.CssClass = "border border-danger form-control my-2";
                txtIngredietes.CssClass = "border border-danger form-control my-2";
                txtComentario.CssClass = "border border-danger form-control my-2";
                txtcalorias.CssClass = "border border-danger form-control my-2";
                txtComentario.CssClass = "border border-danger form-control my-2";
                txtcaningP.CssClass = "border border-danger form-control my-2";
                txtprecio.CssClass = "border border-danger form-control my-2";
                txtPorcion.CssClass = "border border-danger form-control my-2";
                lblResultado.CssClass = "";
                lblResultado.Text = "";
                return true;
            }

            return false;
        }

        public void llenarSelect()
        {
            if (!IsPostBack)
            {
                CEMenu oCeMenu = new CEMenu();
                CEReceta oCeReceta = new CEReceta();
                CNReceta oCnReceta = new CNReceta();
                ddlCodReceta.DataSource = oCnReceta.consultar_cod_receta();
                ddlCodReceta.DataTextField = "cod_receta";
                ddlCodReceta.DataValueField = "cod_receta";
                ddlCodReceta.DataBind();
            }

        }

        protected void btnConsultarPlato_Click(object sender, EventArgs e)
        {

            if (validarCodPlato())
            {
                return;
            }

            DataSet ds = consultarPlato();

            if (ds == null)
            {
                return;
            }

            txtTipoPlato.Text = ds.Tables[0].Rows[0]["tipo_plato"].ToString();
            txtIngredietes.Text = ds.Tables[0].Rows[0]["ingredientes_principal_plato"].ToString();
            txtprecio.Text = ds.Tables[0].Rows[0]["precio_plato"].ToString();
            txtComentario.Text = ds.Tables[0].Rows[0]["comentario_adicional_plato"].ToString();
            txtnombre.Text = ds.Tables[0].Rows[0]["nombre_plato"].ToString();
            txtcalorias.Text = ds.Tables[0].Rows[0]["calorias_plato"].ToString();
            txtcaningP.Text = ds.Tables[0].Rows[0]["cant_util_ing_por_plato"].ToString();
            txtPorcion.Text = ds.Tables[0].Rows[0]["unidad_medida_por_plato"].ToString();
            btnAgregarPlato.Enabled = false;
            btnModificarPlato.Enabled = true;
        }
        public bool validarCodPlato()
        {
            if (txtcodPlato.Text.Equals(""))
            {
                lblCodPlatoEmpty.CssClass = "alert alert-danger d-block";
                lblCodPlatoEmpty.Text = "Debes ingresar un codigo de plato";
                lblResultado.CssClass = "";
                lblResultado.Text = "";
                return true;
            }
            else
            {
                lblCodPlatoEmpty.CssClass = "";
                lblCodPlatoEmpty.Text = "";
                return false;
            }
        }
        public DataSet consultarPlato()
        {
            CEPlato oCePlato = new CEPlato();
            CNPlato oCnPlato = new CNPlato();

            DataSet ds = new DataSet();
            oCePlato.Cod_plato = Convert.ToInt32(txtcodPlato.Text);
            ds = oCnPlato.consultar_plato(oCePlato);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblCodPlatoEmpty.CssClass = "alert alert-danger d-block";
                lblCodPlatoEmpty.Text = "No hay una plato con ese codigo";
                return null;
            }

            return ds;
        }

        protected void btnEliminarPlato_Click(object sender, EventArgs e)
        {
            if (validarCodPlato())
            {
                return;
            }

            DataSet ds = consultarPlato();

            if (ds == null)
            {
                return;
            }

            CEPlato oCePlatoDelete = new CEPlato();
            CNPlato oCnPlatoDelete = new CNPlato();
            oCePlatoDelete.Cod_plato = Convert.ToInt32(txtcodPlato.Text);

            if (oCnPlatoDelete.eliminar_plato(oCePlatoDelete))
            {
                lblCodPlatoEmpty.CssClass = "alert alert-info d-block";
                lblCodPlatoEmpty.Text = "La plato se elimino correctamente";
                mostrarPlato();
                btnAgregarPlato.Enabled = true;
                btnModificarPlato.Enabled = false;
            }
            else
            {
                lblCodPlatoEmpty.CssClass = "alert alert-danger";
                lblCodPlatoEmpty.Text = "No se pudo elimino la plato";
            }
        }

        public void clearCampos()
        {
            txtTipoPlato.Text = "";
                txtIngredietes.Text = "";
            txtComentario.Text = "";
            txtnombre.Text = "";
            txtcalorias.Text = "";
            txtcaningP.Text = "";
            txtprecio.Text = "";
            txtPorcion.Text = "";
        }

        public void mostrarPlato()
        {
            CNPlato objGetPlato = new CNPlato();
            gvMostrarPlato.DataSource = objGetPlato.mostrar_plato();
            gvMostrarPlato.DataBind();
        }
    }
}