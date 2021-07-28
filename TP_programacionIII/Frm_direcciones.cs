using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;


namespace TP_programacionIII
{
    public partial class Frm_direcciones : Form
    {
        private int id_prov;
        private string proveedor;

        public Frm_direcciones(int id_prov, string proveedor)
        {
            InitializeComponent();
            this.id_prov = id_prov;
            this.proveedor = proveedor;
            this.Text = "Agregando direccion a proveedor: " + proveedor;
            txt_id_prov.Text = id_prov.ToString();
            txt_nombre_prov.Text = proveedor;
            dgv_direcciones.DataSource = Direccion.TraerActivos(id_prov);
        }
        private void bto_aceptar_Click(object sender, EventArgs e)
        {
            {
                int id_dir = Int32.Parse(txt_id_dir.Text.Trim());
                int id_prov = Int32.Parse(txt_id_prov.Text.Trim());
                string ciudad = txt_ciudad.Text.Trim();
                string provincia = txt_provincia.Text.Trim();
                string pais = txt_pais.Text.Trim();
                string calle = txt_calle.Text.Trim();
                int numero = Int32.Parse(txt_numero.Text.Trim());
                int codigo_postal = Int32.Parse(txt_codigo_postal.Text.Trim());

                Direccion dir = new Direccion(id_dir, id_prov, ciudad, provincia, pais, calle, numero, codigo_postal);
                bool estado = dir.Guardar();

                if (estado)
                {
                    Funciones.MOK(this, dir.Mensaje);

                    txt_id_dir.Text = "0";
                    txt_ciudad.Text = "";
                    txt_provincia.Text = "";
                    txt_pais.Text = "";
                    txt_calle.Text = "";
                    txt_numero.Text = "";
                    txt_codigo_postal.Text = "";

                    dgv_direcciones.DataSource = Direccion.TraerActivos(id_prov);  // le asigno los datos traidos en la tabla

                }
                else
                {
                    Funciones.MError(this, dir.Mensaje);
                }
            }
        }
        private void bto_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_dir.Text != "0")
                {
                    int id_dir = Int32.Parse(txt_id_dir.Text.Trim()); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
                    int id_prov = Int32.Parse(txt_id_prov.Text.Trim());
                    string ciudad = txt_ciudad.Text.Trim();
                    string provincia = txt_provincia.Text.Trim();
                    string pais = txt_pais.Text.Trim();
                    string calle = txt_calle.Text.Trim();
                    int numero = Int32.Parse(txt_numero.Text.Trim());
                    int codigo_postal = Int32.Parse(txt_codigo_postal.Text.Trim());



                    Direccion dir = new Direccion(id_dir, id_prov, ciudad, provincia, pais, calle, numero, codigo_postal);
                    bool estado = dir.Eliminar();
                    if (estado)
                    {
                        Funciones.MOK(this, dir.Mensaje);
                        txt_id_dir.Text = "0";
                        txt_ciudad.Text = "";
                        txt_provincia.Text = "";
                        txt_pais.Text = "";
                        txt_calle.Text = "";
                        txt_numero.Text = "";
                        txt_codigo_postal.Text = "";
                        dgv_direcciones.DataSource = Direccion.TraerActivos(id_prov);  // le asigno los datos traidos en la tabla

                    }
                    else
                    {
                        Funciones.MError(this, dir.Mensaje);
                    }
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                Funciones.MError(this, "No seleccionó registro a eliminar");
            }
        }

        private void modificar(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id_dir.Text = Convert.ToString(this.dgv_direcciones.CurrentRow.Cells["id_dir"].Value);
            txt_ciudad.Text = Convert.ToString(this.dgv_direcciones.CurrentRow.Cells["ciudad"].Value);
            txt_provincia.Text = Convert.ToString(this.dgv_direcciones.CurrentRow.Cells["provincia"].Value);
            txt_pais.Text = Convert.ToString(this.dgv_direcciones.CurrentRow.Cells["pais"].Value);
            txt_calle.Text = Convert.ToString(this.dgv_direcciones.CurrentRow.Cells["calle"].Value);
            txt_numero.Text = Convert.ToString(this.dgv_direcciones.CurrentRow.Cells["numero"].Value);
            txt_codigo_postal.Text = Convert.ToString(this.dgv_direcciones.CurrentRow.Cells["codigo_postal"].Value);
            txt_id_prov.Text = Convert.ToString(this.dgv_direcciones.CurrentRow.Cells["id_proveedor"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
        }
        private void bto_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bto_limpiar_Click(object sender, EventArgs e)
        {
            txt_id_dir.Text = "0";
            txt_ciudad.Text = "";
            txt_provincia.Text = "";
            txt_pais.Text = "";
            txt_calle.Text = "";
            txt_numero.Text = "";
            txt_codigo_postal.Text = "";
        }
    }


}
