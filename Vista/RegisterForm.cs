using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;

namespace Vista
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            textPass.UseSystemPasswordChar = true;
        }

        private void Error(string Msg, bool Visible)
        {
            lblError.Text = (Msg);
            lblError.Visible = Visible;
        }

        #region Control de Interfaz

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // El codigo de arriba hace que sea posible arrastrar la interfaz
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #region Usuario
        private void textUser_Enter(object sender, EventArgs e)
        {
            if(textUser.Text == "Usuario")
            {
                textUser.Clear();
            }
            textUser.ForeColor = Color.FromArgb (99,99,150);
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "Usuario";
            }
            textUser.ForeColor = Color.DimGray;
        }

        #endregion

        #region Contraseña
        
        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "Contraseña")
            {
                textPass.Clear();
            }
            textPass.ForeColor = Color.FromArgb(99, 99, 150);
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "Contraseña";
            }
            textPass.ForeColor = Color.DimGray;
        }
        
        #endregion
        
        #region Nombre
        
        private void textNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Text == "Nombre")
            {
                textNombre.Clear();
            }
            textNombre.ForeColor = Color.FromArgb(99, 99, 150);

        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                textNombre.Text = "Nombre";
            }
            textNombre.ForeColor = Color.DimGray;
        }

        #endregion

        #region Apellido

        private void textApellido_Enter(object sender, EventArgs e)
        {
            if (textApellido.Text == "Apellido")
            {
                textApellido.Clear();
            }
            textApellido.ForeColor = Color.FromArgb(99, 99, 150);
        }

        private void textApellido_Leave(object sender, EventArgs e)
        {
            if (textApellido.Text == "")
            {
                textApellido.Text = "Apellido";
            }
            textApellido.ForeColor = Color.DimGray;
        }

        #endregion

        // Censurar Contraseña
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (textPass.UseSystemPasswordChar == true)
            {
                textPass.UseSystemPasswordChar = false;
            }
            else
            {
                if (textPass.UseSystemPasswordChar == false)
                {
                    textPass.UseSystemPasswordChar = true;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Checkeos
        private bool UserCheck ()
        {
            if (textUser.Text == "Usuario" || string.IsNullOrWhiteSpace(textUser.Text) == true)
            {
                Error("Introduzca un usuario valido", true);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ContraseñaCheck ()
        {
            if (textPass.Text == "Contraseña" || string.IsNullOrWhiteSpace(textPass.Text) == true)
            {
                Error("Introduzca una contraseña valida", true);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool NombreCheck ()
        {
            if (textNombre.Text == "Nombre" || string.IsNullOrWhiteSpace(textNombre.Text) == true)
            {
                Error("Ingrese un nombre", true);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ApellidoCheck ()
        {
            if (textApellido.Text == "Apellido" || string.IsNullOrWhiteSpace(textApellido.Text) == true)
            {
                Error("Ingrese un apellido", true);
                return false;
            }
            else
            {
                return true;
            }

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool AC = ApellidoCheck();
            bool NC =NombreCheck();
            bool CC = ContraseñaCheck();
            bool UC = UserCheck();
            if (AC == true && NC == true && CC == true && UC == true)
            {
                try
                {
                    SelectorComandos Peticion = new SelectorComandos();
                    Peticion.Consulta("VerificarUsuario", textUser.Text);
                    if (Peticion.Resultado.Rows.Count == 0)
                    {
                        Peticion.Consulta("Registrar", textUser.Text, textPass.Text, textNombre.Text, textApellido.Text);
                        this.Hide();
                        LoginForm frm = new LoginForm();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ocupado");
                    }
                }
                catch
                {}
            }
        }

        #endregion

        // Lanzar nuevo form
        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Show();
        }
    }
}
