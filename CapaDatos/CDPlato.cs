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
                objcommand.Parameters.AddWithValue("@ingredientes_principal", objplato.Ingredientes_principal);
                objcommand.Parameters.AddWithValue("@precio", objplato.Precio);
                objcommand.Parameters.AddWithValue("@comentario", objplato.Comentario);
                objcommand.Parameters.AddWithValue("@nombre", objplato.Nombre);
                objcommand.Parameters.AddWithValue("@calorias", objplato.Calorias);
                objcommand.Parameters.AddWithValue("@cant_ingredientes", objplato.Cant_ingredientes);
                objcommand.Parameters.AddWithValue("@porcion", objplato.Porcion);


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
                objcommand.Parameters.AddWithValue("@ingredientes_principal", objplato.Ingredientes_principal);
                objcommand.Parameters.AddWithValue("@precio", objplato.Precio);
                objcommand.Parameters.AddWithValue("@comentario", objplato.Comentario);
                objcommand.Parameters.AddWithValue("@nombre", objplato.Nombre);
                objcommand.Parameters.AddWithValue("@calorias", objplato.Calorias);
                objcommand.Parameters.AddWithValue("@cant_ingredientes", objplato.Cant_ingredientes);
                objcommand.Parameters.AddWithValue("@porcion", objplato.Porcion);


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
