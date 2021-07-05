using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Proveedor_m
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
            DataTable dtListaAll = new DataTable("Proveedor"); // creo una Tabla de datos
            string sql = "SELECT id_proveedor, nombre, direccion, telefono, tipo_prov, cuit, ibb, DNI, baja FROM proveedores where baja='1'"; // le digo que datos buscar y los guardo ahí
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
            DataTable dtListaAll = new DataTable("Proveedor"); // creo una Tabla de datos
            string sql = "SELECT id_proveedor, nombre, direccion, telefono, tipo_prov, cuit, ibb, DNI, baja FROM proveedores"; // le digo que datos buscar y los guardo ahí
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
        public static int Guardar(int id_prov, string nombre,string direccion,string telefono,string tipo_prov,string cuit,string ibb,string dni, bool baja=true)
        {
            if (id_prov == 0)
            {
                string sql = "INSERT INTO proveedores (nombre, direccion, telefono, tipo_prov, cuit, ibb, DNI, baja) VALUES (@nombre, @direccion, @telefono, @tipo_prov, @cuit, @ibb, @DNI, @baja)"; //RETURNING id_prov
                try
                {

                    Conexion Cx = new Conexion();
                    Cx.SetCommandoTexto();
                    Cx.SetSql(sql);

                    // Cx.sqlCmd.Parameters.AddWithValue("@nombre", pnombre);
                    Cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@direccion", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@telefono", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@tipo_prov", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@cuit", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@ibb", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@DNI", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@baja", DbType.Boolean);
                    Cx.sqlCmd.Parameters[0].Value = nombre;
                    Cx.sqlCmd.Parameters[1].Value = direccion;
                    Cx.sqlCmd.Parameters[2].Value = telefono;
                    Cx.sqlCmd.Parameters[3].Value = tipo_prov;
                    Cx.sqlCmd.Parameters[4].Value = cuit;
                    Cx.sqlCmd.Parameters[5].Value = ibb;
                    Cx.sqlCmd.Parameters[6].Value = dni;
                    Cx.sqlCmd.Parameters[7].Value = baja;

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

                return Modificar(id_prov, nombre, direccion, telefono, tipo_prov, cuit, ibb, dni, baja);


            }
        }

        private static int Modificar(int id_prov, string nombre, string direccion, string telefono, string tipo_prov, string cuit, string ibb, string dni, bool baja)
        {
            string sql = "Update proveedores SET nombre = @nombre, direccion=@direccion, telefono=@telefono, tipo_prov=@tipo_prov, cuit=@cuit, ibb=@ibb, DNI=@DNI, baja=@baja Where id_proveedor = @id"; //RETURNING id_marca
            try
            {

                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);

                Cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                Cx.sqlCmd.Parameters.Add("@direccion", DbType.String);
                Cx.sqlCmd.Parameters.Add("@telefono", DbType.String);
                Cx.sqlCmd.Parameters.Add("@tipo_prov", DbType.String);
                Cx.sqlCmd.Parameters.Add("@cuit", DbType.String);
                Cx.sqlCmd.Parameters.Add("@ibb", DbType.String);
                Cx.sqlCmd.Parameters.Add("@DNI", DbType.String);
                Cx.sqlCmd.Parameters.Add("@baja", DbType.Boolean);
                Cx.sqlCmd.Parameters.Add("@id", DbType.Int32);

                Cx.sqlCmd.Parameters[0].Value = nombre;
                Cx.sqlCmd.Parameters[1].Value = direccion;
                Cx.sqlCmd.Parameters[2].Value = telefono;
                Cx.sqlCmd.Parameters[3].Value = tipo_prov;
                Cx.sqlCmd.Parameters[4].Value = cuit;
                Cx.sqlCmd.Parameters[5].Value = ibb;
                Cx.sqlCmd.Parameters[6].Value = dni;
                Cx.sqlCmd.Parameters[7].Value = baja;
                Cx.sqlCmd.Parameters[8].Value = id_prov;


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
        public static bool ValidarDatos (string cuit, string ibb)
        {
            return true;
        }





    }
}
