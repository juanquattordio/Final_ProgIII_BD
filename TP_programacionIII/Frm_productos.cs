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
    public partial class Frm_productos : Form
    {
        public Frm_productos()
        {
            InitializeComponent();
            txt_id_prod.Enabled = false;
            dgv_prod.DataSource = Producto.TraerActivos();  // le asigno los datos traidos en la tabla
        }

        private void chBox_Activos_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_Activos.Checked == true)
            {
                dgv_prod.DataSource = Producto.TraerActivos();  // le asigno los datos traidos en la tabla

            }
            else
            {
                dgv_prod.DataSource = Producto.TraerTodos();  // le asigno los datos traidos en la tabla
            }
        }

        private void bto_aceptar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id_prod.Text.Trim());
            string nombre = txt_nombre_prod.Text.Trim();
            string descripcion = txt_descrip_prod.Text.Trim();

            Producto producto = new Producto(id, nombre, descripcion);
            bool estado = producto.Guardar();

            if (estado)
            {
                Funciones.MOK(this, producto.Mensaje);
                txt_id_prod.Text = "0";
                txt_nombre_prod.Text = "";
                txt_descrip_prod.Text = "";
                dgv_prod.DataSource = Producto.TraerActivos();  // le asigno los datos traidos en la tabla

            }
            else
            {
                Funciones.MError(this, producto.Mensaje);
                txt_id_prod.Text = "0";
                txt_nombre_prod.Text = "";
                txt_descrip_prod.Text = "";
            }
        }
        private void modificar(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id_prod.Text = Convert.ToString(this.dgv_prod.CurrentRow.Cells["id_prod"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
            txt_nombre_prod.Text = Convert.ToString(this.dgv_prod.CurrentRow.Cells["nombre"].Value);
            txt_descrip_prod.Text = Convert.ToString(this.dgv_prod.CurrentRow.Cells["descripcion"].Value);

        }
        private void bto_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_prod.Text != "0")
                {
                    int id = Convert.ToInt32(this.dgv_prod.CurrentRow.Cells["id_prod"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
                    string nombre = Convert.ToString(this.dgv_prod.CurrentRow.Cells["nombre"].Value);
                    string descripcion = Convert.ToString(this.dgv_prod.CurrentRow.Cells["descripcion"].Value);


                    Producto producto = new Producto(id, nombre, descripcion);
                    bool estado = producto.Eliminar();
                    if (estado)
                    {
                        Funciones.MOK(this, producto.Mensaje);
                        txt_nombre_prod.Text = "";
                        txt_id_prod.Text = "0";
                        txt_descrip_prod.Text = "";
                        dgv_prod.DataSource = Producto.TraerActivos();  // le asigno los datos traidos en la tabla

                    }
                    else
                    {
                        Funciones.MError(this, producto.Mensaje);

                    }
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                Funciones.MError(this, "No seleccionó registro a eliminar");
            }
        }

        private void bto_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bto_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre_prod.Text = "";
            txt_id_prod.Text = "0";
            txt_descrip_prod.Text = "";
        }

        private void bto_agregar_prov_Click(object sender, EventArgs e)
        {
            if (txt_id_prod.Text == "0")
            {
                Funciones.MError(this, "Primero guardar producto y seleccionarlo de la grilla.");
            }
            else
            {
                int id_prod = Int32.Parse(txt_id_prod.Text);
                string producto = txt_nombre_prod.Text.Trim();

                Frm_precios frm = new Frm_precios(id_prod, producto);
                frm.Show();
                //this.Hide(); oculta frm_Proveedores
            }
        }
    }
}
