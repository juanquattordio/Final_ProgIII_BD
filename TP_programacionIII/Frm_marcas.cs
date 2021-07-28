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
    public partial class Frm_marcas : Form
    {
        public Frm_marcas()
        {
            InitializeComponent();
            txt_id_marca.Enabled = false;
            dgv_marcas.DataSource = Marca.TraerActivos();  // le asigno los datos traidos en la tabla
        }

        private void chBox_Activos_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_Activos.Checked == true)
            {
                dgv_marcas.DataSource = Marca.TraerActivos();  // le asigno los datos traidos en la tabla

            }
            else
            {
                dgv_marcas.DataSource = Marca.TraerTodos();  // le asigno los datos traidos en la tabla
            }
        }

        private void bto_aceptar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id_marca.Text.Trim());
            string nombre = txt_nombre_marca.Text.Trim();
            string descripcion = txt_desc_marca.Text.Trim();


            Marca marca = new Marca(id, nombre, descripcion);
            bool estado = marca.Guardar();

            if (estado)
            {
                Funciones.MOK(this, marca.Mensaje);
                txt_nombre_marca.Text = "";
                txt_desc_marca.Text = "";
                txt_id_marca.Text = "0";
                dgv_marcas.DataSource = Marca.TraerActivos();  // le asigno los datos traidos en la tabla

            }
            else
            {
                Funciones.MError(this, marca.Mensaje);
                txt_nombre_marca.Text = "";
                txt_id_marca.Text = "0";
            }
        }

        private void modificar(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id_marca.Text = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["id_marca"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
            txt_nombre_marca.Text = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["nombre"].Value);
            txt_desc_marca.Text = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["descripcion_marca"].Value);
        }

        private void bto_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_marca.Text != "0")
                {
                    int id = Convert.ToInt32(this.dgv_marcas.CurrentRow.Cells["id_marca"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
                    string nombre = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["nombre"].Value);
                    string descripcion = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["descripcion_marca"].Value);

                    Marca marca = new Marca(id, nombre, descripcion);
                    bool estado = marca.Eliminar();
                    if (estado)
                    {
                        Funciones.MOK(this, marca.Mensaje);
                        txt_nombre_marca.Text = "";
                        txt_id_marca.Text = "0";
                        txt_desc_marca.Text = "";
                        dgv_marcas.DataSource = Marca.TraerActivos();  // le asigno los datos traidos en la tabla

                    }
                    else
                    {
                        Funciones.MError(this, marca.Mensaje);
                        txt_nombre_marca.Text = "";
                        txt_id_marca.Text = "0";
                        txt_desc_marca.Text = "";
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
            txt_nombre_marca.Text = "";
            txt_desc_marca.Text = "";
            txt_id_marca.Text = "0";
        }
    }

}
