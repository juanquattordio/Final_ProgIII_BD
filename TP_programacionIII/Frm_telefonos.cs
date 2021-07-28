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
    public partial class Frm_telefonos : Form
    {
        private int id_prov;
        private string proveedor;

        public Frm_telefonos(int id_prov, string proveedor)
        {
            InitializeComponent();
            this.id_prov = id_prov;
            this.proveedor = proveedor;
            this.Text = "Agregando telefono a proveedor: " + proveedor;
            txt_id_prov.Text = id_prov.ToString();
            txt_nombre_prov.Text = proveedor;
            dgv_telefonos.DataSource = Telefono.TraerActivos(id_prov);
        }

        private void bto_aceptar_Click(object sender, EventArgs e)
        {
            {
                int id_tel = Int32.Parse(txt_id_tel.Text.Trim());
                int id_prov = Int32.Parse(txt_id_prov.Text.Trim());
                int codigo_area = Int32.Parse(txt_codigo_area.Text.Trim());
                int telefono = Int32.Parse(txt_telefono.Text.Trim());

                Telefono tel = new Telefono(id_tel, id_prov, codigo_area, telefono);
                bool estado = tel.Guardar();

                if (estado)
                {
                    Funciones.MOK(this, tel.Mensaje);
                    txt_id_tel.Text = "0";
                    txt_codigo_area.Text = "";
                    txt_telefono.Text = "";

                    dgv_telefonos.DataSource = Telefono.TraerActivos(id_prov);  // le asigno los datos traidos en la tabla

                }
                else
                {
                    Funciones.MError(this, tel.Mensaje);
                    //txt_nombre_prov.Text = "";
                    //txt_direccion_prov.Text = "";
                    //txt_tel_prov.Text = "";
                    //cb_tipo_prov.Text = "";
                    //txt_cuit_prov.Text = "";
                    //txt_ibb_prov.Text = "";
                    //txt_dni_prov.Text = "";
                    //txt_id_prov.Text = "0";
                }
            }
        }
        private void bto_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_tel.Text != "0")
                {
                    int id_tel = Int32.Parse(txt_id_tel.Text.Trim());
                    int id_prov = Int32.Parse(txt_id_prov.Text.Trim());
                    int codigo_area = Int32.Parse(txt_codigo_area.Text.Trim());
                    int telefono = Int32.Parse(txt_telefono.Text.Trim());

                    Telefono tel = new Telefono(id_tel, id_prov, codigo_area, telefono);
                    bool estado = tel.Eliminar();
                    if (estado)
                    {
                        Funciones.MOK(this, tel.Mensaje);
                        txt_id_tel.Text = "0";
                        txt_codigo_area.Text = "";
                        txt_telefono.Text = "";

                        dgv_telefonos.DataSource = Telefono.TraerActivos(id_prov);  // le asigno los datos traidos en la tabla

                    }
                    else
                    {
                        Funciones.MError(this, tel.Mensaje);
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
            txt_id_tel.Text = Convert.ToString(this.dgv_telefonos.CurrentRow.Cells["id_tel"].Value);
            txt_telefono.Text = Convert.ToString(this.dgv_telefonos.CurrentRow.Cells["telefono"].Value);
            txt_codigo_area.Text = Convert.ToString(this.dgv_telefonos.CurrentRow.Cells["codigo_area"].Value);
            txt_id_prov.Text = Convert.ToString(this.dgv_telefonos.CurrentRow.Cells["id_proveedor"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
        }
        private void bto_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bto_limpiar_Click(object sender, EventArgs e)
        {
            txt_id_tel.Text = "0";
            txt_telefono.Text = "";
            txt_codigo_area.Text = "";
        }
    }
}
