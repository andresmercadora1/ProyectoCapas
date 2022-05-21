using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CNReceta
    {
        CDReceta objDatReceta = new CDReceta();

        public bool guardar_receta(CEReceta objReceta)
        {
            return objDatReceta.guardar_receta(objReceta);
        }

        public bool modificar_receta(CEReceta objReceta)
        {
            return objDatReceta.modificar_receta(objReceta);
        }

        public bool eliminar_receta(CEReceta objReceta)
        {
            return objDatReceta.eliminar_receta(objReceta);
        }

        public DataSet consultar_receta(CEReceta objReceta)
        {
            return objDatReceta.consultar_receta(objReceta);
        }

        public DataTable mostrar_receta()
        {
            return objDatReceta.mostrar_receta();
        }
        public DataTable consultar_cod_receta()
        {
            return objDatReceta.consultar_cod_receta();
        }

    }
}
