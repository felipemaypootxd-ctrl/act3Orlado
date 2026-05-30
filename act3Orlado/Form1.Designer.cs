namespace act3Orlado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pgAgregar = new System.Windows.Forms.TabPage();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pgPedidos = new System.Windows.Forms.TabPage();
            this.pgHistorial = new System.Windows.Forms.TabPage();
            this.pgConsultar = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.pgAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pgAgregar);
            this.tabControl1.Controls.Add(this.pgPedidos);
            this.tabControl1.Controls.Add(this.pgHistorial);
            this.tabControl1.Controls.Add(this.pgConsultar);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 100);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // pgAgregar
            // 
            this.pgAgregar.Controls.Add(this.dgvClientes);
            this.pgAgregar.Controls.Add(this.txtTelefono);
            this.pgAgregar.Controls.Add(this.label4);
            this.pgAgregar.Controls.Add(this.btnGuardarCliente);
            this.pgAgregar.Controls.Add(this.label3);
            this.pgAgregar.Controls.Add(this.label2);
            this.pgAgregar.Controls.Add(this.label1);
            this.pgAgregar.Controls.Add(this.txtDomicilio);
            this.pgAgregar.Controls.Add(this.txtCorreo);
            this.pgAgregar.Controls.Add(this.txtNombre);
            this.pgAgregar.ImageIndex = 0;
            this.pgAgregar.Location = new System.Drawing.Point(4, 104);
            this.pgAgregar.Name = "pgAgregar";
            this.pgAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.pgAgregar.Size = new System.Drawing.Size(792, 339);
            this.pgAgregar.TabIndex = 0;
            this.pgAgregar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(517, 49);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(85, 68);
            this.btnGuardarCliente.TabIndex = 6;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Domicilio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(149, 128);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(304, 22);
            this.txtDomicilio.TabIndex = 2;
            this.txtDomicilio.Text = "Calle XXX";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(149, 85);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(304, 22);
            this.txtCorreo.TabIndex = 1;
            this.txtCorreo.Text = "pipe@gmail.com";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(304, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "pipe";
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // pgPedidos
            // 
            this.pgPedidos.ImageIndex = 1;
            this.pgPedidos.Location = new System.Drawing.Point(4, 104);
            this.pgPedidos.Name = "pgPedidos";
            this.pgPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.pgPedidos.Size = new System.Drawing.Size(792, 339);
            this.pgPedidos.TabIndex = 1;
            this.pgPedidos.UseVisualStyleBackColor = true;
            // 
            // pgHistorial
            // 
            this.pgHistorial.ImageIndex = 3;
            this.pgHistorial.Location = new System.Drawing.Point(4, 104);
            this.pgHistorial.Name = "pgHistorial";
            this.pgHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.pgHistorial.Size = new System.Drawing.Size(792, 339);
            this.pgHistorial.TabIndex = 2;
            this.pgHistorial.UseVisualStyleBackColor = true;
            // 
            // pgConsultar
            // 
            this.pgConsultar.ImageIndex = 4;
            this.pgConsultar.Location = new System.Drawing.Point(4, 104);
            this.pgConsultar.Name = "pgConsultar";
            this.pgConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.pgConsultar.Size = new System.Drawing.Size(792, 339);
            this.pgConsultar.TabIndex = 3;
            this.pgConsultar.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "agregar.png");
            this.imageList1.Images.SetKeyName(1, "registrar.png");
            this.imageList1.Images.SetKeyName(2, "total.png");
            this.imageList1.Images.SetKeyName(3, "mostrar.png");
            this.imageList1.Images.SetKeyName(4, "consultar.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(149, 171);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(304, 22);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.Text = "999 999 99 99";
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvClientes.Location = new System.Drawing.Point(83, 199);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(639, 122);
            this.dgvClientes.TabIndex = 9;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Correo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Domicilio";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.pgAgregar.ResumeLayout(false);
            this.pgAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pgAgregar;
        private System.Windows.Forms.TabPage pgPedidos;
        private System.Windows.Forms.TabPage pgHistorial;
        private System.Windows.Forms.TabPage pgConsultar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

