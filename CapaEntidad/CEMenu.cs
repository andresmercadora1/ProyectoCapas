using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEMenu
    {
		private int cod_menu;
		private int cod_receta;
		private string nombre_menu;
		private double precio_menu;
		private string comentario_menu;
		private byte activo;

        public int Cod_menu { get => cod_menu; set => cod_menu = value; }
        public int Cod_receta { get => cod_receta; set => cod_receta = value; }
        public string Nombre_menu { get => nombre_menu; set => nombre_menu = value; }
        public double Precio_menu { get => precio_menu; set => precio_menu = value; }
        public string Comentario_menu { get => comentario_menu; set => comentario_menu = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
