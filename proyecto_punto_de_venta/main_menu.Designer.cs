namespace proyecto_punto_de_venta
{
    partial class main_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            panel1 = new Panel();
            btnInventario = new Button();
            btnVentas = new Button();
            btnSettings = new Button();
            btnCompras = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnProveedores = new Button();
            btnUsuarios = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnCompras);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 515);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnInventario
            // 
            btnInventario.AccessibleDescription = "";
            btnInventario.AccessibleName = "";
            btnInventario.BackColor = Color.Purple;
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleRight;
            btnInventario.Location = new Point(0, 410);
            btnInventario.Margin = new Padding(3, 2, 3, 2);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(10, 0, 0, 0);
            btnInventario.RightToLeft = RightToLeft.Yes;
            btnInventario.Size = new Size(192, 50);
            btnInventario.TabIndex = 11;
            btnInventario.Text = "Inventario";
            btnInventario.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnVentas
            // 
            btnVentas.AccessibleDescription = "";
            btnVentas.AccessibleName = "";
            btnVentas.BackColor = Color.Purple;
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleRight;
            btnVentas.Location = new Point(0, 360);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(10, 0, 0, 0);
            btnVentas.RightToLeft = RightToLeft.Yes;
            btnVentas.Size = new Size(192, 50);
            btnVentas.TabIndex = 10;
            btnVentas.Text = "Ventas";
            btnVentas.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnSettings
            // 
            btnSettings.AccessibleDescription = "";
            btnSettings.AccessibleName = "";
            btnSettings.BackColor = Color.Purple;
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Tahoma", 11.25F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleRight;
            btnSettings.Location = new Point(0, 310);
            btnSettings.Margin = new Padding(3, 2, 3, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.RightToLeft = RightToLeft.Yes;
            btnSettings.Size = new Size(192, 50);
            btnSettings.TabIndex = 9;
            btnSettings.Text = "Config";
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnConfiguraciones_Click;
            // 
            // btnCompras
            // 
            btnCompras.AccessibleDescription = "";
            btnCompras.AccessibleName = "";
            btnCompras.BackColor = Color.Purple;
            btnCompras.Dock = DockStyle.Top;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCompras.ForeColor = Color.White;
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.ImageAlign = ContentAlignment.MiddleRight;
            btnCompras.Location = new Point(0, 260);
            btnCompras.Margin = new Padding(3, 2, 3, 2);
            btnCompras.Name = "btnCompras";
            btnCompras.Padding = new Padding(10, 0, 0, 0);
            btnCompras.RightToLeft = RightToLeft.Yes;
            btnCompras.Size = new Size(192, 50);
            btnCompras.TabIndex = 8;
            btnCompras.Text = "Compras";
            btnCompras.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnProductos
            // 
            btnProductos.AccessibleDescription = "";
            btnProductos.AccessibleName = "";
            btnProductos.BackColor = Color.Purple;
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleRight;
            btnProductos.Location = new Point(0, 210);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(10, 0, 0, 0);
            btnProductos.RightToLeft = RightToLeft.Yes;
            btnProductos.Size = new Size(192, 50);
            btnProductos.TabIndex = 7;
            btnProductos.Text = "Productos";
            btnProductos.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.AccessibleDescription = "";
            btnClientes.AccessibleName = "";
            btnClientes.BackColor = Color.Purple;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = Properties.Resources.icons8_clientes_48;
            btnClientes.ImageAlign = ContentAlignment.MiddleRight;
            btnClientes.Location = new Point(0, 160);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(10, 0, 0, 0);
            btnClientes.RightToLeft = RightToLeft.Yes;
            btnClientes.Size = new Size(192, 50);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "Clientes";
            btnClientes.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.AccessibleDescription = "";
            btnProveedores.AccessibleName = "";
            btnProveedores.BackColor = Color.Purple;
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Image = Properties.Resources.icons8_proveedor_48;
            btnProveedores.ImageAlign = ContentAlignment.MiddleRight;
            btnProveedores.Location = new Point(0, 110);
            btnProveedores.Margin = new Padding(3, 2, 3, 2);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(10, 0, 0, 0);
            btnProveedores.RightToLeft = RightToLeft.Yes;
            btnProveedores.Size = new Size(192, 50);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.AccessibleDescription = "";
            btnUsuarios.AccessibleName = "";
            btnUsuarios.BackColor = Color.Purple;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleRight;
            btnUsuarios.Location = new Point(0, 60);
            btnUsuarios.Margin = new Padding(3, 2, 3, 2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(10, 0, 0, 0);
            btnUsuarios.RightToLeft = RightToLeft.Yes;
            btnUsuarios.Size = new Size(192, 50);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Purple;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.ImeMode = ImeMode.NoControl;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(192, 60);
            panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(192, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(886, 60);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Transparent;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(847, 7);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 26);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.BackColor = Color.Transparent;
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Margin = new Padding(3, 2, 3, 2);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(64, 60);
            btnCloseChildForm.TabIndex = 2;
            btnCloseChildForm.UseVisualStyleBackColor = false;
            btnCloseChildForm.Click += btnCloseChildForm_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(401, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Home";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(pictureBox1);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(192, 60);
            panelDesktopPane.Margin = new Padding(3, 2, 3, 2);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(886, 455);
            panelDesktopPane.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 453);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // main_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 515);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "main_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += main_menu_Load;
            panel1.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelLogo;
        private Button button4;
        private Button btnUsuarios;
        private Button btnClientes;
        private Button btnProveedores;
        private Button btnCompras;
        private Button btnProductos;
        private Button btnSettings;
        private Label lblTitle;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private PictureBox pictureBox1;
        internal Panel panelTitleBar;
        private Button btnClose;
        private Button btnInventario;
        private Button btnVentas;
    }
}
