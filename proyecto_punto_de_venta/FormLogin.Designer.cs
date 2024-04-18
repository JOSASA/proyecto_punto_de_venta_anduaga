namespace proyecto_punto_de_venta
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            txtUser = new TextBox();
            txtPassw = new TextBox();
            labelUser = new Label();
            labelPassw = new Label();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 487);
            panel1.TabIndex = 0;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(453, 120);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 27);
            txtUser.TabIndex = 1;
            // 
            // txtPassw
            // 
            txtPassw.Location = new Point(453, 199);
            txtPassw.Name = "txtPassw";
            txtPassw.Size = new Size(125, 27);
            txtPassw.TabIndex = 2;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(498, 97);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(38, 20);
            labelUser.TabIndex = 3;
            labelUser.Text = "User";
            // 
            // labelPassw
            // 
            labelPassw.AutoSize = true;
            labelPassw.Location = new Point(482, 176);
            labelPassw.Name = "labelPassw";
            labelPassw.Size = new Size(70, 20);
            labelPassw.TabIndex = 4;
            labelPassw.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(468, 273);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(69, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 487);
            Controls.Add(btnLogin);
            Controls.Add(labelPassw);
            Controls.Add(labelUser);
            Controls.Add(txtPassw);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUser;
        private TextBox txtPassw;
        private Label labelUser;
        private Label labelPassw;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}