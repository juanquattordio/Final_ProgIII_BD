namespace TP_programacionIII
{
    partial class Frm_sucursales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_suc = new System.Windows.Forms.TextBox();
            this.txt_nombre_suc = new System.Windows.Forms.TextBox();
            this.bto_aceptar = new System.Windows.Forms.Button();
            this.bto_Salir = new System.Windows.Forms.Button();
            this.dgv_sucursales = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bto_eliminar = new System.Windows.Forms.Button();
            this.bto_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro_sucursal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txt_id_suc
            // 
            this.txt_id_suc.Location = new System.Drawing.Point(146, 49);
            this.txt_id_suc.Name = "txt_id_suc";
            this.txt_id_suc.Size = new System.Drawing.Size(181, 22);
            this.txt_id_suc.TabIndex = 2;
            this.txt_id_suc.Text = "0";
            // 
            // txt_nombre_suc
            // 
            this.txt_nombre_suc.Location = new System.Drawing.Point(146, 81);
            this.txt_nombre_suc.Name = "txt_nombre_suc";
            this.txt_nombre_suc.Size = new System.Drawing.Size(181, 22);
            this.txt_nombre_suc.TabIndex = 3;
            // 
            // bto_aceptar
            // 
            this.bto_aceptar.Location = new System.Drawing.Point(463, 31);
            this.bto_aceptar.Name = "bto_aceptar";
            this.bto_aceptar.Size = new System.Drawing.Size(105, 44);
            this.bto_aceptar.TabIndex = 4;
            this.bto_aceptar.Text = "Guardar";
            this.bto_aceptar.UseVisualStyleBackColor = true;
            this.bto_aceptar.Click += new System.EventHandler(this.bto_aceptar_Click);
            // 
            // bto_Salir
            // 
            this.bto_Salir.Location = new System.Drawing.Point(463, 413);
            this.bto_Salir.Name = "bto_Salir";
            this.bto_Salir.Size = new System.Drawing.Size(105, 44);
            this.bto_Salir.TabIndex = 5;
            this.bto_Salir.Text = "Salir";
            this.bto_Salir.UseVisualStyleBackColor = true;
            this.bto_Salir.Click += new System.EventHandler(this.bto_Salir_Click);
            // 
            // dgv_sucursales
            // 
            this.dgv_sucursales.AllowUserToAddRows = false;
            this.dgv_sucursales.AllowUserToDeleteRows = false;
            this.dgv_sucursales.AllowUserToOrderColumns = true;
            this.dgv_sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre});
            this.dgv_sucursales.Location = new System.Drawing.Point(49, 147);
            this.dgv_sucursales.Name = "dgv_sucursales";
            this.dgv_sucursales.ReadOnly = true;
            this.dgv_sucursales.RowHeadersWidth = 51;
            this.dgv_sucursales.RowTemplate.Height = 24;
            this.dgv_sucursales.Size = new System.Drawing.Size(533, 247);
            this.dgv_sucursales.TabIndex = 6;
            this.dgv_sucursales.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.modificar);
            // 
            // id
            // 
            this.id.DataPropertyName = "id_suc";
            this.id.HeaderText = "Nro Suc";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.nombre.HeaderText = "Nombre Sucursal";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 350;
            // 
            // bto_eliminar
            // 
            this.bto_eliminar.Location = new System.Drawing.Point(49, 413);
            this.bto_eliminar.Name = "bto_eliminar";
            this.bto_eliminar.Size = new System.Drawing.Size(105, 44);
            this.bto_eliminar.TabIndex = 7;
            this.bto_eliminar.Text = "Eliminar";
            this.bto_eliminar.UseVisualStyleBackColor = true;
            this.bto_eliminar.Click += new System.EventHandler(this.bto_eliminar_Click);
            // 
            // bto_limpiar
            // 
            this.bto_limpiar.Location = new System.Drawing.Point(463, 81);
            this.bto_limpiar.Name = "bto_limpiar";
            this.bto_limpiar.Size = new System.Drawing.Size(105, 44);
            this.bto_limpiar.TabIndex = 5;
            this.bto_limpiar.Text = "Limpiar";
            this.bto_limpiar.UseVisualStyleBackColor = true;
            this.bto_limpiar.Click += new System.EventHandler(this.bto_limpiar_Click);
            // 
            // Frm_sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 502);
            this.Controls.Add(this.bto_eliminar);
            this.Controls.Add(this.dgv_sucursales);
            this.Controls.Add(this.bto_Salir);
            this.Controls.Add(this.bto_limpiar);
            this.Controls.Add(this.bto_aceptar);
            this.Controls.Add(this.txt_nombre_suc);
            this.Controls.Add(this.txt_id_suc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_sucursales";
            this.Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_suc;
        private System.Windows.Forms.TextBox txt_nombre_suc;
        private System.Windows.Forms.Button bto_aceptar;
        private System.Windows.Forms.Button bto_Salir;
        private System.Windows.Forms.DataGridView dgv_sucursales;
        private System.Windows.Forms.Button bto_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Button bto_limpiar;
    }
}