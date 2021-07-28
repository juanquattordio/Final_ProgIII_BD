using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_programacionIII
{
    public partial class Frm_contenedor : Form
    {
        private string usuario;
        private string sucursal;


        public Frm_contenedor(string usuario, string suc)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.sucursal = suc;
            this.Text = this.Text + " operando en sucursal: " + sucursal;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_usuarios").SingleOrDefault();
            if (frm != null)
            {

                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_usuarios();
                frm.MdiParent = this;
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_sucursales").SingleOrDefault();
            if (frm != null)
            {

                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_sucursales();
                frm.MdiParent = this;
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_marcas").SingleOrDefault();
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_marcas();
                frm.MdiParent = this;
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_proveedores").SingleOrDefault();
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_proveedores();
                frm.MdiParent = this;
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_productos").SingleOrDefault();
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_productos();
                frm.MdiParent = this;
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }

        }
    }
}
