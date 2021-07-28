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
    public partial class Frm_precios : Form
    {
        private int id_producto;
        private string producto;

        public Frm_precios(int id_producto, string producto)
        {
            InitializeComponent();
            this.id_producto = id_producto;
            this.producto = producto;
            this.Text = "Agregando precios a producto: " + producto;
            txt_id_prod.Text = id_producto.ToString();
            txt_nombre_prod.Text = producto;
            dgv_proveedores.DataSource = Proveedor.TraerActivos();
            dgv_marcas.DataSource = Marca.TraerActivos();
            dgv_precios.DataSource = Precio.TraerActivos(id_producto);
        }

        private void bto_aceptar_Click(object sender, EventArgs e)
        {
            int id_precio = Int32.Parse(txt_id_precio.Text.Trim()); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
            int id_prod = Int32.Parse(txt_id_prod.Text.Trim());
            int id_prov = Int32.Parse(txt_id_prov.Text.Trim());
            string nombre_prov= txt_nombre_prov.Text.Trim();
            int id_marca = Int32.Parse(txt_id_marca.Text.Trim());
            string nombre_marca = txt_nombre_marca.Text.Trim();
            string moneda = txt_nombre_moneda.Text.Trim();
            string fecha = txt_fecha.Text.Trim();
            int precio_valor= Int32.Parse(txt_precio.Text.Trim());
            //float precio_valor = Convert.ToSingle(txt_precio.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")); // de esta manera, los decimales usan .

            Precio precio = new Precio(id_precio, id_prod, id_prov, nombre_prov, id_marca, nombre_marca, moneda, precio_valor, fecha);
            bool estado = precio.Guardar();

            if (estado)
            {
                Funciones.MOK(this, precio.Mensaje);

                txt_id_precio.Text = "0";
                txt_id_prov.Text = "0";
                txt_nombre_prov.Text = "";
                txt_id_marca.Text = "0";
                txt_nombre_marca.Text = "";
                txt_fecha.Text = "";
                txt_nombre_moneda.Text = "";
                txt_precio.Text = "";

                dgv_precios.DataSource = Precio.TraerActivos(id_prod); // le asigno los datos traidos en la tabla

            }
            else
            {
                Funciones.MError(this, precio.Mensaje);
            }
        }

        private void bto_limpiar_Click(object sender, EventArgs e)
        {
            txt_id_precio.Text = "0";
            txt_id_prov.Text = "0";
            txt_nombre_prov.Text = "";
            txt_id_marca.Text = "0";
            txt_nombre_marca.Text = "";
            txt_fecha.Text = "";
            txt_nombre_moneda.Text = "";
            txt_precio.Text = "";
        }

        private void bto_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_precio.Text != "0")
                {
                    int id_precio = Int32.Parse(txt_id_precio.Text.Trim()); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
                    int id_prod = Int32.Parse(txt_id_prod.Text.Trim());
                    int id_prov = Int32.Parse(txt_id_prov.Text.Trim());
                    string nombre_prov = txt_nombre_prov.Text.Trim();
                    int id_marca = Int32.Parse(txt_id_marca.Text.Trim());
                    string nombre_marca = txt_nombre_marca.Text.Trim();
                    string moneda = txt_nombre_moneda.Text.Trim();
                    string fecha = txt_fecha.Text.Trim();
                    int precio_valor = Int32.Parse(txt_precio.Text.Trim());
                    //float precio_valor = Convert.ToSingle(txt_precio.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")); // de esta manera, los decimales usan .

                    Precio precio = new Precio(id_precio, id_prod, id_prov, nombre_prov, id_marca, nombre_marca, moneda, precio_valor, fecha);
                    bool estado = precio.Eliminar();
                    if (estado)
                    {
                        Funciones.MOK(this, precio.Mensaje);
                        txt_id_precio.Text = "0";
                        txt_id_prov.Text = "0";
                        txt_nombre_prov.Text = "";
                        txt_id_marca.Text = "0";
                        txt_nombre_marca.Text = "";
                        txt_fecha.Text = "";
                        txt_nombre_moneda.Text = "";
                        txt_precio.Text = "";
                        dgv_precios.DataSource = Precio.TraerActivos(id_prod);  // le asigno los datos traidos en la tabla

                    }
                    else
                    {
                        Funciones.MError(this, precio.Mensaje);
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

        private void selectProv(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id_prov.Text = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["id_prov"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
            txt_nombre_prov.Text = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["nombre"].Value);
        }

        private void selectMarca(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id_marca.Text = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["id_marca"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
            txt_nombre_marca.Text = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["nombreMarca"].Value);
        }

        private void modificarPrecio(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id_precio.Text = Convert.ToString(this.dgv_precios.CurrentRow.Cells["id_precio"].Value); // selecciona la celda de la fila current (seleccionada), uso el nombre de la columna del data grid view, lo obtiene en string, por eso lo convierte.
            txt_id_prov.Text = Convert.ToString(this.dgv_precios.CurrentRow.Cells["IDProveedor"].Value);
            txt_nombre_prov.Text = Convert.ToString(this.dgv_precios.CurrentRow.Cells["nombre_prov"].Value);
            txt_id_marca.Text = Convert.ToString(this.dgv_precios.CurrentRow.Cells["IdMarca"].Value);
            txt_nombre_marca.Text = Convert.ToString(this.dgv_precios.CurrentRow.Cells["nombre_marca"].Value);
            txt_fecha.Text = Convert.ToString(this.dgv_precios.CurrentRow.Cells["Fecha"].Value);
            txt_nombre_moneda.Text = Convert.ToString(this.dgv_precios.CurrentRow.Cells["Moneda"].Value);
            txt_precio.Text = Convert.ToString(this.dgv_precios.CurrentRow.Cells["precio_dvg"].Value); ;
        }
    }
}
