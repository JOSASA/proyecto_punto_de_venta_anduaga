namespace proyecto_punto_de_venta.Forms
{
    partial class FormConfiguraciones
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
            panel1 = new Panel();
            buttonClientes = new Button();
            buttonProveedores = new Button();
            panelConfig = new Panel();
            moneda = new Label();
            tasaIVA = new Label();
            correo = new Label();
            label5 = new Label();
            sucursalNombre = new Label();
            direccion = new Label();
            rfc = new Label();
            nombreEmpresa = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonClientes);
            panel1.Controls.Add(buttonProveedores);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 63);
            panel1.TabIndex = 8;
            // 
            // buttonClientes
            // 
            buttonClientes.Location = new Point(108, 0);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(101, 63);
            buttonClientes.TabIndex = 1;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonProveedores
            // 
            buttonProveedores.Location = new Point(1, 0);
            buttonProveedores.Name = "buttonProveedores";
            buttonProveedores.Size = new Size(101, 63);
            buttonProveedores.TabIndex = 0;
            buttonProveedores.Text = "Proveedores";
            buttonProveedores.UseVisualStyleBackColor = true;
            // 
            // panelConfig
            // 
            panelConfig.Dock = DockStyle.Fill;
            panelConfig.Location = new Point(0, 63);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(800, 387);
            panelConfig.TabIndex = 9;
            // 
            // moneda
            // 
            moneda.AutoSize = true;
            moneda.Location = new Point(317, 345);
            moneda.Name = "moneda";
            moneda.Size = new Size(64, 20);
            moneda.TabIndex = 17;
            moneda.Text = "Moneda";
            // 
            // tasaIVA
            // 
            tasaIVA.AutoSize = true;
            tasaIVA.Location = new Point(317, 301);
            tasaIVA.Name = "tasaIVA";
            tasaIVA.Size = new Size(84, 20);
            tasaIVA.TabIndex = 16;
            tasaIVA.Text = "Tasa de IVA";
            // 
            // correo
            // 
            correo.AutoSize = true;
            correo.Location = new Point(317, 270);
            correo.Name = "correo";
            correo.Size = new Size(54, 20);
            correo.TabIndex = 15;
            correo.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 232);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 14;
            label5.Text = "Direccion de la Sucursal";
            // 
            // sucursalNombre
            // 
            sucursalNombre.AutoSize = true;
            sucursalNombre.Location = new Point(317, 194);
            sucursalNombre.Name = "sucursalNombre";
            sucursalNombre.Size = new Size(159, 20);
            sucursalNombre.TabIndex = 13;
            sucursalNombre.Text = "Nombre de la Sucursal";
            // 
            // direccion
            // 
            direccion.AutoSize = true;
            direccion.Location = new Point(317, 155);
            direccion.Name = "direccion";
            direccion.Size = new Size(72, 20);
            direccion.TabIndex = 12;
            direccion.Text = "Direccion";
            // 
            // rfc
            // 
            rfc.AutoSize = true;
            rfc.Location = new Point(317, 120);
            rfc.Name = "rfc";
            rfc.Size = new Size(34, 20);
            rfc.TabIndex = 11;
            rfc.Text = "RFC";
            // 
            // nombreEmpresa
            // 
            nombreEmpresa.AutoSize = true;
            nombreEmpresa.Location = new Point(317, 85);
            nombreEmpresa.Name = "nombreEmpresa";
            nombreEmpresa.Size = new Size(162, 20);
            nombreEmpresa.TabIndex = 10;
            nombreEmpresa.Text = "Nombre de la Empresa";
            // 
            // FormConfiguraciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(moneda);
            Controls.Add(tasaIVA);
            Controls.Add(correo);
            Controls.Add(label5);
            Controls.Add(sucursalNombre);
            Controls.Add(direccion);
            Controls.Add(rfc);
            Controls.Add(nombreEmpresa);
            Controls.Add(panelConfig);
            Controls.Add(panel1);
            Name = "FormConfiguraciones";
            Text = "FormSetting";
            Load += FormConfiguraciones_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelConfig;
        private Button buttonClientes;
        private Button buttonProveedores;
        private Label moneda;
        private Label tasaIVA;
        private Label correo;
        private Label label5;
        private Label sucursalNombre;
        private Label direccion;
        private Label rfc;
        private Label nombreEmpresa;
    }
}