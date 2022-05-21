using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;

namespace Recetario
{
    public partial class MenuFormulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarSelect();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        public void llenarSelect()
        {
            CEMenu oCeMenu = new CEMenu();
            CEReceta oCeReceta= new CEReceta();
            CNReceta oCnReceta= new CNReceta();
            DropDownList1.DataSource = oCnReceta.consultar_cod_receta();
            DropDownList1.DataTextField = "cod_receta";
            DropDownList1.DataValueField = "cod_receta";
            DropDownList1.DataBind();
        }
    }
}