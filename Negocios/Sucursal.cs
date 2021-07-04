using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Datos;
using System.Data.SqlClient;

namespace Negocios
{
    public class Sucursal
    {
        private int id_suc;
        private string nombre;

        private string mensaje;

        public string Mensaje { get => mensaje; set => mensaje = value; }


        public Sucursal(string pnombre)
        {
            this.nombre = pnombre;
        }
        
        public Sucursal(int pid, string pnombre)
        {
            this.id_suc = pid;
            this.nombre = pnombre;
        }

        public static DataTable TraerTodos()
        {
            return Sucursal_m.TraerTodos();
        }

        public Sucursal() { }


        public bool EstadoConexion()
        {

            if (Sucursal_m.Acceso())
            {
                return true;
            }
            else
            {

                this.Mensaje = "No se puede conectar a la DDBB";
                return false;
            }

        }

        public bool Guardar()
        {
            int resultado = 0 ;

            if (Sucursal_m.ValidarNombre(this.nombre)) {
                resultado = Sucursal_m.Guardar(id_suc, nombre);
            }


            if (resultado > 0) {
                this.mensaje = "Se guardo correctamenta en la Base de datos";
                return true;
            } 
            else {
                this.mensaje = "NO Se pudo guardar Rebice los datos";
                return false;
            }
        }

        public bool Eliminar()
        {// es igual a guardar pero no valido datos, ni tomo los datos de los input como en Modificar.
            int resultado = 0;
            resultado = Sucursal_m.Guardar(id_suc, nombre,'S');

            if (resultado > 0)
            {
                this.mensaje = "Se elimino correctamenta en la Base de datos";
                return true;
            }
            else
            {
                this.mensaje = "NO Se pudo eliminar, revise los datos";
                return false;
            }
        }


        public static DataTable CargarcomboBox()
        {
            return Sucursal_m.CargarcomboBox();
        }
    }
}
