
namespace TP_programacionIII
{
    partial class Frm_productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chBox_Activos = new System.Windows.Forms.CheckBox();
            this.txt_tel_prov = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_direccion_prov = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bto_eliminar = new System.Windows.Forms.Button();
            this.dgv_prod = new System.Windows.Forms.DataGridView();
            this.id_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bto_Salir = new System.Windows.Forms.Button();
            this.bto_agregar_prov = new System.Windows.Forms.Button();
            this.bto_limpiar = new System.Windows.Forms.Button();
            this.bto_aceptar = new System.Windows.Forms.Button();
            this.txt_nombre_prod = new System.Windows.Forms.TextBox();
            this.txt_id_prod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descrip_prod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // chBox_Activos
            // 
            this.chBox_Activos.AutoSize = true;
            this.chBox_Activos.Checked = true;
            this.chBox_Activos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBox_Activos.Location = new System.Drawing.Point(95, 180);
            this.chBox_Activos.Name = "chBox_Activos";
            this.chBox_Activos.Size = new System.Drawing.Size(107, 21);
            this.chBox_Activos.TabIndex = 112;
            this.chBox_Activos.Text = "Sólo Activos";
            this.chBox_Activos.UseVisualStyleBackColor = true;
            this.chBox_Activos.CheckedChanged += new System.EventHandler(this.chBox_Activos_CheckedChanged);
            // 
            // txt_tel_prov
            // 
            this.txt_tel_prov.Enabled = false;
            this.txt_tel_prov.Location = new System.Drawing.Point(774, 152);
            this.txt_tel_prov.Name = "txt_tel_prov";
            this.txt_tel_prov.Size = new System.Drawing.Size(78, 22);
            this.txt_tel_prov.TabIndex = 103;
            this.txt_tel_prov.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 119;
            this.label5.Text = "Descripción";
            // 
            // txt_direccion_prov
            // 
            this.txt_direccion_prov.Enabled = false;
            this.txt_direccion_prov.Location = new System.Drawing.Point(774, 180);
            this.txt_direccion_prov.Name = "txt_direccion_prov";
            this.txt_direccion_prov.Size = new System.Drawing.Size(78, 22);
            this.txt_direccion_prov.TabIndex = 102;
            this.txt_direccion_prov.Text = "Agregar direccion...";
            this.txt_direccion_prov.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 118;
            this.label3.Text = "Proveedor";
            // 
            // bto_eliminar
            // 
            this.bto_eliminar.Location = new System.Drawing.Point(264, 482);
            this.bto_eliminar.Name = "bto_eliminar";
            this.bto_eliminar.Size = new System.Drawing.Size(105, 44);
            this.bto_eliminar.TabIndex = 114;
            this.bto_eliminar.Text = "Eliminar";
            this.bto_eliminar.UseVisualStyleBackColor = true;
            this.bto_eliminar.Click += new System.EventHandler(this.bto_eliminar_Click);
            // 
            // dgv_prod
            // 
            this.dgv_prod.AllowUserToAddRows = false;
            this.dgv_prod.AllowUserToDeleteRows = false;
            this.dgv_prod.AllowUserToOrderColumns = true;
            this.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prod,
            this.nombre,
            this.Descripcion,
            this.Activo});
            this.dgv_prod.Location = new System.Drawing.Point(87, 207);
            this.dgv_prod.Name = "dgv_prod";
            this.dgv_prod.ReadOnly = true;
            this.dgv_prod.RowHeadersWidth = 51;
            this.dgv_prod.RowTemplate.Height = 24;
            this.dgv_prod.Size = new System.Drawing.Size(765, 247);
            this.dgv_prod.TabIndex = 113;
            this.dgv_prod.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.modificar);
            // 
            // id_prod
            // 
            this.id_prod.DataPropertyName = "id_prod";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_prod.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_prod.HeaderText = "ID Prod";
            this.id_prod.MinimumWidth = 6;
            this.id_prod.Name = "id_prod";
            this.id_prod.ReadOnly = true;
            this.id_prod.Width = 30;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 65;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "baja";
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 50;
            // 
            // bto_Salir
            // 
            this.bto_Salir.Location = new System.Drawing.Point(674, 482);
            this.bto_Salir.Name = "bto_Salir";
            this.bto_Salir.Size = new System.Drawing.Size(105, 44);
            this.bto_Salir.TabIndex = 115;
            this.bto_Salir.Text = "Salir";
            this.bto_Salir.UseVisualStyleBackColor = true;
            this.bto_Salir.Click += new System.EventHandler(this.bto_Salir_Click);
            // 
            // bto_agregar_prov
            // 
            this.bto_agregar_prov.Location = new System.Drawing.Point(188, 105);
            this.bto_agregar_prov.Name = "bto_agregar_prov";
            this.bto_agregar_prov.Size = new System.Drawing.Size(105, 44);
            this.bto_agregar_prov.TabIndex = 111;
            this.bto_agregar_prov.Text = "Proveedores asociados";
            this.bto_agregar_prov.UseVisualStyleBackColor = true;
            this.bto_agregar_prov.Click += new System.EventHandler(this.bto_agregar_prov_Click);
            // 
            // bto_limpiar
            // 
            this.bto_limpiar.Location = new System.Drawing.Point(747, 68);
            this.bto_limpiar.Name = "bto_limpiar";
            this.bto_limpiar.Size = new System.Drawing.Size(105, 44);
            this.bto_limpiar.TabIndex = 109;
            this.bto_limpiar.Text = "Limpiar";
            this.bto_limpiar.UseVisualStyleBackColor = true;
            this.bto_limpiar.Click += new System.EventHandler(this.bto_limpiar_Click);
            // 
            // bto_aceptar
            // 
            this.bto_aceptar.Location = new System.Drawing.Point(747, 18);
            this.bto_aceptar.Name = "bto_aceptar";
            this.bto_aceptar.Size = new System.Drawing.Size(105, 44);
            this.bto_aceptar.TabIndex = 108;
            this.bto_aceptar.Text = "Guardar";
            this.bto_aceptar.UseVisualStyleBackColor = true;
            this.bto_aceptar.Click += new System.EventHandler(this.bto_aceptar_Click);
            // 
            // txt_nombre_prod
            // 
            this.txt_nombre_prod.Location = new System.Drawing.Point(188, 57);
            this.txt_nombre_prod.Name = "txt_nombre_prod";
            this.txt_nombre_prod.Size = new System.Drawing.Size(181, 22);
            this.txt_nombre_prod.TabIndex = 101;
            // 
            // txt_id_prod
            // 
            this.txt_id_prod.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_prod.Location = new System.Drawing.Point(188, 24);
            this.txt_id_prod.Name = "txt_id_prod";
            this.txt_id_prod.Size = new System.Drawing.Size(181, 22);
            this.txt_id_prod.TabIndex = 124;
            this.txt_id_prod.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 117;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 116;
            this.label1.Text = "ID Producto";
            // 
            // txt_descrip_prod
            // 
            this.txt_descrip_prod.Location = new System.Drawing.Point(397, 57);
            this.txt_descrip_prod.MaximumSize = new System.Drawing.Size(200, 100);
            this.txt_descrip_prod.MinimumSize = new System.Drawing.Size(300, 100);
            this.txt_descrip_prod.Name = "txt_descrip_prod";
            this.txt_descrip_prod.Size = new System.Drawing.Size(300, 100);
            this.txt_descrip_prod.TabIndex = 125;
            // 
            // Frm_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.txt_descrip_prod);
            this.Controls.Add(this.chBox_Activos);
            this.Controls.Add(this.txt_tel_prov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_direccion_prov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bto_eliminar);
            this.Controls.Add(this.dgv_prod);
            this.Controls.Add(this.bto_Salir);
            this.Controls.Add(this.bto_agregar_prov);
            this.Controls.Add(this.bto_limpiar);
            this.Controls.Add(this.bto_aceptar);
            this.Controls.Add(this.txt_nombre_prod);
            this.Controls.Add(this.txt_id_prod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_productos";
            this.Text = "Frm_productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chBox_Activos;
        private System.Windows.Forms.TextBox txt_tel_prov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_direccion_prov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bto_eliminar;
        private System.Windows.Forms.DataGridView dgv_prod;
        private System.Windows.Forms.Button bto_Salir;
        private System.Windows.Forms.Button bto_agregar_prov;
        private System.Windows.Forms.Button bto_limpiar;
        private System.Windows.Forms.Button bto_aceptar;
        private System.Windows.Forms.TextBox txt_nombre_prod;
        private System.Windows.Forms.TextBox txt_id_prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descrip_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}