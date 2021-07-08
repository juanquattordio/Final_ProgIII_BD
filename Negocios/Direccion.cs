using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Direccion
    {
        private int id_dir;
        private int id_prov;
        private string ciudad;
        private string provincia;
        private int codigo_postal;
        private string pais;
        private string calle;
        private int numero;
        private string mensaje;
        private bool baja;

        public Direccion(int id_dir, int id_prov, string ciudad, string provincia, string pais,  string calle, int numero, int codigo_postal, bool baja = true)
        {
            this.id_dir = id_dir;
            this.id_prov = id_prov;
            this.ciudad = ciudad;
            this.provincia = provincia;
            this.codigo_postal = codigo_postal;
            this.pais = pais;
            this.calle = calle;
            this.numero = numero;
            this.baja = baja;
        }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public static DataTable TraerActivos(int id_prov)
        {
            return Direccion_m.TraerActivos(id_prov);
        }

        public bool Guardar()
        {
            int resultado = 0;

            if (Direccion_m.ValidarDatos()) // aca usar el this.codigo_area
            {
                resultado = Direccion_m.Guardar(id_dir, id_prov, ciudad, provincia, pais, calle, numero, codigo_postal, true);
            }
            
            else
            {
                this.mensaje= "Datos duplicados";
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
            resultado = Direccion_m.Guardar(id_dir, id_prov, ciudad, provincia, pais, calle, numero, codigo_postal, false);

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
