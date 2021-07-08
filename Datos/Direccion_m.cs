using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Direccion_m
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

        public static DataTable TraerActivos(int id_prov)
        {
            DataTable dtListaAll = new DataTable("Direccion"); // creo una Tabla de datos
            string sql = "SELECT id_dir, id_proveedor, ciudad, provincia, codigo_postal, pais, calle, numero, baja FROM direcciones where baja='1' and @id_prov=id_proveedor"; // le digo que datos buscar y los guardo ahí
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);
                Cx.sqlCmd.Parameters.Add("@id_prov", DbType.Int32);
                Cx.sqlCmd.Parameters[0].Value = id_prov;


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

        public static int Guardar(int id_dir, int id_prov, string ciudad, string provincia, string pais, string calle, int numero, int codigo_postal, bool baja = true)
        {
            if (id_dir == 0)  
            {
                string sql = "INSERT INTO direcciones (id_proveedor, ciudad, provincia, codigo_postal, pais, calle, numero, baja) VALUES (@id_prov, @ciudad, @provincia, @codigo_postal, @pais, @calle, @numero, @baja)"; //RETURNING id_tel
                try
                {

                    Conexion Cx = new Conexion();
                    Cx.SetCommandoTexto();
                    Cx.SetSql(sql);

                    Cx.sqlCmd.Parameters.Add("@id_prov", DbType.Int32);
                    Cx.sqlCmd.Parameters.Add("@ciudad", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@provincia", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@codigo_postal", DbType.Int32);
                    Cx.sqlCmd.Parameters.Add("@pais", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@calle", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@numero", DbType.Int32);
                    Cx.sqlCmd.Parameters.Add("@baja", DbType.Boolean);
                    Cx.sqlCmd.Parameters[0].Value = id_prov;
                    Cx.sqlCmd.Parameters[1].Value = ciudad;
                    Cx.sqlCmd.Parameters[2].Value = provincia;
                    Cx.sqlCmd.Parameters[3].Value = codigo_postal;
                    Cx.sqlCmd.Parameters[4].Value = pais;
                    Cx.sqlCmd.Parameters[5].Value = calle;
                    Cx.sqlCmd.Parameters[6].Value = numero;
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
                
                return Modificar(id_dir, id_prov, ciudad, provincia, codigo_postal, pais, calle, numero, baja);


            }
        }
        private static int Modificar(int id_dir, int id_prov, string ciudad, string provincia, int codigo_postal, string pais, string calle, int numero, bool baja = true)
        {
            string sql = "Update direcciones SET id_proveedor = @id_prov, ciudad = @ciudad, provincia = @provincia, codigo_postal = @codigo_postal, pais = @pais, calle = @calle, numero = @numero, baja = @baja Where id_dir = @id_dir"; //RETURNING id_marca
            try
            {

                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);

                Cx.sqlCmd.Parameters.Add("@id_prov", DbType.Int32);
                Cx.sqlCmd.Parameters.Add("@ciudad", DbType.String);
                Cx.sqlCmd.Parameters.Add("@provincia", DbType.String);
                Cx.sqlCmd.Parameters.Add("@codigo_postal", DbType.Int32);
                Cx.sqlCmd.Parameters.Add("@pais", DbType.String);
                Cx.sqlCmd.Parameters.Add("@calle", DbType.String);
                Cx.sqlCmd.Parameters.Add("@numero", DbType.Int32);
                Cx.sqlCmd.Parameters.Add("@baja", DbType.Boolean);
                Cx.sqlCmd.Parameters.Add("@id_dir", DbType.Int32);
                Cx.sqlCmd.Parameters[0].Value = id_prov;
                Cx.sqlCmd.Parameters[1].Value = ciudad;
                Cx.sqlCmd.Parameters[2].Value = provincia;
                Cx.sqlCmd.Parameters[3].Value = codigo_postal;
                Cx.sqlCmd.Parameters[4].Value = pais;
                Cx.sqlCmd.Parameters[5].Value = calle;
                Cx.sqlCmd.Parameters[6].Value = numero;
                Cx.sqlCmd.Parameters[7].Value = baja;
                Cx.sqlCmd.Parameters[8].Value = id_dir;

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
