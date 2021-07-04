using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Datos
{
    public class Conexion 
    {
        // Data Source =.\SQLEXPRESS;User ID=ass : Initial Catalog = prg3; Integrated Security = True
        public SqlCommand sqlCmd; // comando 
        private SqlConnection sqlCon;// conexion


        public Conexion()
        {
            string servidor = ConfigurationManager.AppSettings["server"];
            //  string usuario = "";
            //  string password = "";
            string ddbb = ConfigurationManager.AppSettings["ddbb"];

            sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source =DESKTOP-89KTCG1; Initial Catalog =prg3; Integrated Security = True";

            sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandTimeout = 0;
        }

        public void Abrir()
        {
            sqlCon.Open();
        }
        public void Cerrar()
        {
            sqlCon.Close();
        }

        public void SetCommandoTexto()
        {
            sqlCmd.CommandType = CommandType.Text;
        }

        public void SetSql(string query)
        {
            sqlCmd.CommandText = query; // select * from usuarios
        }
        public SqlCommand Comando()
        {
            return sqlCmd;
        }
    }
}
