using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Marca
    {
        private int id_marca;
        private string nombre;
        private string descripcion;
        private bool baja;
        private string mensaje;

        public Marca(int id, string nombre, string descripcion, bool baja=true)
        {
            this.id_marca = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.baja = baja;
        }
       
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public static DataTable TraerActivos()
        {
            return Marca_m.TraerActivos();
        }
        public static DataTable TraerTodos()
        {
            return Marca_m.TraerTodos();
        }

        public bool Guardar()
        {
            int resultado = 0;

            if (Marca_m.ValidarNombre(this.nombre))
            {
                resultado = Marca_m.Guardar(id_marca, nombre, descripcion,true);
            }


            if (resultado > 0)
            {
                this.mensaje = "Se guardo correctamenta en la Base de datos";
                return true;
            }
            else
            {
                this.mensaje = "NO Se pudo guardar la marca. Revise los datos";
                return false;
            }
        }

        public bool Eliminar()
        { //es igual a guardar pero no valido datos, ni tomo los datos de los input como en Modificar.
            int resultado = 0;
            resultado = Marca_m.Guardar(id_marca, nombre, descripcion, false);

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
    }
}
