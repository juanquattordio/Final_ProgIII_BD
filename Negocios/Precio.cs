using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Precio
    {
        private int id_precio;
        private int id_prod;
        private int id_prov;
        private string nombre_prov;
        private int id_marca;
        private string nombre_marca;
        private char moneda;
        private string moneda_desc;
        private float precio_valor;
        private string precio_fecha;
        private string tipo_prov;
        private bool baja;
        private string mensaje;

        public Precio (int id_precio, int id_prod, int id_prov, string nombre_prov, int id_marca, string nombre_marca, string moneda_desc, float precio_valor, string precio_fecha, string tipo_prov, bool baja = true)
        {
            this.id_precio = id_precio;
            this.id_prod = id_prod;
            this.id_prov = id_prov;
            this.nombre_prov = nombre_prov;
            this.id_marca = id_marca;
            this.nombre_marca = nombre_marca;
            //this.moneda = moneda;
            this.moneda_desc = moneda_desc;
            this.precio_valor = precio_valor;
            this.precio_fecha = precio_fecha;
            this.tipo_prov = tipo_prov;
            this.baja = baja;
        }
        public string Mensaje { get => mensaje; set => mensaje = value; }

        public static DataTable TraerActivos(int id_producto)
        {
            return Precio_m.TraerActivos(id_producto);
        }
        public bool Guardar()
        {
            int resultado = 0;

            if (Precio_m.ValidarDatos())
            {
                resultado = Precio_m.Guardar(id_precio, id_prod, id_prov, nombre_prov, id_marca, nombre_marca, moneda_desc, precio_valor, precio_fecha, tipo_prov, true);
            }

            else
            {
                this.mensaje = "Datos duplicados";
            }


            if (resultado > 0)
            {
                this.mensaje = "Se guardo correctamente en la Base de datos";
                return true;
            }
            else
            {
                this.mensaje = "NO Se pudo guardar el precio. Revise los datos";
                return false;
            }
        }
        public bool Eliminar()
        {
            int resultado = 0;
            resultado = Precio_m.Guardar(id_precio, id_prod, id_prov, nombre_prov, id_marca, nombre_marca, moneda_desc, precio_valor, precio_fecha, tipo_prov, false);

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
