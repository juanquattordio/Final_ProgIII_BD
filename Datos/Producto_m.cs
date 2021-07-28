using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto_m
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
            DataTable dtListaAll = new DataTable("Producto"); // creo una Tabla de datos
            string sql = "SELECT id_prod, nombre, descripcion, baja FROM productos where baja='1'"; // le digo que datos buscar y los guardo ahí
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
        public static DataTable TraerTodos()
        {
            DataTable dtListaAll = new DataTable("Producto"); // creo una Tabla de datos
            string sql = "SELECT id_prod, nombre, descripcion, baja FROM productos"; // le digo que datos buscar y los guardo ahí
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
        public static int Guardar(int id_prod, string nombre, string descripcion, bool baja = true)
        {
            if (id_prod == 0)
            {
                string sql = "INSERT INTO productos (nombre, descripcion, baja) VALUES (@nombre, @descripcion, @baja)"; //RETURNING id_prod
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

                return Modificar(id_prod, nombre, descripcion, baja);


            }
        }
        private static int Modificar(int id_prod, string nombre, string descripcion, bool baja)
        {
            string sql = "Update productos SET nombre = @nombre, descripcion = @descripcion, baja = @baja Where id_prod = @id"; //RETURNING id_prod
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
                Cx.sqlCmd.Parameters[3].Value = id_prod;


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
        public static bool ValidarDatos (int id_prod)
        {
            return true;
        }
    }
}
