
namespace TP_programacionIII
{
    partial class Frm_precios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_precios));
            this.txt_nombre_prod = new System.Windows.Forms.TextBox();
            this.txt_id_prod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_prov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre_marca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.dgv_precios = new System.Windows.Forms.DataGridView();
            this.id_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_dvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bto_limpiar = new System.Windows.Forms.Button();
            this.bto_aceptar = new System.Windows.Forms.Button();
            this.bto_eliminar = new System.Windows.Forms.Button();
            this.bto_Salir = new System.Windows.Forms.Button();
            this.txt_id_precio = new System.Windows.Forms.TextBox();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.id_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_marcas = new System.Windows.Forms.DataGridView();
            this.id_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_id_prov = new System.Windows.Forms.TextBox();
            this.txt_id_marca = new System.Windows.Forms.TextBox();
            this.txt_tipo_prov = new System.Windows.Forms.TextBox();
            this.tipoProv = new System.Windows.Forms.Label();
            this.txt_margen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.txt_nombre_moneda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_precios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre_prod
            // 
            this.txt_nombre_prod.BackColor = System.Drawing.Color.LightGray;
            this.txt_nombre_prod.Enabled = false;
            this.txt_nombre_prod.Location = new System.Drawing.Point(174, 30);
            this.txt_nombre_prod.Name = "txt_nombre_prod";
            this.txt_nombre_prod.Size = new System.Drawing.Size(181, 22);
            this.txt_nombre_prod.TabIndex = 125;
            // 
            // txt_id_prod
            // 
            this.txt_id_prod.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_prod.Enabled = false;
            this.txt_id_prod.Location = new System.Drawing.Point(60, 490);
            this.txt_id_prod.Name = "txt_id_prod";
            this.txt_id_prod.Size = new System.Drawing.Size(27, 22);
            this.txt_id_prod.TabIndex = 128;
            this.txt_id_prod.Text = "0";
            this.txt_id_prod.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 127;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 127;
            this.label3.Text = "Proveedor";
            // 
            // txt_nombre_prov
            // 
            this.txt_nombre_prov.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_nombre_prov.Enabled = false;
            this.txt_nombre_prov.Location = new System.Drawing.Point(174, 68);
            this.txt_nombre_prov.Name = "txt_nombre_prov";
            this.txt_nombre_prov.Size = new System.Drawing.Size(181, 22);
            this.txt_nombre_prov.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 127;
            this.label4.Text = "Marca";
            // 
            // txt_nombre_marca
            // 
            this.txt_nombre_marca.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_nombre_marca.Enabled = false;
            this.txt_nombre_marca.Location = new System.Drawing.Point(174, 108);
            this.txt_nombre_marca.Name = "txt_nombre_marca";
            this.txt_nombre_marca.Size = new System.Drawing.Size(181, 22);
            this.txt_nombre_marca.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 127;
            this.label5.Text = "Moneda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 127;
            this.label6.Text = "Precio compra";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(592, 64);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(128, 22);
            this.txt_precio.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 127;
            this.label7.Text = "Fecha";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(174, 146);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(181, 22);
            this.txt_fecha.TabIndex = 1;
            // 
            // dgv_precios
            // 
            this.dgv_precios.AllowUserToAddRows = false;
            this.dgv_precios.AllowUserToDeleteRows = false;
            this.dgv_precios.AllowUserToOrderColumns = true;
            this.dgv_precios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_precios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_precio,
            this.IDProveedor,
            this.IdMarca,
            this.nombre_prov,
            this.nombre_marca,
            this.Fecha,
            this.Moneda,
            this.precio_dvg,
            this.baja,
            this.id_prod,
            this.tipoProveedor});
            this.dgv_precios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_precios.Location = new System.Drawing.Point(45, 204);
            this.dgv_precios.Name = "dgv_precios";
            this.dgv_precios.ReadOnly = true;
            this.dgv_precios.RowHeadersWidth = 51;
            this.dgv_precios.RowTemplate.Height = 24;
            this.dgv_precios.Size = new System.Drawing.Size(722, 234);
            this.dgv_precios.TabIndex = 131;
            this.dgv_precios.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.modificarPrecio);
            // 
            // id_precio
            // 
            this.id_precio.DataPropertyName = "id_precio";
            this.id_precio.HeaderText = "id_precio";
            this.id_precio.MinimumWidth = 6;
            this.id_precio.Name = "id_precio";
            this.id_precio.ReadOnly = true;
            this.id_precio.Visible = false;
            this.id_precio.Width = 125;
            // 
            // IDProveedor
            // 
            this.IDProveedor.DataPropertyName = "id_prov";
            this.IDProveedor.HeaderText = "Id_prov";
            this.IDProveedor.MinimumWidth = 6;
            this.IDProveedor.Name = "IDProveedor";
            this.IDProveedor.ReadOnly = true;
            this.IDProveedor.Visible = false;
            this.IDProveedor.Width = 125;
            // 
            // IdMarca
            // 
            this.IdMarca.DataPropertyName = "id_marca";
            this.IdMarca.HeaderText = "id_marca";
            this.IdMarca.MinimumWidth = 6;
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.ReadOnly = true;
            this.IdMarca.Visible = false;
            this.IdMarca.Width = 125;
            // 
            // nombre_prov
            // 
            this.nombre_prov.DataPropertyName = "nombre_prov";
            this.nombre_prov.HeaderText = "Proveedor";
            this.nombre_prov.MinimumWidth = 6;
            this.nombre_prov.Name = "nombre_prov";
            this.nombre_prov.ReadOnly = true;
            this.nombre_prov.Width = 120;
            // 
            // nombre_marca
            // 
            this.nombre_marca.DataPropertyName = "nombre_marca";
            this.nombre_marca.HeaderText = "Marca";
            this.nombre_marca.MinimumWidth = 6;
            this.nombre_marca.Name = "nombre_marca";
            this.nombre_marca.ReadOnly = true;
            this.nombre_marca.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "precio_fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 60;
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "moneda_desc";
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.MinimumWidth = 6;
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            this.Moneda.Width = 50;
            // 
            // precio_dvg
            // 
            this.precio_dvg.DataPropertyName = "precio_valor";
            this.precio_dvg.HeaderText = "Precio";
            this.precio_dvg.MinimumWidth = 6;
            this.precio_dvg.Name = "precio_dvg";
            this.precio_dvg.ReadOnly = true;
            this.precio_dvg.Width = 125;
            // 
            // baja
            // 
            this.baja.DataPropertyName = "baja";
            this.baja.HeaderText = "Activo";
            this.baja.MinimumWidth = 6;
            this.baja.Name = "baja";
            this.baja.ReadOnly = true;
            this.baja.Width = 50;
            // 
            // id_prod
            // 
            this.id_prod.DataPropertyName = "id_prod";
            this.id_prod.HeaderText = "Id Producto";
            this.id_prod.MinimumWidth = 6;
            this.id_prod.Name = "id_prod";
            this.id_prod.ReadOnly = true;
            this.id_prod.Visible = false;
            this.id_prod.Width = 125;
            // 
            // tipoProveedor
            // 
            this.tipoProveedor.DataPropertyName = "tipo_prov";
            this.tipoProveedor.HeaderText = "TipoProv";
            this.tipoProveedor.MinimumWidth = 6;
            this.tipoProveedor.Name = "tipoProveedor";
            this.tipoProveedor.ReadOnly = true;
            this.tipoProveedor.Visible = false;
            this.tipoProveedor.Width = 10;
            // 
            // bto_limpiar
            // 
            this.bto_limpiar.Location = new System.Drawing.Point(481, 146);
            this.bto_limpiar.Name = "bto_limpiar";
            this.bto_limpiar.Size = new System.Drawing.Size(105, 44);
            this.bto_limpiar.TabIndex = 4;
            this.bto_limpiar.Text = "Limpiar";
            this.bto_limpiar.UseVisualStyleBackColor = true;
            this.bto_limpiar.Click += new System.EventHandler(this.bto_limpiar_Click);
            // 
            // bto_aceptar
            // 
            this.bto_aceptar.Location = new System.Drawing.Point(615, 146);
            this.bto_aceptar.Name = "bto_aceptar";
            this.bto_aceptar.Size = new System.Drawing.Size(105, 44);
            this.bto_aceptar.TabIndex = 5;
            this.bto_aceptar.Text = "Guardar";
            this.bto_aceptar.UseVisualStyleBackColor = true;
            this.bto_aceptar.Click += new System.EventHandler(this.bto_aceptar_Click);
            // 
            // bto_eliminar
            // 
            this.bto_eliminar.Location = new System.Drawing.Point(277, 455);
            this.bto_eliminar.Name = "bto_eliminar";
            this.bto_eliminar.Size = new System.Drawing.Size(105, 44);
            this.bto_eliminar.TabIndex = 6;
            this.bto_eliminar.Text = "Eliminar";
            this.bto_eliminar.UseVisualStyleBackColor = true;
            this.bto_eliminar.Click += new System.EventHandler(this.bto_eliminar_Click);
            // 
            // bto_Salir
            // 
            this.bto_Salir.Location = new System.Drawing.Point(423, 455);
            this.bto_Salir.Name = "bto_Salir";
            this.bto_Salir.Size = new System.Drawing.Size(105, 44);
            this.bto_Salir.TabIndex = 7;
            this.bto_Salir.Text = "Salir";
            this.bto_Salir.UseVisualStyleBackColor = true;
            this.bto_Salir.Click += new System.EventHandler(this.bto_Salir_Click);
            // 
            // txt_id_precio
            // 
            this.txt_id_precio.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_precio.Location = new System.Drawing.Point(12, 490);
            this.txt_id_precio.Name = "txt_id_precio";
            this.txt_id_precio.Size = new System.Drawing.Size(42, 22);
            this.txt_id_precio.TabIndex = 136;
            this.txt_id_precio.Text = "0";
            this.txt_id_precio.Visible = false;
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.AllowUserToAddRows = false;
            this.dgv_proveedores.AllowUserToDeleteRows = false;
            this.dgv_proveedores.AllowUserToOrderColumns = true;
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prov,
            this.nombre,
            this.tipo_prov,
            this.cuit,
            this.IBB,
            this.DNI,
            this.dataGridViewCheckBoxColumn1});
            this.dgv_proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_proveedores.Location = new System.Drawing.Point(807, 12);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.ReadOnly = true;
            this.dgv_proveedores.RowHeadersWidth = 51;
            this.dgv_proveedores.RowTemplate.Height = 24;
            this.dgv_proveedores.Size = new System.Drawing.Size(346, 247);
            this.dgv_proveedores.TabIndex = 137;
            this.dgv_proveedores.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selectProv);
            // 
            // id_prov
            // 
            this.id_prov.DataPropertyName = "id_proveedor";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_prov.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_prov.HeaderText = "ID Prov";
            this.id_prov.MinimumWidth = 6;
            this.id_prov.Name = "id_prov";
            this.id_prov.ReadOnly = true;
            this.id_prov.Width = 30;
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
            this.nombre.Width = 120;
            // 
            // tipo_prov
            // 
            this.tipo_prov.DataPropertyName = "tipo_prov";
            this.tipo_prov.HeaderText = "Tipo";
            this.tipo_prov.MinimumWidth = 6;
            this.tipo_prov.Name = "tipo_prov";
            this.tipo_prov.ReadOnly = true;
            this.tipo_prov.Width = 65;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "cuit";
            this.cuit.HeaderText = "Cuit";
            this.cuit.MinimumWidth = 6;
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            this.cuit.Visible = false;
            this.cuit.Width = 80;
            // 
            // IBB
            // 
            this.IBB.DataPropertyName = "IBB";
            this.IBB.HeaderText = "IBB";
            this.IBB.MinimumWidth = 6;
            this.IBB.Name = "IBB";
            this.IBB.ReadOnly = true;
            this.IBB.Visible = false;
            this.IBB.Width = 85;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Visible = false;
            this.DNI.Width = 65;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "baja";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dgv_marcas
            // 
            this.dgv_marcas.AllowUserToAddRows = false;
            this.dgv_marcas.AllowUserToDeleteRows = false;
            this.dgv_marcas.AllowUserToOrderColumns = true;
            this.dgv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_marca,
            this.nombreMarca,
            this.descripcion_marca,
            this.Activo});
            this.dgv_marcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_marcas.Location = new System.Drawing.Point(807, 265);
            this.dgv_marcas.Name = "dgv_marcas";
            this.dgv_marcas.ReadOnly = true;
            this.dgv_marcas.RowHeadersWidth = 51;
            this.dgv_marcas.RowTemplate.Height = 24;
            this.dgv_marcas.Size = new System.Drawing.Size(346, 247);
            this.dgv_marcas.TabIndex = 138;
            this.dgv_marcas.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selectMarca);
            // 
            // id_marca
            // 
            this.id_marca.DataPropertyName = "id_marca";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_marca.DefaultCellStyle = dataGridViewCellStyle3;
            this.id_marca.HeaderText = "ID Marca";
            this.id_marca.MinimumWidth = 6;
            this.id_marca.Name = "id_marca";
            this.id_marca.ReadOnly = true;
            this.id_marca.Width = 40;
            // 
            // nombreMarca
            // 
            this.nombreMarca.DataPropertyName = "nombre";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nombreMarca.DefaultCellStyle = dataGridViewCellStyle4;
            this.nombreMarca.HeaderText = "Marca";
            this.nombreMarca.MinimumWidth = 6;
            this.nombreMarca.Name = "nombreMarca";
            this.nombreMarca.ReadOnly = true;
            this.nombreMarca.Width = 130;
            // 
            // descripcion_marca
            // 
            this.descripcion_marca.DataPropertyName = "descripcion";
            this.descripcion_marca.HeaderText = "Descripcion";
            this.descripcion_marca.MinimumWidth = 6;
            this.descripcion_marca.Name = "descripcion_marca";
            this.descripcion_marca.ReadOnly = true;
            this.descripcion_marca.Visible = false;
            this.descripcion_marca.Width = 300;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "baja";
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Visible = false;
            this.Activo.Width = 80;
            // 
            // txt_id_prov
            // 
            this.txt_id_prov.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_prov.Enabled = false;
            this.txt_id_prov.Location = new System.Drawing.Point(12, 518);
            this.txt_id_prov.Name = "txt_id_prov";
            this.txt_id_prov.Size = new System.Drawing.Size(27, 22);
            this.txt_id_prov.TabIndex = 139;
            this.txt_id_prov.Text = "0";
            this.txt_id_prov.Visible = false;
            // 
            // txt_id_marca
            // 
            this.txt_id_marca.BackColor = System.Drawing.Color.LightGray;
            this.txt_id_marca.Enabled = false;
            this.txt_id_marca.Location = new System.Drawing.Point(45, 518);
            this.txt_id_marca.Name = "txt_id_marca";
            this.txt_id_marca.Size = new System.Drawing.Size(27, 22);
            this.txt_id_marca.TabIndex = 140;
            this.txt_id_marca.Text = "0";
            this.txt_id_marca.Visible = false;
            // 
            // txt_tipo_prov
            // 
            this.txt_tipo_prov.Location = new System.Drawing.Point(95, 466);
            this.txt_tipo_prov.Name = "txt_tipo_prov";
            this.txt_tipo_prov.Size = new System.Drawing.Size(85, 22);
            this.txt_tipo_prov.TabIndex = 125;
            this.txt_tipo_prov.Visible = false;
            // 
            // tipoProv
            // 
            this.tipoProv.AutoSize = true;
            this.tipoProv.Location = new System.Drawing.Point(22, 469);
            this.tipoProv.Name = "tipoProv";
            this.tipoProv.Size = new System.Drawing.Size(67, 17);
            this.tipoProv.TabIndex = 127;
            this.tipoProv.Text = "tipo_prov";
            this.tipoProv.Visible = false;
            // 
            // txt_margen
            // 
            this.txt_margen.Enabled = false;
            this.txt_margen.Location = new System.Drawing.Point(554, 103);
            this.txt_margen.Name = "txt_margen";
            this.txt_margen.Size = new System.Drawing.Size(128, 22);
            this.txt_margen.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 142;
            this.label1.Text = "Margen venta";
            // 
            // refresh
            // 
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(688, 101);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 27);
            this.refresh.TabIndex = 143;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // txt_nombre_moneda
            // 
            this.txt_nombre_moneda.FormattingEnabled = true;
            this.txt_nombre_moneda.Items.AddRange(new object[] {
            "Peso",
            "Dolar",
            "Euro",
            "Franco Suizo",
            "Real"});
            this.txt_nombre_moneda.Location = new System.Drawing.Point(540, 27);
            this.txt_nombre_moneda.Name = "txt_nombre_moneda";
            this.txt_nombre_moneda.Size = new System.Drawing.Size(180, 24);
            this.txt_nombre_moneda.TabIndex = 2;
            // 
            // Frm_precios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 543);
            this.Controls.Add(this.txt_nombre_moneda);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.txt_margen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_marca);
            this.Controls.Add(this.txt_id_prov);
            this.Controls.Add(this.dgv_marcas);
            this.Controls.Add(this.dgv_proveedores);
            this.Controls.Add(this.txt_id_precio);
            this.Controls.Add(this.bto_eliminar);
            this.Controls.Add(this.bto_Salir);
            this.Controls.Add(this.bto_limpiar);
            this.Controls.Add(this.bto_aceptar);
            this.Controls.Add(this.dgv_precios);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_tipo_prov);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tipoProv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nombre_marca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre_prov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre_prod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id_prod);
            this.Controls.Add(this.label2);
            this.Name = "Frm_precios";
            this.Text = "Frm_precios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_precios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre_prod;
        private System.Windows.Forms.TextBox txt_id_prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_prov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre_marca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.DataGridView dgv_precios;
        private System.Windows.Forms.Button bto_limpiar;
        private System.Windows.Forms.Button bto_aceptar;
        private System.Windows.Forms.Button bto_eliminar;
        private System.Windows.Forms.Button bto_Salir;
        private System.Windows.Forms.TextBox txt_id_precio;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.DataGridView dgv_marcas;
        private System.Windows.Forms.TextBox txt_id_prov;
        private System.Windows.Forms.TextBox txt_id_marca;
        private System.Windows.Forms.TextBox txt_tipo_prov;
        private System.Windows.Forms.Label tipoProv;
        private System.Windows.Forms.TextBox txt_margen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_dvg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProveedor;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ComboBox txt_nombre_moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_marca;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}