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
    public partial class Frm_proveedores : Form
    {
        public Frm_proveedores()
        {
            InitializeComponent();
            txt_id_prov.Enabled = false;
            dgv_proveedores.DataSource = Proveedor.TraerActivos();  // le asigno los datos traidos en la tabla
        }


        private void bto_aceptar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id_prov.Text.Trim());
            string nombre = txt_nombre_prov.Text.Trim();
            string tipo_prov = cb_tipo_prov.Text.Trim();
            string cuit = txt_cuit_prov.Text.Trim();
            string ibb = txt_ibb_prov.Text.Trim();
            string dni = txt_dni_prov.Text.Trim();


            Proveedor proveedor = new Proveedor(id, nombre, tipo_prov, cuit, ibb, dni);
            bool estado = proveedor.Guardar();

            if (estado)
            {
                Funciones.MOK(this, proveedor.Mensaje);
                txt_nombre_prov.Text = "";
                cb_tipo_prov.Text = "";
                txt_cuit_prov.Text = "";
                txt_ibb_prov.Text = "";
                txt_dni_prov.Text = "";
                txt_id_prov.Text = "0";
                dgv_proveedores.DataSource = Proveedor.TraerActivos();  // le asigno los datos traidos en la tabla

            }
            else
            {
                Funciones.MError(this, proveedor.Mensaje);
                txt_nombre_prov.Text = "";
                cb_tipo_prov.Text = "";
                txt_cuit_prov.Text = "";
                txt_ibb_prov.Text = "";
                txt_dni_prov.Text = "";
                txt_id_prov.Text = "0";
            }
        }

        private void modificar(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id_prov.Text = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["id_proveedor"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
            txt_nombre_prov.Text = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["nombre"].Value);
            cb_tipo_prov.Text = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["tipo_prov"].Value);
            txt_cuit_prov.Text = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["cuit"].Value);
            txt_ibb_prov.Text = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["IBB"].Value);
            txt_dni_prov.Text = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["DNI"].Value);

        }

        private void bto_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_prov.Text != "0")
                {
                    int id = Convert.ToInt32(this.dgv_proveedores.CurrentRow.Cells["id_proveedor"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
                    string nombre = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["nombre"].Value);
                    string tipo_prov = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["tipo_prov"].Value);
                    string cuit = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["cuit"].Value);
                    string ibb = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["IBB"].Value);
                    string dni = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["DNI"].Value);

                    Proveedor proveedor = new Proveedor(id, nombre, tipo_prov, cuit, ibb, dni);
                    bool estado = proveedor.Eliminar();
                    if (estado)
                    {
                        Funciones.MOK(this, proveedor.Mensaje);
                        txt_nombre_prov.Text = "";
                        cb_tipo_prov.Text = "";
                        txt_cuit_prov.Text = "";
                        txt_ibb_prov.Text = "";
                        txt_dni_prov.Text = "";
                        txt_id_prov.Text = "0";
                        dgv_proveedores.DataSource = Proveedor.TraerActivos();  // le asigno los datos traidos en la tabla

                    }
                    else
                    {
                        Funciones.MError(this, proveedor.Mensaje);
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
            txt_nombre_prov.Text = "";
            cb_tipo_prov.Text = "";
            txt_cuit_prov.Text = "";
            txt_ibb_prov.Text = "";
            txt_dni_prov.Text = "";
            txt_id_prov.Text = "0";
        }

        private void chBox_Activos_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_Activos.Checked == true)
            {
                dgv_proveedores.DataSource = Proveedor.TraerActivos();  // le asigno los datos traidos en la tabla

            }
            else
            {
                dgv_proveedores.DataSource = Proveedor.TraerTodos();  // le asigno los datos traidos en la tabla
            }
        }

        private void cb_tipo_prov_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_tipo_prov.Text.Trim() == "Minorista")
            {
                txt_cuit_prov.Text = "";
                txt_ibb_prov.Text = "";
                txt_cuit_prov.Enabled = false;
                txt_ibb_prov.Enabled = false;
                txt_dni_prov.Enabled = true;

            }
            else
            {
                txt_dni_prov.Text = "";
                txt_dni_prov.Enabled = false;
                txt_cuit_prov.Enabled = true;
                txt_ibb_prov.Enabled = true;
            }
        }

        private void bto_agregar_telefono_Click(object sender, EventArgs e)
        {
            if (txt_id_prov.Text == "0")
            {
                Funciones.MError(this, "Primero guardar proveedor y seleccionar de la grilla el proveedor a cargar telefono.");
            }
            else
            {
                int id_prov = Int32.Parse(txt_id_prov.Text);
                string proveedor = txt_nombre_prov.Text.Trim();

                Frm_telefonos frm = new Frm_telefonos(id_prov, proveedor);
                frm.Show();
                //this.Hide(); oculta frm_Proveedores
            }

        }

        private void bto_agregar_direccion_Click(object sender, EventArgs e)
        {
            if (txt_id_prov.Text == "0")
            {
                Funciones.MError(this, "Primero guardar proveedor y seleccionar de la grilla el proveedor a cargar dirección.");
            }
            else
            {
                int id_prov = Int32.Parse(txt_id_prov.Text);
                string proveedor = txt_nombre_prov.Text.Trim();

                Frm_direcciones frm = new Frm_direcciones(id_prov, proveedor);
                frm.Show();
                //this.Hide(); oculta frm_Proveedores
            }
        }
    }
}
