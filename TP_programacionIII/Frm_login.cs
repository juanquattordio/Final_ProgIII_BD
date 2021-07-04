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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();

            Sucursal suc = new Sucursal();
            try
            {
                if (suc.EstadoConexion())
                {
                    /* DataSet dt1 = Sucursal.CargarcomboBox();
                     cb_sucursal.DataSource = dt1.Tables[0].DefaultView;
                     cb_sucursal.ValueMember = "id_suc";
                     cb_sucursal.DisplayMember = "nombre";*/
                    DataTable dt1 = Sucursal.CargarcomboBox();
                    cb_sucursal.DataSource = dt1.DefaultView;
                    cb_sucursal.ValueMember = "id_suc";     // con esto rellena el combobox
                    cb_sucursal.DisplayMember = "nombre";  // con esto rellena el combobox

                }
                else
                {
                    Funciones.MError(this, suc.Mensaje);
                    this.Close();
                }
            }
            catch (Exception)
            {
                
                Funciones.MError(this, "No existe conexion con la base de datos o no se puede inicializar el login");
                this.Close();
            }

        }


        private void bto_Ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.Trim();
            string password = txt_passw.Text.Trim();
            int trabajandoen = Convert.ToInt32(cb_sucursal.SelectedValue);

            if (trabajandoen > 0)
            {
                if (Usuario.Validar(usuario, password))
                {
                    //Usuario.Validar(usuario, password);
                    string sucursal = cb_sucursal.Text.Trim();
                    Frm_contenedor frm = new Frm_contenedor(usuario, sucursal);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    Funciones.MError(this, "Password y usuario no coinciden");
                    txt_usuario.Focus();
                }
            }
            else 
            {
                Funciones.MError(this, "Debe seleccionar una sucursal de trabajo");
                txt_usuario.Focus();
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                if (txt_usuario.Text.Trim().Length >= 5)
                {

                    txt_passw.Focus();
                }
                else
                {

                    Funciones.MError(this, "Debe ingresar el usuario el cual tienen mas de 5 o +caracteres");
                }
            }
        }

        private void txt_passw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                if (txt_passw.Text.Trim().Length >= 8)
                {
                    cb_sucursal.Focus();
                }
                else
                {
                    Funciones.MError(this, "Debe ingresar el password el cual tienen mas de 8 o + caracteres");
                }
            }
        }

        private void cb_sucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bto_Ingresar.Focus();
            }
        }
    }
}
