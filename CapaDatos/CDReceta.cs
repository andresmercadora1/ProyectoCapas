using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDReceta
    {
        Conexion objConexion = new Conexion();
        SqlCommand objCommand = new SqlCommand();

        public bool guardar_receta(CEReceta objReceta)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "agregar_receta";
                objCommand.Parameters.AddWithValue("@fuente_receta", objReceta.Fuente_receta);
                objCommand.Parameters.AddWithValue("@ubicacion_fisica_receta", objReceta.Ubicacion_fisica_receta);
                objCommand.Parameters.AddWithValue("@lista_ingredientes_receta", objReceta.Lista_ingredientes_receta);
                objCommand.Parameters.AddWithValue("@utensilios_receta", objReceta.Utensilios_receta);
                objCommand.Parameters.AddWithValue("@comentario_receta", objReceta.Comentario_receta);
                objCommand.Parameters.AddWithValue("@tiempo_receta", objReceta.Tiempo_receta);
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool modificar_receta(CEReceta objReceta)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "modificar_receta";
                objCommand.Parameters.AddWithValue("@cod_receta", objReceta.Cod_receta);
                objCommand.Parameters.AddWithValue("@fuente_receta", objReceta.Fuente_receta);
                objCommand.Parameters.AddWithValue("@ubicacion_fisica_receta", objReceta.Ubicacion_fisica_receta);
                objCommand.Parameters.AddWithValue("@lista_ingredientes_receta", objReceta.Lista_ingredientes_receta);
                objCommand.Parameters.AddWithValue("@utensilios_receta", objReceta.Utensilios_receta);
                objCommand.Parameters.AddWithValue("@comentario_receta", objReceta.Comentario_receta);
                objCommand.Parameters.AddWithValue("@tiempo_receta", objReceta.Tiempo_receta);
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool eliminar_receta(CEReceta objReceta)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "eliminar_receta";
                objCommand.Parameters.AddWithValue("@cod_receta", objReceta.Cod_receta);
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public DataSet consultar_receta(CEReceta objReceta)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "consultar_receta";
                objCommand.Parameters.AddWithValue("@cod_receta", objReceta.Cod_receta);
                SqlDataAdapter dat = new SqlDataAdapter(objCommand);
                DataSet ds = new DataSet();
                dat.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public DataTable mostrar_receta()
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "mostrar_receta";
                SqlDataReader leer = objCommand.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(leer);
                return tabla;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public DataTable consultar_cod_receta()
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "consultar_cod_receta";
                SqlDataReader leer = objCommand.ExecuteReader();
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
