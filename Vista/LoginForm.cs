using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
<<<<<<< HEAD
using System.Data;
using Logica;
=======
using System.Data.SqlClient;
>>>>>>> c619bff81e74ed8d367fba5402d395e56cfb5a5d

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textPass.UseSystemPasswordChar = true;
        }
        #region ControlInterfaz

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

        private void Error(string Msg, bool Visible)
        {
            lblError.Text = (Msg);
            lblError.Visible = Visible;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textUser.Text != "Usuario" && textPass.Text != "Contraseña" && string.IsNullOrWhiteSpace(textUser.Text) == false && string.IsNullOrWhiteSpace(textPass.Text) == false)
=======
            if (textUser.Text == "Usuario" && textPass.Text == "Contraseña")
>>>>>>> c619bff81e74ed8d367fba5402d395e56cfb5a5d
            {
                try
                {
                    SelectorComandos Peticion = new SelectorComandos();
                    Peticion.Consulta("VerificarUsuario", textUser.Text);
                    if(Peticion.Resultado.Rows.Count == 0)
                    {
                        Error("Usuario no registrado", true);
                    }
                    else if(Peticion.Resultado.Rows.Count > 0)
                    {
                        Peticion.Consulta("Login", textUser.Text, textPass.Text);
                        if(Peticion.Resultado.Rows.Count == 0)
                        {
                            Error("Contraseña incorrecta", true);
                        }
                        else if(Peticion.Resultado.Rows.Count > 0)
                        {
                            Profesor Interfaz = new Profesor(Peticion.Resultado.Rows[0]["Usuario"].ToString());
                            Interfaz.Show();
                            Error("", false);
                            this.Hide();
                        }
                    }
                }
                catch{}
                
            }
            else if ((textPass.Text == "Contraseña" && textUser.Text != "Usuario") || (string.IsNullOrWhiteSpace(textUser.Text) == false && string.IsNullOrWhiteSpace(textPass.Text) == true))
            {
                Error("Ingrese contraseña", true);
            }
            else if ((textUser.Text == "Usuario" && textPass.Text != "Contraseña") || (string.IsNullOrWhiteSpace(textUser.Text) == true && string.IsNullOrWhiteSpace(textPass.Text) == false))
            {
                Error("Ingrese usuario", true);
            }
            else
            {
                Error("Complete las casillas", true);
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm frm = new RegisterForm();
            frm.Show();
        }
    }
}
