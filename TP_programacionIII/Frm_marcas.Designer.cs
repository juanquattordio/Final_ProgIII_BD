
namespace TP_programacionIII
{
    partial class Frm_marcas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bto_eliminar = new System.Windows.Forms.Button();
            this.dgv_marcas = new System.Windows.Forms.DataGridView();
            this.id_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bto_Salir = new System.Windows.Forms.Button();
            this.bto_limpiar = new System.Windows.Forms.Button();
            this.bto_aceptar = new System.Windows.Forms.Button();
            this.txt_nombre_marca = new System.Windows.Forms.TextBox();
            this.txt_id_marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_desc_marca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chBox_Activos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // bto_eliminar
            // 
            this.bto_eliminar.Location = new System.Drawing.Point(156, 443);
            this.bto_eliminar.Name = "bto_eliminar";
            this.bto_eliminar.Size = new System.Drawing.Size(105, 44);
            this.bto_eliminar.TabIndex = 7;
            this.bto_eliminar.Text = "Eliminar";
            this.bto_eliminar.UseVisualStyleBackColor = true;
            this.bto_eliminar.Click += new System.EventHandler(this.bto_eliminar_Click);
            // 
            // dgv_marcas
            // 
            this.dgv_marcas.AllowUserToAddRows = false;
            this.dgv_marcas.AllowUserToDeleteRows = false;
            this.dgv_marcas.AllowUserToOrderColumns = true;
            this.dgv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_marca,
            this.nombre,
            this.descripcion_marca,
            this.Activo});
            this.dgv_marcas.Location = new System.Drawing.Point(48, 170);
            this.dgv_marcas.Name = "dgv_marcas";
            this.dgv_marcas.ReadOnly = true;
            this.dgv_marcas.RowHeadersWidth = 51;
            this.dgv_marcas.RowTemplate.Height = 24;
            this.dgv_marcas.Size = new System.Drawing.Size(825, 247);
            this.dgv_marcas.TabIndex = 6;
            this.dgv_marcas.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.modificar);
            // 
            // id_marca
            // 
            this.id_marca.DataPropertyName = "id_marca";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_marca.DefaultCellStyle = dataGridViewCellStyle5;
            this.id_marca.HeaderText = "ID Marca";
            this.id_marca.MinimumWidth = 6;
            this.id_marca.Name = "id_marca";
            this.id_marca.ReadOnly = true;
            this.id_marca.Width = 60;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle6;
            this.nombre.HeaderText = "Marca";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // descripcion_marca
            // 
            this.descripcion_marca.DataPropertyName = "descripcion";
            this.descripcion_marca.HeaderText = "Descripcion";
            this.descripcion_marca.MinimumWidth = 6;
            this.descripcion_marca.Name = "descripcion_marca";
            this.descripcion_marca.ReadOnly = true;
            this.descripcion_marca.Width = 300;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "baja";
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 80;
            // 
            // bto_Salir
            // 
            this.bto_Salir.Location = new System.Drawing.Point(566, 443);
            this.bto_Salir.Name = "bto_Salir";
            this.bto_Salir.Size = new System.Drawing.Size(105, 44);
            this.bto_Salir.TabIndex = 8;
            this.bto_Salir.Text = "Salir";
            this.bto_Salir.UseVisualStyleBackColor = true;
            this.bto_Salir.Click += new System.EventHandler(this.bto_Salir_Click);
            // 
            // bto_limpiar
            // 
            this.bto_limpiar.Location = new System.Drawing.Point(430, 84);
            this.bto_limpiar.Name = "bto_limpiar";
            this.bto_limpiar.Size = new System.Drawing.Size(105, 44);
            this.bto_limpiar.TabIndex = 4;
            this.bto_limpiar.Text = "Limpiar";
            this.bto_limpiar.UseVisualStyleBackColor = true;
            this.bto_limpiar.Click += new System.EventHandler(this.bto_limpiar_Click);
            // 
            // bto_aceptar
            // 
            this.bto_aceptar.Location = new System.Drawing.Point(430, 34);
            this.bto_aceptar.Name = "bto_aceptar";
            this.bto_aceptar.Size = new System.Drawing.Size(105, 44);
            this.bto_aceptar.TabIndex = 3;
            this.bto_aceptar.Text = "Guardar";
            this.bto_aceptar.UseVisualStyleBackColor = true;
            this.bto_aceptar.Click += new System.EventHandler(this.bto_aceptar_Click);
            // 
            // txt_nombre_marca
            // 
            this.txt_nombre_marca.Location = new System.Drawing.Point(149, 71);
            this.txt_nombre_marca.Name = "txt_nombre_marca";
            this.txt_nombre_marca.Size = new System.Drawing.Size(181, 22);
            this.txt_nombre_marca.TabIndex = 1;
            // 
            // txt_id_marca
            // 
            this.txt_id_marca.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_marca.Location = new System.Drawing.Point(149, 36);
            this.txt_id_marca.Name = "txt_id_marca";
            this.txt_id_marca.Size = new System.Drawing.Size(181, 22);
            this.txt_id_marca.TabIndex = 10;
            this.txt_id_marca.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Marca";
            // 
            // txt_desc_marca
            // 
            this.txt_desc_marca.Location = new System.Drawing.Point(149, 106);
            this.txt_desc_marca.Name = "txt_desc_marca";
            this.txt_desc_marca.Size = new System.Drawing.Size(181, 22);
            this.txt_desc_marca.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Descripción";
            // 
            // chBox_Activos
            // 
            this.chBox_Activos.AutoSize = true;
            this.chBox_Activos.Checked = true;
            this.chBox_Activos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBox_Activos.Location = new System.Drawing.Point(56, 143);
            this.chBox_Activos.Name = "chBox_Activos";
            this.chBox_Activos.Size = new System.Drawing.Size(107, 21);
            this.chBox_Activos.TabIndex = 5;
            this.chBox_Activos.Text = "Sólo Activos";
            this.chBox_Activos.UseVisualStyleBackColor = true;
            this.chBox_Activos.CheckedChanged += new System.EventHandler(this.chBox_Activos_CheckedChanged);
            // 
            // Frm_marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 517);
            this.Controls.Add(this.chBox_Activos);
            this.Controls.Add(this.txt_desc_marca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bto_eliminar);
            this.Controls.Add(this.dgv_marcas);
            this.Controls.Add(this.bto_Salir);
            this.Controls.Add(this.bto_limpiar);
            this.Controls.Add(this.bto_aceptar);
            this.Controls.Add(this.txt_nombre_marca);
            this.Controls.Add(this.txt_id_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_marcas";
            this.Text = "ABM-Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bto_eliminar;
        private System.Windows.Forms.DataGridView dgv_marcas;
        private System.Windows.Forms.Button bto_Salir;
        private System.Windows.Forms.Button bto_limpiar;
        private System.Windows.Forms.Button bto_aceptar;
        private System.Windows.Forms.TextBox txt_nombre_marca;
        private System.Windows.Forms.TextBox txt_id_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_desc_marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chBox_Activos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_marca;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}