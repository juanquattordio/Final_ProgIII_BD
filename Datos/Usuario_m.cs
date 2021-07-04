using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Usuario_m
    {
        public static bool Validar(string usuario, string password)
        {// ejecuto una consulta de seleccion
            string sql = "Select * from usuarios where password=HashBytes('MD5','"+password+"') and usuario='"+usuario+"' ";
            bool retorno = true;
            try // abro conexion
            {
                Conexion Cx = new Conexion();
                Cx.SetCommandoTexto();
                Cx.SetSql(sql);
                Cx.Abrir();
                SqlDataReader reader = Cx.sqlCmd.ExecuteReader(); // creo un reader, es un objeto que representa el resultado de la consulta de arriba
                //La información que devuelve, no puedo almacenarla cono un DataSet, cuando cierro el Reader, cierra la conexión y la información de la consulta pierde.
                //Tener en cuenta un métdo ExecuteNoReader(), ver qué me permite
                if (!reader.HasRows) // HasRows lee si el objeto Reader tiene filas. Lo niega (!) porque el 0 se toma como falso. Si reader.HasRow>0 quiere decir que existe el usuario y contraseña ingresados. Si es mayor que 0, lo toma como falso al agregarle el !
                {
                    retorno= false; // si el reader es 0, lo evalúo como true y devuelvo falso.
                }
                reader.Close(); // debo cerrarlos porque 
                // Cx.Cerrar(); si cierro el reader, se cierra el Cx.
            }
            catch (Exception e)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
