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
            this.pgPedidos = new System.Windows.Forms.TabPage();
            this.pgHistorial = new System.Windows.Forms.TabPage();
            this.pgConsultar = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.pgAgregar.SuspendLayout();
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(304, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "pipe";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(149, 85);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(304, 22);
            this.txtCorreo.TabIndex = 1;
            this.txtCorreo.Text = "pipe@gmail.com";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(149, 128);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(304, 22);
            this.txtDomicilio.TabIndex = 2;
            this.txtDomicilio.Text = "Calle XXX";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Domicilio";
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(149, 187);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(85, 68);
            this.btnGuardarCliente.TabIndex = 6;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
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
    }
}

