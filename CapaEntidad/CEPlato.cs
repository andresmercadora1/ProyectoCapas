using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEPlato
    {
		private int cod_plato;
		private int cod_receta;
		private string tipo_plato;
		private string ingredientes_principal_plato;
		private double precio_plato;
		private string comentario_adicional_plato;
		private string nombre_plato;
		private string calorias_plato;
		private double cant_util_ing_por_plato;
		private string unidad_medida_por_plato;
		private byte activo;

        public int Cod_plato { get => cod_plato; set => cod_plato = value; }
        public int Cod_receta { get => cod_receta; set => cod_receta = value; }
        public string Tipo_plato { get => tipo_plato; set => tipo_plato = value; }
        public string Ingredientes_principal_plato { get => ingredientes_principal_plato; set => ingredientes_principal_plato = value; }
        public double Precio_plato { get => precio_plato; set => precio_plato = value; }
        public string Comentario_adicional_plato { get => comentario_adicional_plato; set => comentario_adicional_plato = value; }
        public string Nombre_plato { get => nombre_plato; set => nombre_plato = value; }
        public string Calorias_plato { get => calorias_plato; set => calorias_plato = value; }
        public double Cant_util_ing_por_plato { get => cant_util_ing_por_plato; set => cant_util_ing_por_plato = value; }
        public string Unidad_medida_por_plato { get => unidad_medida_por_plato; set => unidad_medida_por_plato = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
