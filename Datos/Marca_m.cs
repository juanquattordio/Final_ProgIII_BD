using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Marca_m
    {
        public static bool Acceso()
        {
            try
            {
                Conexion cx = new Conexion();
                cx.Abrir();

                cx.Cerrar();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable TraerActivos()
        {
            DataTable dtListaAll = new DataTable("Marca"); // creo una Tabla de datos
            string sql = "SELECT id_marca, nombre, descripcion, baja FROM marcas where baja='1'"; // le digo que datos buscar y los guardo ahí
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);
                SqlDataAdapter sqlData = new SqlDataAdapter(Cx.Comando()); // es una herramienta intermedia. Comando es una función que devuelve sqlCmd().
                sqlData.Fill(dtListaAll); //llena la lista con los datos que busco en la BD.
                return dtListaAll;

            }

            catch (Exception)
            {
                dtListaAll = null;

            }
            return dtListaAll;
        }

        public static int Guardar(int id_marca, string nombre, string descripcion, bool baja=true)
        {
            if (id_marca == 0)
            {
                string sql = "INSERT INTO marcas (nombre, descripcion, baja) VALUES (@nombre, @descripcion, @baja)"; //RETURNING id_marca
                    try
                {

                    Conexion Cx = new Conexion();
                    Cx.SetCommandoTexto();
                    Cx.SetSql(sql);

                    // Cx.sqlCmd.Parameters.AddWithValue("@nombre", pnombre);
                    Cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@descripcion", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@baja", DbType.Boolean);
                    Cx.sqlCmd.Parameters[0].Value = nombre;
                    Cx.sqlCmd.Parameters[1].Value = descripcion;
                    Cx.sqlCmd.Parameters[2].Value = baja;

                    Cx.Abrir();
                    int nro = Cx.sqlCmd.ExecuteNonQuery();
                    Cx.Cerrar();

                    return nro;


                }
                catch (Exception e)
                {
                    return 0;
                }
            }
            else
            {
                
                return Modificar(id_marca, nombre, descripcion, baja);


            }
        }

        private static int Modificar(int id_marca, string nombre, string descripcion, bool baja)
        {
            string sql = "Update marcas SET nombre = @nombre, descripcion = @descripcion, baja =@baja Where id_marca = @id"; //RETURNING id_marca
            try
            {

                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);

                Cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                Cx.sqlCmd.Parameters.Add("@descripcion", DbType.String);
                Cx.sqlCmd.Parameters.Add("@baja", DbType.Boolean);
                Cx.sqlCmd.Parameters.Add("@id", DbType.Int32);

                Cx.sqlCmd.Parameters[0].Value = nombre;
                Cx.sqlCmd.Parameters[1].Value = descripcion;
                Cx.sqlCmd.Parameters[2].Value = baja;
                Cx.sqlCmd.Parameters[3].Value = id_marca;


                Cx.Abrir();
                int nro = Cx.sqlCmd.ExecuteNonQuery();
                Cx.Cerrar();

                return nro;

            }
            catch (Exception e)
            {
                return 0;
            }
        }
    

        public static bool ValidarNombre(string nombre)
        {
            return true;
        }

        public static DataTable TraerTodos()
        {
            DataTable dtListaAll = new DataTable("Marca"); // creo una Tabla de datos
            string sql = "SELECT id_marca, nombre, descripcion, baja FROM marcas"; // le digo que datos buscar y los guardo ahí
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);
                SqlDataAdapter sqlData = new SqlDataAdapter(Cx.Comando()); // es una herramienta intermedia. Comando es una función que devuelve sqlCmd().
                sqlData.Fill(dtListaAll); //llena la lista con los datos que busco en la BD.
                return dtListaAll;

            }

            catch (Exception)
            {
                dtListaAll = null;

            }
            return dtListaAll;
        }
    }
}
