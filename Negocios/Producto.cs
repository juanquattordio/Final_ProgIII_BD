using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Producto
    {
        private int id_prod;
        private string nombre;
        private string descripcion;
        private bool baja;
        private string mensaje;

        public Producto(int id, string nombre, string descripcion, bool baja = true)
        {
            this.id_prod = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.baja = baja;
        }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public static DataTable TraerActivos()
        {
            return Producto_m.TraerActivos();
        }
        public static DataTable TraerTodos()
        {
            return Producto_m.TraerTodos();
        }
        public bool Guardar()
        {
            int resultado = 0;

            if (Producto_m.ValidarDatos(this.id_prod) )
            {
                resultado = Producto_m.Guardar(id_prod, nombre, descripcion, true);
            }

            if (resultado > 0)
            {
                this.mensaje = "Se guardo correctamenta en la Base de datos";
                return true;
            }
            else
            {
                this.mensaje = "NO Se pudo guardar el producto. Revise los datos";
                return false;
            }
        }
        public bool Eliminar()
        {
            int resultado = 0;
            resultado = Producto_m.Guardar(id_prod, nombre, descripcion, false);

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
