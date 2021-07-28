using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Precio_m
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

        public static DataTable TraerActivos (int id_producto)
        {
            DataTable dtListaAll = new DataTable("Precios"); // creo una Tabla de datos
            string sql = "SELECT id_precio, id_prod, id_prov, nombre_prov, id_marca, nombre_marca, moneda_desc, precio_valor, precio_fecha, baja FROM precios where baja='1' and @id_prod=id_prod"; // le digo que datos buscar y los guardo ahí
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);
                Cx.sqlCmd.Parameters.Add("@id_prod", DbType.Int32);
                Cx.sqlCmd.Parameters[0].Value = id_producto;

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

        public static bool ValidarDatos()
        {
            return true;
            //{// ejecuto una consulta de seleccion
            //    string sql = "Select * from telefonos where codigo_area=" + codigo_area + " and telefono=" + telefono;
            //  // revisar SQL
            //    bool retorno = true;
            //    try // abro conexion
            //    {
            //        Conexion Cx = new Conexion();
            //        Cx.SetCommandoTexto();
            //        Cx.SetSql(sql);
            //        Cx.Abrir();
            //        SqlDataReader reader = Cx.sqlCmd.ExecuteReader(); // creo un reader, es un objeto que representa el resultado de la consulta de arriba
            //                                                          //La información que devuelve, no puedo almacenarla cono un DataSet, cuando cierro el Reader, cierra la conexión y la información de la consulta pierde.
            //        bool tieneFilas = !reader.HasRows;                                 //Tener en cuenta un métdo ExecuteNoReader(), ver qué me permite
            //        if (tieneFilas) // HasRows lee si el objeto Reader tiene filas. Lo niega (!) porque el 0 se toma como falso. Si reader.HasRow>0 quiere decir que existe el usuario y contraseña ingresados. Si es mayor que 0, lo toma como falso al agregarle el !
            //        {
            //            retorno = false; // si el reader es 0, lo evalúo como true y devuelvo falso.
            //        }
            //        reader.Close(); // debo cerrarlos porque 
            //                        // Cx.Cerrar(); si cierro el reader, se cierra el Cx.
            //    }
            //    catch (Exception e)
            //    {
            //        retorno = false;
            //    }
            //    return retorno;
            //}
        }
        public static int Guardar (int id_precio, int id_prod, int id_prov, string nombre_prov, int id_marca, string nombre_marca, string moneda_desc, int precio_valor, string precio_fecha, bool baja = true)
        {
            if (id_precio == 0)
            {
                string sql = "INSERT INTO precios (id_prod, id_prov, nombre_prov, id_marca, nombre_marca, moneda_desc, precio_valor, precio_fecha, baja) VALUES (@id_prod, @id_prov, @nombre_prov, @id_marca, @nombre_marca, @moneda_desc, @precio, @fecha, @baja)";
                try
                {
                    Conexion Cx = new Conexion();
                    Cx.SetCommandoTexto();
                    Cx.SetSql(sql);

                    Cx.sqlCmd.Parameters.Add("@id_prod", DbType.Int32);
                    Cx.sqlCmd.Parameters.Add("@id_prov", DbType.Int32);
                    Cx.sqlCmd.Parameters.Add("@nombre_prov", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@id_marca", DbType.Int32);
                    Cx.sqlCmd.Parameters.Add("@nombre_marca", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@moneda_desc", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@precio", DbType.Int32);
                    Cx.sqlCmd.Parameters.Add("@fecha", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@baja", DbType.Boolean);
                    Cx.sqlCmd.Parameters[0].Value = id_prod;
                    Cx.sqlCmd.Parameters[1].Value = id_prov;
                    Cx.sqlCmd.Parameters[2].Value = nombre_prov;
                    Cx.sqlCmd.Parameters[3].Value = id_marca;
                    Cx.sqlCmd.Parameters[4].Value = nombre_marca;
                    Cx.sqlCmd.Parameters[5].Value = moneda_desc;
                    Cx.sqlCmd.Parameters[6].Value = precio_valor;
                    Cx.sqlCmd.Parameters[7].Value = precio_fecha;
                    Cx.sqlCmd.Parameters[8].Value = baja;

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

                return Modificar(id_precio, id_prod, id_prov, nombre_prov, id_marca, nombre_marca, moneda_desc, precio_valor, precio_fecha, baja);


            }
        }
        private static int Modificar(int id_precio, int id_prod, int id_prov, string nombre_prov, int id_marca, string nombre_marca, string moneda_desc, int precio_valor, string precio_fecha, bool baja = true)
        {
            string sql = "Update precios SET id_prov = @id_prov, nombre_prov = @nombre_prov, id_marca = @id_marca, nombre_marca = @nombre_marca, moneda_desc = @moneda_desc, precio_valor = @precio, precio_fecha = @fecha, baja = @baja Where id_precio = @id_precio";
            try
            {

                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);

                Cx.sqlCmd.Parameters.Add("@id_prod", DbType.Int32);
                Cx.sqlCmd.Parameters.Add("@id_prov", DbType.Int32);
                Cx.sqlCmd.Parameters.Add("@nombre_prov", DbType.String);
                Cx.sqlCmd.Parameters.Add("@id_marca", DbType.Int32);
                Cx.sqlCmd.Parameters.Add("@nombre_marca", DbType.String);
                Cx.sqlCmd.Parameters.Add("@moneda_desc", DbType.String);
                Cx.sqlCmd.Parameters.Add("@precio", DbType.Int32);
                Cx.sqlCmd.Parameters.Add("@fecha", DbType.String);
                Cx.sqlCmd.Parameters.Add("@baja", DbType.Boolean);
                Cx.sqlCmd.Parameters.Add("@id_precio", DbType.Int32);
                Cx.sqlCmd.Parameters[0].Value = id_prod;
                Cx.sqlCmd.Parameters[1].Value = id_prov;
                Cx.sqlCmd.Parameters[2].Value = nombre_prov;
                Cx.sqlCmd.Parameters[3].Value = id_marca;
                Cx.sqlCmd.Parameters[4].Value = nombre_marca;
                Cx.sqlCmd.Parameters[5].Value = moneda_desc;
                Cx.sqlCmd.Parameters[6].Value = precio_valor;
                Cx.sqlCmd.Parameters[7].Value = precio_fecha;
                Cx.sqlCmd.Parameters[8].Value = baja;
                Cx.sqlCmd.Parameters[9].Value = id_precio;

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
    }
}
