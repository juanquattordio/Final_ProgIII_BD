
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
            this.txt_desc_marca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // chBox_Activos
            // 
            this.chBox_Activos.AutoSize = true;
            this.chBox_Activos.Checked = true;
            this.chBox_Activos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBox_Activos.Location = new System.Drawing.Point(147, 229);
            this.chBox_Activos.Name = "chBox_Activos";
            this.chBox_Activos.Size = new System.Drawing.Size(107, 21);
            this.chBox_Activos.TabIndex = 22;
            this.chBox_Activos.Text = "Sólo Activos";
            this.chBox_Activos.UseVisualStyleBackColor = true;
            // 
            // txt_desc_marca
            // 
            this.txt_desc_marca.Location = new System.Drawing.Point(240, 108);
            this.txt_desc_marca.Name = "txt_desc_marca";
            this.txt_desc_marca.Size = new System.Drawing.Size(181, 22);
            this.txt_desc_marca.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Direccion";
            // 
            // bto_eliminar
            // 
            this.bto_eliminar.Location = new System.Drawing.Point(247, 529);
            this.bto_eliminar.Name = "bto_eliminar";
            this.bto_eliminar.Size = new System.Drawing.Size(105, 44);
            this.bto_eliminar.TabIndex = 24;
            this.bto_eliminar.Text = "Eliminar";
            this.bto_eliminar.UseVisualStyleBackColor = true;
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
            this.dgv_marcas.Location = new System.Drawing.Point(139, 256);
            this.dgv_marcas.Name = "dgv_marcas";
            this.dgv_marcas.ReadOnly = true;
            this.dgv_marcas.RowHeadersWidth = 51;
            this.dgv_marcas.RowTemplate.Height = 24;
            this.dgv_marcas.Size = new System.Drawing.Size(825, 247);
            this.dgv_marcas.TabIndex = 23;
            // 
            // id_marca
            // 
            this.id_marca.DataPropertyName = "id_marca";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_marca.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_marca.HeaderText = "ID Marca";
            this.id_marca.MinimumWidth = 6;
            this.id_marca.Name = "id_marca";
            this.id_marca.ReadOnly = true;
            this.id_marca.Width = 60;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.bto_Salir.Location = new System.Drawing.Point(657, 529);
            this.bto_Salir.Name = "bto_Salir";
            this.bto_Salir.Size = new System.Drawing.Size(105, 44);
            this.bto_Salir.TabIndex = 25;
            this.bto_Salir.Text = "Salir";
            this.bto_Salir.UseVisualStyleBackColor = true;
            // 
            // bto_limpiar
            // 
            this.bto_limpiar.Location = new System.Drawing.Point(859, 132);
            this.bto_limpiar.Name = "bto_limpiar";
            this.bto_limpiar.Size = new System.Drawing.Size(105, 44);
            this.bto_limpiar.TabIndex = 21;
            this.bto_limpiar.Text = "Limpiar";
            this.bto_limpiar.UseVisualStyleBackColor = true;
            // 
            // bto_aceptar
            // 
            this.bto_aceptar.Location = new System.Drawing.Point(859, 82);
            this.bto_aceptar.Name = "bto_aceptar";
            this.bto_aceptar.Size = new System.Drawing.Size(105, 44);
            this.bto_aceptar.TabIndex = 20;
            this.bto_aceptar.Text = "Guardar";
            this.bto_aceptar.UseVisualStyleBackColor = true;
            // 
            // txt_nombre_marca
            // 
            this.txt_nombre_marca.Location = new System.Drawing.Point(240, 143);
            this.txt_nombre_marca.Name = "txt_nombre_marca";
            this.txt_nombre_marca.Size = new System.Drawing.Size(181, 22);
            this.txt_nombre_marca.TabIndex = 18;
            // 
            // txt_id_marca
            // 
            this.txt_id_marca.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_marca.Location = new System.Drawing.Point(240, 73);
            this.txt_id_marca.Name = "txt_id_marca";
            this.txt_id_marca.Size = new System.Drawing.Size(181, 22);
            this.txt_id_marca.TabIndex = 28;
            this.txt_id_marca.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Telefono";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo proveedor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(602, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(542, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 22);
            this.textBox2.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "IBB n°";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(542, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 22);
            this.textBox3.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cuit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "DNI";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(542, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 22);
            this.textBox4.TabIndex = 31;
            // 
            // Frm_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 595);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chBox_Activos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
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
            this.Name = "Frm_proveedores";
            this.Text = "Frm_proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chBox_Activos;
        private System.Windows.Forms.TextBox txt_desc_marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bto_eliminar;
        private System.Windows.Forms.DataGridView dgv_marcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_marca;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.Button bto_Salir;
        private System.Windows.Forms.Button bto_limpiar;
        private System.Windows.Forms.Button bto_aceptar;
        private System.Windows.Forms.TextBox txt_nombre_marca;
        private System.Windows.Forms.TextBox txt_id_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
    }
}