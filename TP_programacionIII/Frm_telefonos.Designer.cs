
namespace TP_programacionIII
{
    partial class Frm_telefonos
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
            this.chBox_Activos = new System.Windows.Forms.CheckBox();
            this.bto_eliminar = new System.Windows.Forms.Button();
            this.dgv_telefonos = new System.Windows.Forms.DataGridView();
            this.bto_Salir = new System.Windows.Forms.Button();
            this.bto_limpiar = new System.Windows.Forms.Button();
            this.bto_aceptar = new System.Windows.Forms.Button();
            this.txt_nombre_prov = new System.Windows.Forms.TextBox();
            this.txt_id_prov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo_area = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_tel = new System.Windows.Forms.TextBox();
            this.id_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // chBox_Activos
            // 
            this.chBox_Activos.AutoSize = true;
            this.chBox_Activos.Checked = true;
            this.chBox_Activos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBox_Activos.Location = new System.Drawing.Point(102, 138);
            this.chBox_Activos.Name = "chBox_Activos";
            this.chBox_Activos.Size = new System.Drawing.Size(107, 21);
            this.chBox_Activos.TabIndex = 28;
            this.chBox_Activos.Text = "Sólo Activos";
            this.chBox_Activos.UseVisualStyleBackColor = true;
            // 
            // bto_eliminar
            // 
            this.bto_eliminar.Location = new System.Drawing.Point(173, 418);
            this.bto_eliminar.Name = "bto_eliminar";
            this.bto_eliminar.Size = new System.Drawing.Size(105, 44);
            this.bto_eliminar.TabIndex = 30;
            this.bto_eliminar.Text = "Eliminar";
            this.bto_eliminar.UseVisualStyleBackColor = true;
            this.bto_eliminar.Click += new System.EventHandler(this.bto_eliminar_Click);
            // 
            // dgv_telefonos
            // 
            this.dgv_telefonos.AllowUserToAddRows = false;
            this.dgv_telefonos.AllowUserToDeleteRows = false;
            this.dgv_telefonos.AllowUserToOrderColumns = true;
            this.dgv_telefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_telefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tel,
            this.codigo_area,
            this.telefono,
            this.Activo,
            this.id_proveedor});
            this.dgv_telefonos.Location = new System.Drawing.Point(98, 165);
            this.dgv_telefonos.Name = "dgv_telefonos";
            this.dgv_telefonos.ReadOnly = true;
            this.dgv_telefonos.RowHeadersWidth = 51;
            this.dgv_telefonos.RowTemplate.Height = 24;
            this.dgv_telefonos.Size = new System.Drawing.Size(407, 247);
            this.dgv_telefonos.TabIndex = 29;
            this.dgv_telefonos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.modificar);
            // 
            // bto_Salir
            // 
            this.bto_Salir.Location = new System.Drawing.Point(319, 418);
            this.bto_Salir.Name = "bto_Salir";
            this.bto_Salir.Size = new System.Drawing.Size(105, 44);
            this.bto_Salir.TabIndex = 31;
            this.bto_Salir.Text = "Salir";
            this.bto_Salir.UseVisualStyleBackColor = true;
            this.bto_Salir.Click += new System.EventHandler(this.bto_Salir_Click);
            // 
            // bto_limpiar
            // 
            this.bto_limpiar.Location = new System.Drawing.Point(400, 66);
            this.bto_limpiar.Name = "bto_limpiar";
            this.bto_limpiar.Size = new System.Drawing.Size(105, 44);
            this.bto_limpiar.TabIndex = 27;
            this.bto_limpiar.Text = "Limpiar";
            this.bto_limpiar.UseVisualStyleBackColor = true;
            this.bto_limpiar.Click += new System.EventHandler(this.bto_limpiar_Click);
            // 
            // bto_aceptar
            // 
            this.bto_aceptar.Location = new System.Drawing.Point(400, 16);
            this.bto_aceptar.Name = "bto_aceptar";
            this.bto_aceptar.Size = new System.Drawing.Size(105, 44);
            this.bto_aceptar.TabIndex = 26;
            this.bto_aceptar.Text = "Guardar";
            this.bto_aceptar.UseVisualStyleBackColor = true;
            this.bto_aceptar.Click += new System.EventHandler(this.bto_aceptar_Click);
            // 
            // txt_nombre_prov
            // 
            this.txt_nombre_prov.BackColor = System.Drawing.Color.LightGray;
            this.txt_nombre_prov.Enabled = false;
            this.txt_nombre_prov.Location = new System.Drawing.Point(149, 42);
            this.txt_nombre_prov.Name = "txt_nombre_prov";
            this.txt_nombre_prov.Size = new System.Drawing.Size(218, 22);
            this.txt_nombre_prov.TabIndex = 101;
            // 
            // txt_id_prov
            // 
            this.txt_id_prov.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_prov.Enabled = false;
            this.txt_id_prov.Location = new System.Drawing.Point(111, 42);
            this.txt_id_prov.Name = "txt_id_prov";
            this.txt_id_prov.Size = new System.Drawing.Size(32, 22);
            this.txt_id_prov.TabIndex = 104;
            this.txt_id_prov.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 103;
            this.label2.Text = "Nombre";
            // 
            // txt_codigo_area
            // 
            this.txt_codigo_area.Location = new System.Drawing.Point(248, 70);
            this.txt_codigo_area.Name = "txt_codigo_area";
            this.txt_codigo_area.Size = new System.Drawing.Size(119, 22);
            this.txt_codigo_area.TabIndex = 101;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(194, 98);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(173, 22);
            this.txt_telefono.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Codigo Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 106;
            this.label3.Text = "Tel";
            // 
            // txt_id_tel
            // 
            this.txt_id_tel.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_tel.Location = new System.Drawing.Point(63, 42);
            this.txt_id_tel.Name = "txt_id_tel";
            this.txt_id_tel.Size = new System.Drawing.Size(42, 22);
            this.txt_id_tel.TabIndex = 107;
            this.txt_id_tel.Text = "0";
            this.txt_id_tel.Visible = false;
            // 
            // id_tel
            // 
            this.id_tel.DataPropertyName = "id_tel";
            this.id_tel.HeaderText = "id_tel";
            this.id_tel.MinimumWidth = 6;
            this.id_tel.Name = "id_tel";
            this.id_tel.ReadOnly = true;
            this.id_tel.Visible = false;
            this.id_tel.Width = 125;
            // 
            // codigo_area
            // 
            this.codigo_area.DataPropertyName = "codigo_area";
            this.codigo_area.HeaderText = "Codigo area";
            this.codigo_area.MinimumWidth = 6;
            this.codigo_area.Name = "codigo_area";
            this.codigo_area.ReadOnly = true;
            this.codigo_area.Width = 70;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
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
            // id_proveedor
            // 
            this.id_proveedor.DataPropertyName = "id_proveedor";
            this.id_proveedor.HeaderText = "Id Proveedor";
            this.id_proveedor.MinimumWidth = 6;
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            this.id_proveedor.Visible = false;
            this.id_proveedor.Width = 125;
            // 
            // Frm_telefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 504);
            this.Controls.Add(this.txt_id_tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_codigo_area);
            this.Controls.Add(this.txt_nombre_prov);
            this.Controls.Add(this.txt_id_prov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chBox_Activos);
            this.Controls.Add(this.bto_eliminar);
            this.Controls.Add(this.dgv_telefonos);
            this.Controls.Add(this.bto_Salir);
            this.Controls.Add(this.bto_limpiar);
            this.Controls.Add(this.bto_aceptar);
            this.Name = "Frm_telefonos";
            this.Text = "Telefonos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chBox_Activos;
        private System.Windows.Forms.Button bto_eliminar;
        private System.Windows.Forms.DataGridView dgv_telefonos;
        private System.Windows.Forms.Button bto_Salir;
        private System.Windows.Forms.Button bto_limpiar;
        private System.Windows.Forms.Button bto_aceptar;
        private System.Windows.Forms.TextBox txt_nombre_prov;
        private System.Windows.Forms.TextBox txt_id_prov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo_area;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
    }
}