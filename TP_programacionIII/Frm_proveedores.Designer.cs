
namespace TP_programacionIII
{
    partial class Frm_proveedores
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
            this.txt_direccion_prov = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bto_eliminar = new System.Windows.Forms.Button();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.bto_Salir = new System.Windows.Forms.Button();
            this.bto_limpiar = new System.Windows.Forms.Button();
            this.bto_aceptar = new System.Windows.Forms.Button();
            this.txt_nombre_prov = new System.Windows.Forms.TextBox();
            this.txt_id_prov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tel_prov = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_tipo_prov = new System.Windows.Forms.ComboBox();
            this.txt_ibb_prov = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cuit_prov = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dni_prov = new System.Windows.Forms.TextBox();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // chBox_Activos
            // 
            this.chBox_Activos.AutoSize = true;
            this.chBox_Activos.Checked = true;
            this.chBox_Activos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBox_Activos.Location = new System.Drawing.Point(51, 180);
            this.chBox_Activos.Name = "chBox_Activos";
            this.chBox_Activos.Size = new System.Drawing.Size(107, 21);
            this.chBox_Activos.TabIndex = 22;
            this.chBox_Activos.Text = "Sólo Activos";
            this.chBox_Activos.UseVisualStyleBackColor = true;
            this.chBox_Activos.CheckedChanged += new System.EventHandler(this.chBox_Activos_CheckedChanged);
            // 
            // txt_direccion_prov
            // 
            this.txt_direccion_prov.Location = new System.Drawing.Point(144, 94);
            this.txt_direccion_prov.Name = "txt_direccion_prov";
            this.txt_direccion_prov.Size = new System.Drawing.Size(181, 22);
            this.txt_direccion_prov.TabIndex = 2;
            this.txt_direccion_prov.Text = "Agregar direccion...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Direccion";
            // 
            // bto_eliminar
            // 
            this.bto_eliminar.Location = new System.Drawing.Point(220, 482);
            this.bto_eliminar.Name = "bto_eliminar";
            this.bto_eliminar.Size = new System.Drawing.Size(105, 44);
            this.bto_eliminar.TabIndex = 24;
            this.bto_eliminar.Text = "Eliminar";
            this.bto_eliminar.UseVisualStyleBackColor = true;
            this.bto_eliminar.Click += new System.EventHandler(this.bto_eliminar_Click);
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.AllowUserToAddRows = false;
            this.dgv_proveedores.AllowUserToDeleteRows = false;
            this.dgv_proveedores.AllowUserToOrderColumns = true;
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proveedor,
            this.nombre,
            this.direccion_prov,
            this.telefono,
            this.tipo_prov,
            this.cuit,
            this.IBB,
            this.DNI,
            this.Activo});
            this.dgv_proveedores.Location = new System.Drawing.Point(43, 207);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.ReadOnly = true;
            this.dgv_proveedores.RowHeadersWidth = 51;
            this.dgv_proveedores.RowTemplate.Height = 24;
            this.dgv_proveedores.Size = new System.Drawing.Size(894, 247);
            this.dgv_proveedores.TabIndex = 23;
            this.dgv_proveedores.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.modificar);
            // 
            // bto_Salir
            // 
            this.bto_Salir.Location = new System.Drawing.Point(630, 482);
            this.bto_Salir.Name = "bto_Salir";
            this.bto_Salir.Size = new System.Drawing.Size(105, 44);
            this.bto_Salir.TabIndex = 25;
            this.bto_Salir.Text = "Salir";
            this.bto_Salir.UseVisualStyleBackColor = true;
            this.bto_Salir.Click += new System.EventHandler(this.bto_Salir_Click);
            // 
            // bto_limpiar
            // 
            this.bto_limpiar.Location = new System.Drawing.Point(763, 83);
            this.bto_limpiar.Name = "bto_limpiar";
            this.bto_limpiar.Size = new System.Drawing.Size(105, 44);
            this.bto_limpiar.TabIndex = 21;
            this.bto_limpiar.Text = "Limpiar";
            this.bto_limpiar.UseVisualStyleBackColor = true;
            this.bto_limpiar.Click += new System.EventHandler(this.bto_limpiar_Click);
            // 
            // bto_aceptar
            // 
            this.bto_aceptar.Location = new System.Drawing.Point(763, 33);
            this.bto_aceptar.Name = "bto_aceptar";
            this.bto_aceptar.Size = new System.Drawing.Size(105, 44);
            this.bto_aceptar.TabIndex = 20;
            this.bto_aceptar.Text = "Guardar";
            this.bto_aceptar.UseVisualStyleBackColor = true;
            this.bto_aceptar.Click += new System.EventHandler(this.bto_aceptar_Click);
            // 
            // txt_nombre_prov
            // 
            this.txt_nombre_prov.Location = new System.Drawing.Point(144, 57);
            this.txt_nombre_prov.Name = "txt_nombre_prov";
            this.txt_nombre_prov.Size = new System.Drawing.Size(181, 22);
            this.txt_nombre_prov.TabIndex = 1;
            // 
            // txt_id_prov
            // 
            this.txt_id_prov.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_prov.Location = new System.Drawing.Point(144, 24);
            this.txt_id_prov.Name = "txt_id_prov";
            this.txt_id_prov.Size = new System.Drawing.Size(181, 22);
            this.txt_id_prov.TabIndex = 100;
            this.txt_id_prov.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Telefono";
            // 
            // txt_tel_prov
            // 
            this.txt_tel_prov.Location = new System.Drawing.Point(144, 129);
            this.txt_tel_prov.Name = "txt_tel_prov";
            this.txt_tel_prov.Size = new System.Drawing.Size(181, 22);
            this.txt_tel_prov.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo proveedor";
            // 
            // cb_tipo_prov
            // 
            this.cb_tipo_prov.FormattingEnabled = true;
            this.cb_tipo_prov.Items.AddRange(new object[] {
            "Minorista",
            "Mayorista"});
            this.cb_tipo_prov.Location = new System.Drawing.Point(506, 21);
            this.cb_tipo_prov.Name = "cb_tipo_prov";
            this.cb_tipo_prov.Size = new System.Drawing.Size(121, 24);
            this.cb_tipo_prov.TabIndex = 4;
            this.cb_tipo_prov.SelectedValueChanged += new System.EventHandler(this.cb_tipo_prov_SelectedValueChanged);
            // 
            // txt_ibb_prov
            // 
            this.txt_ibb_prov.Enabled = false;
            this.txt_ibb_prov.Location = new System.Drawing.Point(446, 96);
            this.txt_ibb_prov.Name = "txt_ibb_prov";
            this.txt_ibb_prov.Size = new System.Drawing.Size(181, 22);
            this.txt_ibb_prov.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "IBB n°";
            // 
            // txt_cuit_prov
            // 
            this.txt_cuit_prov.Enabled = false;
            this.txt_cuit_prov.Location = new System.Drawing.Point(446, 60);
            this.txt_cuit_prov.Name = "txt_cuit_prov";
            this.txt_cuit_prov.Size = new System.Drawing.Size(181, 22);
            this.txt_cuit_prov.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cuit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "DNI";
            // 
            // txt_dni_prov
            // 
            this.txt_dni_prov.Enabled = false;
            this.txt_dni_prov.Location = new System.Drawing.Point(446, 132);
            this.txt_dni_prov.Name = "txt_dni_prov";
            this.txt_dni_prov.Size = new System.Drawing.Size(181, 22);
            this.txt_dni_prov.TabIndex = 7;
            // 
            // id_proveedor
            // 
            this.id_proveedor.DataPropertyName = "id_proveedor";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_proveedor.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_proveedor.HeaderText = "ID Prov";
            this.id_proveedor.MinimumWidth = 6;
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            this.id_proveedor.Width = 30;
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
            // direccion_prov
            // 
            this.direccion_prov.DataPropertyName = "direccion";
            this.direccion_prov.HeaderText = "Direccion";
            this.direccion_prov.MinimumWidth = 6;
            this.direccion_prov.Name = "direccion_prov";
            this.direccion_prov.ReadOnly = true;
            this.direccion_prov.Width = 250;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 80;
            // 
            // tipo_prov
            // 
            this.tipo_prov.DataPropertyName = "tipo_prov";
            this.tipo_prov.HeaderText = "Tipo";
            this.tipo_prov.MinimumWidth = 6;
            this.tipo_prov.Name = "tipo_prov";
            this.tipo_prov.ReadOnly = true;
            this.tipo_prov.Width = 50;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "cuit";
            this.cuit.HeaderText = "Cuit";
            this.cuit.MinimumWidth = 6;
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            this.cuit.Width = 80;
            // 
            // IBB
            // 
            this.IBB.DataPropertyName = "IBB";
            this.IBB.HeaderText = "IBB";
            this.IBB.MinimumWidth = 6;
            this.IBB.Name = "IBB";
            this.IBB.ReadOnly = true;
            this.IBB.Width = 85;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 65;
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
            // Frm_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 546);
            this.Controls.Add(this.txt_ibb_prov);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_dni_prov);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cuit_prov);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_tipo_prov);
            this.Controls.Add(this.chBox_Activos);
            this.Controls.Add(this.txt_tel_prov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_direccion_prov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bto_eliminar);
            this.Controls.Add(this.dgv_proveedores);
            this.Controls.Add(this.bto_Salir);
            this.Controls.Add(this.bto_limpiar);
            this.Controls.Add(this.bto_aceptar);
            this.Controls.Add(this.txt_nombre_prov);
            this.Controls.Add(this.txt_id_prov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_proveedores";
            this.Text = "Frm_proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chBox_Activos;
        private System.Windows.Forms.TextBox txt_direccion_prov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bto_eliminar;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.Button bto_Salir;
        private System.Windows.Forms.Button bto_limpiar;
        private System.Windows.Forms.Button bto_aceptar;
        private System.Windows.Forms.TextBox txt_nombre_prov;
        private System.Windows.Forms.TextBox txt_id_prov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tel_prov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_tipo_prov;
        private System.Windows.Forms.TextBox txt_ibb_prov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cuit_prov;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dni_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}