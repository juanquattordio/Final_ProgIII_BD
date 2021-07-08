
namespace TP_programacionIII
{
    partial class Frm_direcciones
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
            this.txt_id_dir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_codigo_postal = new System.Windows.Forms.TextBox();
            this.txt_nombre_prov = new System.Windows.Forms.TextBox();
            this.txt_id_prov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chBox_Activos = new System.Windows.Forms.CheckBox();
            this.bto_eliminar = new System.Windows.Forms.Button();
            this.dgv_direcciones = new System.Windows.Forms.DataGridView();
            this.bto_Salir = new System.Windows.Forms.Button();
            this.bto_limpiar = new System.Windows.Forms.Button();
            this.bto_aceptar = new System.Windows.Forms.Button();
            this.txt_provincia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id_dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_direcciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id_dir
            // 
            this.txt_id_dir.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_dir.Location = new System.Drawing.Point(27, 37);
            this.txt_id_dir.Name = "txt_id_dir";
            this.txt_id_dir.Size = new System.Drawing.Size(42, 22);
            this.txt_id_dir.TabIndex = 121;
            this.txt_id_dir.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 120;
            this.label3.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 119;
            this.label1.Text = "Codigo Postal";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(171, 75);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(160, 22);
            this.txt_ciudad.TabIndex = 114;
            // 
            // txt_codigo_postal
            // 
            this.txt_codigo_postal.Location = new System.Drawing.Point(452, 131);
            this.txt_codigo_postal.Name = "txt_codigo_postal";
            this.txt_codigo_postal.Size = new System.Drawing.Size(119, 22);
            this.txt_codigo_postal.TabIndex = 115;
            // 
            // txt_nombre_prov
            // 
            this.txt_nombre_prov.BackColor = System.Drawing.Color.LightGray;
            this.txt_nombre_prov.Enabled = false;
            this.txt_nombre_prov.Location = new System.Drawing.Point(113, 37);
            this.txt_nombre_prov.Name = "txt_nombre_prov";
            this.txt_nombre_prov.Size = new System.Drawing.Size(218, 22);
            this.txt_nombre_prov.TabIndex = 116;
            // 
            // txt_id_prov
            // 
            this.txt_id_prov.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_prov.Enabled = false;
            this.txt_id_prov.Location = new System.Drawing.Point(75, 37);
            this.txt_id_prov.Name = "txt_id_prov";
            this.txt_id_prov.Size = new System.Drawing.Size(32, 22);
            this.txt_id_prov.TabIndex = 118;
            this.txt_id_prov.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 117;
            this.label2.Text = "Nombre";
            // 
            // chBox_Activos
            // 
            this.chBox_Activos.AutoSize = true;
            this.chBox_Activos.Checked = true;
            this.chBox_Activos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBox_Activos.Location = new System.Drawing.Point(64, 193);
            this.chBox_Activos.Name = "chBox_Activos";
            this.chBox_Activos.Size = new System.Drawing.Size(107, 21);
            this.chBox_Activos.TabIndex = 110;
            this.chBox_Activos.Text = "Sólo Activos";
            this.chBox_Activos.UseVisualStyleBackColor = true;
            // 
            // bto_eliminar
            // 
            this.bto_eliminar.Location = new System.Drawing.Point(265, 364);
            this.bto_eliminar.Name = "bto_eliminar";
            this.bto_eliminar.Size = new System.Drawing.Size(105, 44);
            this.bto_eliminar.TabIndex = 112;
            this.bto_eliminar.Text = "Eliminar";
            this.bto_eliminar.UseVisualStyleBackColor = true;
            this.bto_eliminar.Click += new System.EventHandler(this.bto_eliminar_Click);
            // 
            // dgv_direcciones
            // 
            this.dgv_direcciones.AllowUserToAddRows = false;
            this.dgv_direcciones.AllowUserToDeleteRows = false;
            this.dgv_direcciones.AllowUserToOrderColumns = true;
            this.dgv_direcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_direcciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_dir,
            this.ciudad,
            this.provincia,
            this.pais,
            this.calle,
            this.numero,
            this.codigo_postal,
            this.id_proveedor,
            this.Activo});
            this.dgv_direcciones.Location = new System.Drawing.Point(62, 220);
            this.dgv_direcciones.Name = "dgv_direcciones";
            this.dgv_direcciones.ReadOnly = true;
            this.dgv_direcciones.RowHeadersWidth = 51;
            this.dgv_direcciones.RowTemplate.Height = 24;
            this.dgv_direcciones.Size = new System.Drawing.Size(668, 124);
            this.dgv_direcciones.TabIndex = 111;
            this.dgv_direcciones.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.modificar);
            // 
            // bto_Salir
            // 
            this.bto_Salir.Location = new System.Drawing.Point(411, 364);
            this.bto_Salir.Name = "bto_Salir";
            this.bto_Salir.Size = new System.Drawing.Size(105, 44);
            this.bto_Salir.TabIndex = 113;
            this.bto_Salir.Text = "Salir";
            this.bto_Salir.UseVisualStyleBackColor = true;
            this.bto_Salir.Click += new System.EventHandler(this.bto_Salir_Click);
            // 
            // bto_limpiar
            // 
            this.bto_limpiar.Location = new System.Drawing.Point(625, 120);
            this.bto_limpiar.Name = "bto_limpiar";
            this.bto_limpiar.Size = new System.Drawing.Size(105, 44);
            this.bto_limpiar.TabIndex = 109;
            this.bto_limpiar.Text = "Limpiar";
            this.bto_limpiar.UseVisualStyleBackColor = true;
            this.bto_limpiar.Click += new System.EventHandler(this.bto_limpiar_Click);
            // 
            // bto_aceptar
            // 
            this.bto_aceptar.Location = new System.Drawing.Point(625, 70);
            this.bto_aceptar.Name = "bto_aceptar";
            this.bto_aceptar.Size = new System.Drawing.Size(105, 44);
            this.bto_aceptar.TabIndex = 108;
            this.bto_aceptar.Text = "Guardar";
            this.bto_aceptar.UseVisualStyleBackColor = true;
            this.bto_aceptar.Click += new System.EventHandler(this.bto_aceptar_Click);
            // 
            // txt_provincia
            // 
            this.txt_provincia.Location = new System.Drawing.Point(185, 103);
            this.txt_provincia.Name = "txt_provincia";
            this.txt_provincia.Size = new System.Drawing.Size(146, 22);
            this.txt_provincia.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 120;
            this.label4.Text = "Provincia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 123;
            this.label5.Text = "País";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(185, 134);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(146, 22);
            this.txt_pais.TabIndex = 122;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(411, 75);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(160, 22);
            this.txt_calle.TabIndex = 114;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(425, 103);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(146, 22);
            this.txt_numero.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 120;
            this.label6.Text = "Calle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 120;
            this.label7.Text = "Numero";
            // 
            // id_dir
            // 
            this.id_dir.DataPropertyName = "id_dir";
            this.id_dir.HeaderText = "#";
            this.id_dir.MinimumWidth = 6;
            this.id_dir.Name = "id_dir";
            this.id_dir.ReadOnly = true;
            this.id_dir.Width = 20;
            // 
            // ciudad
            // 
            this.ciudad.DataPropertyName = "ciudad";
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.MinimumWidth = 6;
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            // 
            // provincia
            // 
            this.provincia.DataPropertyName = "provincia";
            this.provincia.HeaderText = "Provincia";
            this.provincia.MinimumWidth = 6;
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            // 
            // pais
            // 
            this.pais.DataPropertyName = "pais";
            this.pais.HeaderText = "País";
            this.pais.MinimumWidth = 6;
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Calle";
            this.calle.MinimumWidth = 6;
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Num.";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 40;
            // 
            // codigo_postal
            // 
            this.codigo_postal.DataPropertyName = "codigo_postal";
            this.codigo_postal.HeaderText = "Codigo postal";
            this.codigo_postal.MinimumWidth = 6;
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.ReadOnly = true;
            this.codigo_postal.Width = 70;
            // 
            // id_proveedor
            // 
            this.id_proveedor.DataPropertyName = "id_proveedor";
            this.id_proveedor.HeaderText = "Id Proveedor";
            this.id_proveedor.MinimumWidth = 6;
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            this.id_proveedor.Visible = false;
            this.id_proveedor.Width = 40;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "baja";
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 30;
            // 
            // Frm_direcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 493);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.txt_id_dir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_provincia);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.txt_codigo_postal);
            this.Controls.Add(this.txt_nombre_prov);
            this.Controls.Add(this.txt_id_prov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chBox_Activos);
            this.Controls.Add(this.bto_eliminar);
            this.Controls.Add(this.dgv_direcciones);
            this.Controls.Add(this.bto_Salir);
            this.Controls.Add(this.bto_limpiar);
            this.Controls.Add(this.bto_aceptar);
            this.Name = "Frm_direcciones";
            this.Text = "Frm_direcciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_direcciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id_dir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_codigo_postal;
        private System.Windows.Forms.TextBox txt_nombre_prov;
        private System.Windows.Forms.TextBox txt_id_prov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBox_Activos;
        private System.Windows.Forms.Button bto_eliminar;
        private System.Windows.Forms.DataGridView dgv_direcciones;
        private System.Windows.Forms.Button bto_Salir;
        private System.Windows.Forms.Button bto_limpiar;
        private System.Windows.Forms.Button bto_aceptar;
        private System.Windows.Forms.TextBox txt_provincia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}