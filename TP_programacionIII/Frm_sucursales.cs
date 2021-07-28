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
    public partial class Frm_sucursales : Form
    {
        public Frm_sucursales()
        {
            InitializeComponent();
            txt_id_suc.Enabled = false;

            dgv_sucursales.DataSource = Sucursal.TraerTodos();  // le asigno los datos traidos en la tabla

        }

        private void bto_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre_suc.Text.Trim();
            int id = Int32.Parse(txt_id_suc.Text.Trim());

            Sucursal suc = new Sucursal(id, nombre);
            bool estado = suc.Guardar();

            if (estado) {
                Funciones.MOK(this, suc.Mensaje);
                txt_nombre_suc.Text = "";
                txt_id_suc.Text = "0";
                dgv_sucursales.DataSource = Sucursal.TraerTodos();  // le asigno los datos traidos en la tabla

            } else {
                Funciones.MError(this, suc.Mensaje);
                txt_nombre_suc.Text = "";
                txt_id_suc.Text = "0";
            }
        }

        private void bto_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bto_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_suc.Text != "0")
                {
                    int id = Convert.ToInt32(this.dgv_sucursales.CurrentRow.Cells["id"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
                string nombre = Convert.ToString(this.dgv_sucursales.CurrentRow.Cells["nombre"].Value);

                Sucursal suc = new Sucursal(id, nombre);
                bool estado = suc.Eliminar();
                if (estado)
                {
                    Funciones.MOK(this, suc.Mensaje);
                    txt_nombre_suc.Text = "";
                    txt_id_suc.Text = "0";
                    dgv_sucursales.DataSource = Sucursal.TraerTodos();  // le asigno los datos traidos en la tabla

                }
                else
                {
                    Funciones.MError(this, suc.Mensaje);
                    txt_nombre_suc.Text = "";
                    txt_id_suc.Text = "0";
                }
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                Funciones.MError(this, "No seleccionó registro a eliminar");
            }
        }
        private void bto_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre_suc.Text = "";
            txt_id_suc.Text = "0";
        }
            private void modificar(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id_suc.Text = Convert.ToString(this.dgv_sucursales.CurrentRow.Cells["id"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
            txt_nombre_suc.Text = Convert.ToString(this.dgv_sucursales.CurrentRow.Cells["nombre"].Value);
                    
        }
    }
}
