namespace TP_programacionIII
{
    partial class Frm_login
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
            this.label2 = new System.Windows.Forms.Label();
            this.cb_sucursal = new System.Windows.Forms.ComboBox();
            this.lb_passw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_passw = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.bto_Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sucursal";
            // 
            // cb_sucursal
            // 
            this.cb_sucursal.AccessibleDescription = "+";
            this.cb_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sucursal.FormattingEnabled = true;
            this.cb_sucursal.Location = new System.Drawing.Point(138, 120);
            this.cb_sucursal.Name = "cb_sucursal";
            this.cb_sucursal.Size = new System.Drawing.Size(297, 28);
            this.cb_sucursal.TabIndex = 3;
            this.cb_sucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_sucursal_KeyPress);
            // 
            // lb_passw
            // 
            this.lb_passw.AutoSize = true;
            this.lb_passw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_passw.Location = new System.Drawing.Point(40, 73);
            this.lb_passw.Name = "lb_passw";
            this.lb_passw.Size = new System.Drawing.Size(83, 20);
            this.lb_passw.TabIndex = 12;
            this.lb_passw.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // txt_passw
            // 
            this.txt_passw.AccessibleDescription = "+";
            this.txt_passw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passw.Location = new System.Drawing.Point(138, 73);
            this.txt_passw.Name = "txt_passw";
            this.txt_passw.Size = new System.Drawing.Size(297, 27);
            this.txt_passw.TabIndex = 2;
            this.txt_passw.UseSystemPasswordChar = true;
            this.txt_passw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_passw_KeyPress);
            // 
            // txt_usuario
            // 
            this.txt_usuario.AccessibleDescription = "";
            this.txt_usuario.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(138, 28);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(297, 27);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            // 
            // bto_Ingresar
            // 
            this.bto_Ingresar.AccessibleDescription = "+";
            this.bto_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bto_Ingresar.Location = new System.Drawing.Point(519, 119);
            this.bto_Ingresar.Name = "bto_Ingresar";
            this.bto_Ingresar.Size = new System.Drawing.Size(136, 66);
            this.bto_Ingresar.TabIndex = 4;
            this.bto_Ingresar.Text = "&Ingresar";
            this.bto_Ingresar.UseVisualStyleBackColor = true;
            this.bto_Ingresar.Click += new System.EventHandler(this.bto_Ingresar_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 197);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_sucursal);
            this.Controls.Add(this.lb_passw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_passw);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.bto_Ingresar);
            this.Name = "Frm_login";
            this.Text = "Ingreso al Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_sucursal;
        private System.Windows.Forms.Label lb_passw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_passw;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button bto_Ingresar;
    }
}