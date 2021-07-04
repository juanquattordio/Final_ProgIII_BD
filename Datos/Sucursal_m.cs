using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Sucursal_m
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

        public static bool ValidarNombre(string nombre)
        {
            return true;
        }

        public static int Guardar(int pid , string pnombre,char pbaja = 'N')
        {
            if (pid == 0)
            {
                string sql = "INSERT INTO sucursales (nombre, baja) VALUES (@nombre, @baja)"; //RETURNING id_suc
                try {

                    Conexion Cx = new Conexion();
                    Cx.SetCommandoTexto();
                    Cx.SetSql(sql);

                   // Cx.sqlCmd.Parameters.AddWithValue("@nombre", pnombre);
                    Cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                    Cx.sqlCmd.Parameters.Add("@baja", DbType.String);
                    Cx.sqlCmd.Parameters[0].Value = pnombre;
                    Cx.sqlCmd.Parameters[1].Value = pbaja;

                    Cx.Abrir();
                    int nro = Cx.sqlCmd.ExecuteNonQuery();
                    Cx.Cerrar();

                    return nro;


                } catch(Exception e){
                    return 0;
                }
            }
            else {

                return Modificar(pid, pnombre, pbaja );
            
            
            }
        }

        public static int Modificar(int pid, string pnombre, char pbaja)
        {
            string sql = "Update sucursales SET nombre = @nombre, baja =@baja Where id_suc = @id"; //RETURNING id_suc
            try
            {

                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);

                Cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                Cx.sqlCmd.Parameters.Add("@baja", DbType.String);
                Cx.sqlCmd.Parameters.Add("@id", DbType.Int32);

                Cx.sqlCmd.Parameters[0].Value = pnombre;
                Cx.sqlCmd.Parameters[1].Value = pbaja;
                Cx.sqlCmd.Parameters[2].Value = pid;

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

        public static DataTable CargarcomboBox()
        {
            DataTable ds = new DataTable();

            string sql = "SELECT 0 as id_suc, 'Seleccione....' as nombre Union " +
                         "SELECT id_suc , nombre FROM sucursales where baja = 'N'  ";
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(ds);//colocamos un DataTable


            }
            catch (Exception)
            {
                ds = null;
            }
            return ds;
        }


        public static DataTable TraerTodos()
        {
            DataTable dtListaAll = new DataTable("Suc"); // creo una Tabla de datos
            string sql = "SELECT id_suc, nombre FROM sucursales where baja='N'"; // le digo que datos buscar y los guardo ahí
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
