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
    public class CDMenu
    {
        Conexion objConexion = new Conexion();
        SqlCommand objCommand = new SqlCommand();

        public bool guardar_menu(CEMenu objMenu)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "agregar_menu";
                objCommand.Parameters.AddWithValue("@cod_receta", objMenu.Cod_receta);
                objCommand.Parameters.AddWithValue("@nombre_menu", objMenu.Nombre_menu);
                objCommand.Parameters.AddWithValue("@precio_menu", objMenu.Precio_menu);
                objCommand.Parameters.AddWithValue("@comentario_menu", objMenu.Comentario_menu);
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool modificar_menu(CEMenu objMenu)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "modificar_menu";
                objCommand.Parameters.AddWithValue("@cod_menu", objMenu.Cod_menu);
                objCommand.Parameters.AddWithValue("@cod_receta", objMenu.Cod_receta);
                objCommand.Parameters.AddWithValue("@nombre_menu", objMenu.Nombre_menu);
                objCommand.Parameters.AddWithValue("@precio_menu", objMenu.Precio_menu);
                objCommand.Parameters.AddWithValue("@comentario_menu", objMenu.Comentario_menu);
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool eliminar_menu(CEMenu objMenu)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "eliminar_menu";
                objCommand.Parameters.AddWithValue("@cod_menu", objMenu.Cod_menu);
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public DataSet consultar_menu(CEMenu objMenu)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "consultar_menu";
                objCommand.Parameters.AddWithValue("@cod_menu", objMenu.Cod_menu);
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

        public DataTable mostrar_menu()
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBRecetario");
                objCommand.CommandText = "mostrar_menu";
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
