using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesRules;

namespace proyecto_punto_de_venta
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {

            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Poder validar datos vs BD vs fileEncrypt
                Usuarios mUsuarios = new Usuarios();
                mUsuarios.pwd = txtPassw.Text;
                mUsuarios.usuario = txtUser.Text;

                if (mUsuarios.fnValidaLogin())
                {
                    this.Close();
                    //ingresa en el sistema
                    //   main_menu main_Menu = new main_menu();
                    //   main_Menu.Show();
                    //los permisos del usuario que hizo login 


                }
                else
                {
                    MessageBox.Show("No es valido el usuario o contraseña", "Aviso POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPassw.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[btnIngresar_Click] " + ex.Message);
            }
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassw.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
