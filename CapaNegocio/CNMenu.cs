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
    public class CNMenu
    {
        CDMenu objDatMenu = new CDMenu();
        public bool guardar_menu(CEMenu objMenu)
        {
            return objDatMenu.guardar_menu(objMenu);
        }

        public bool modificar_menu(CEMenu objMenu)
        {
            return objDatMenu.modificar_menu(objMenu);
        }

        public bool eliminar_menu(CEMenu objMenu)
        {
            return objDatMenu.eliminar_menu(objMenu);
        }

        public DataSet consultar_menu(CEMenu objMenu)
        {
            return objDatMenu.consultar_menu(objMenu);
        }

        public DataTable mostrar_menu()
        {
            return objDatMenu.mostrar_menu();
        }
    }
}
