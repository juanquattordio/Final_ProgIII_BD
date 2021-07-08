using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Telefono
    {
        private int id_tel;
        private int id_prov;
        private int codigo_area;
        private int telefono;
        private string mensaje;
        private bool baja;

        public Telefono(int id_tel, int id_prov, int codigo_area, int telefono, bool baja = true)
        {
            this.id_tel = id_tel;
            this.id_prov = id_prov;
            this.codigo_area = codigo_area;
            this.telefono = telefono;
            this.baja = baja;
        }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public static DataTable TraerActivos(int id_prov)
        {
            return Telefono_m.TraerActivos(id_prov);
        }

        public bool Guardar()
        {
            int resultado = 0;

            if (Telefono_m.ValidarDatos(this.codigo_area, this.telefono)) // aca usar el this.codigo_area
            {
                resultado = Telefono_m.Guardar(id_tel,id_prov, codigo_area, telefono, true);
            }
            else
            {
                this.mensaje= "Codigo de area y telefono repetidos";
            }


            if (resultado > 0)
            {
                this.mensaje = "Se guardo correctamente en la Base de datos";
                return true;
            }
            else
            {
                this.mensaje = "NO Se pudo guardar el telefono. Revise los datos";
                return false;
            }
        }
        public bool Eliminar()
        {
            int resultado = 0;
            resultado = Telefono_m.Guardar(id_tel, id_prov, codigo_area, telefono, false);

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
