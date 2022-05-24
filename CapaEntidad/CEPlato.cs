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
		private string ingredientes_principal;
		private double precio;
		private string comentario;
		private string nombre;
		private string calorias;
		private double cant_ingredientes;
		private string porcion;
		private byte activo;

        public int Cod_plato { get => cod_plato; set => cod_plato = value; }
        public int Cod_receta { get => cod_receta; set => cod_receta = value; }
        public string Tipo_plato { get => tipo_plato; set => tipo_plato = value; }
        public string Ingredientes_principal { get => ingredientes_principal; set => ingredientes_principal = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Calorias { get => calorias; set => calorias = value; }
        public double Cant_ingredientes { get => cant_ingredientes; set => cant_ingredientes = value; }
        public string Porcion { get => porcion; set => porcion = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
