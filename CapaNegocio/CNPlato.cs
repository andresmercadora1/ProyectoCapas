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
   public class CNPlato
    {
        CDPlato objDPlato = new CDPlato();
        public bool guardar_plato(CEPlato objplato)
        {
            return objDPlato.guardar_plato(objplato);
        }

        public bool modificar_plato(CEPlato objplato)
        {
            return objDPlato.modificar_plato(objplato);
        }


        public bool eliminar_plato(CEPlato objplato)
        {
            return objDPlato.eliminar_plato(objplato);
        }

        public DataSet consultar_plato(CEPlato objplato)
        {
            return objDPlato.consultar_plato(objplato);
        }
        public DataTable mostrar_plato()
        {
            return objDPlato.mostrar_plato();
        }

    }
}
