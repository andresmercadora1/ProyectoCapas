using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;


namespace CapaDatos
{
    public class CDPlato
    {
        Conexion objconexion = new Conexion();
        SqlCommand objcommand = new SqlCommand();

        public bool guardar_plato(CEPlato objplato)
        {
            try
            {
                objcommand.CommandType = CommandType.StoredProcedure;
                objcommand.Connection = objconexion.conectar("DBRecetario");
                objcommand.CommandText = "agregar_plato";
                objcommand.Parameters.AddWithValue("@cod_receta", objplato.Cod_receta);
                objcommand.Parameters.AddWithValue("@tipo_plato", objplato.Tipo_plato);
                objcommand.Parameters.AddWithValue("@ingredientes_principal_plato", objplato.Ingredientes_principal_plato);
                objcommand.Parameters.AddWithValue("@precio_plato", objplato.Precio_plato);
                objcommand.Parameters.AddWithValue("@comentario_adicional_plato", objplato.Comentario_adicional_plato);
                objcommand.Parameters.AddWithValue("@nombre_plato", objplato.Nombre_plato);
                objcommand.Parameters.AddWithValue("@calorias_plato", objplato.Calorias_plato);
                objcommand.Parameters.AddWithValue("@cant_util_ing_por_plato", objplato.Cant_util_ing_por_plato);
                objcommand.Parameters.AddWithValue("@unidad_medida_por_plato", objplato.Unidad_medida_por_plato);


                objcommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool modificar_plato(CEPlato objplato)
        {
            try
            {
                objcommand.CommandType = CommandType.StoredProcedure;
                objcommand.Connection = objconexion.conectar("DBRecetario");
                objcommand.CommandText = "modificar_plato";
                objcommand.Parameters.AddWithValue("@cod_plato", objplato.Cod_plato);
                objcommand.Parameters.AddWithValue("@cod_receta", objplato.Cod_receta);
                objcommand.Parameters.AddWithValue("@tipo_plato", objplato.Tipo_plato);
                objcommand.Parameters.AddWithValue("@ingredientes_principal_plato", objplato.Ingredientes_principal_plato);
                objcommand.Parameters.AddWithValue("@precio_plato", objplato.Precio_plato);
                objcommand.Parameters.AddWithValue("@comentario_adicional_plato", objplato.Comentario_adicional_plato);
                objcommand.Parameters.AddWithValue("@nombre_plato", objplato.Nombre_plato);
                objcommand.Parameters.AddWithValue("@calorias_plato", objplato.Calorias_plato);
                objcommand.Parameters.AddWithValue("@cant_util_ing_por_plato", objplato.Cant_util_ing_por_plato);
                objcommand.Parameters.AddWithValue("@unidad_medida_por_plato", objplato.Unidad_medida_por_plato);


                objcommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool eliminar_plato(CEPlato objplato)
        {
            try
            {
                objcommand.CommandType = CommandType.StoredProcedure;
                objcommand.Connection = objconexion.conectar("DBRecetario");
                objcommand.CommandText = "eliminar_plato";
                objcommand.Parameters.AddWithValue("@cod_plato", objplato.Cod_plato);
               

                objcommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet consultar_plato(CEPlato objplato)
        {
            try
            {
                objcommand.CommandType = CommandType.StoredProcedure;
                objcommand.Connection = objconexion.conectar("DBRecetario");
                objcommand.CommandText = "consultar_plato";
                objcommand.Parameters.AddWithValue("@cod_plato", objplato.Cod_plato);
                SqlDataAdapter dat = new SqlDataAdapter(objcommand);
                DataSet ds = new DataSet();
                dat.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable mostrar_plato()
        {
            try
            {
                objcommand.CommandType = CommandType.StoredProcedure;
                objcommand.Connection = objconexion.conectar("DBRecetario");
                objcommand.CommandText = "mostrar_plato";
                SqlDataReader leer = objcommand.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(leer);
                return tabla;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
