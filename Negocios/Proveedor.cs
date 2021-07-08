using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Proveedor
    {
        private int id_prov;
        private string nombre;
        private string tipo_prov;
        private string cuit;
        private string ibb;
        private string dni;
        private bool baja;
        private string mensaje;

        public Proveedor(int id, string nombre, string tipo_prov, string cuit, string ibb, string dni, bool baja = true)
        {
            this.id_prov = id;
            this.nombre = nombre;
            this.tipo_prov = tipo_prov;
            this.cuit = cuit;
            this.ibb = ibb;
            this.dni = dni;
            this.baja = baja;
        }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public static DataTable TraerActivos()
        {
            return Proveedor_m.TraerActivos();
        }
        public static DataTable TraerTodos()
        {
            return Proveedor_m.TraerTodos();
        }
        public bool Guardar()
        {
            int resultado = 0;

            if (Proveedor_m.ValidarDatos(this.cuit, this.dni))
            {
                resultado = Proveedor_m.Guardar(id_prov, nombre, tipo_prov, cuit, ibb, dni, true);
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
        {
            int resultado = 0;
            resultado = Proveedor_m.Guardar(id_prov, nombre, tipo_prov, cuit, ibb, dni, false);

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
