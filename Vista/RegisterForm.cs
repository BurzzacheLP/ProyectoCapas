using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Vista
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            textPass.UseSystemPasswordChar = true;
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
        private void UserCheck (string userText)
        {
            userText = textUser.Text;
            if (userText == "Usuario")
            {
                lblError.Text = ("Introduzca un usuario valido");
                lblError.Visible = true;
            }
        }

        private void ContraseñaCheck (string passText)
        {
            passText = textPass.Text;
            if (textPass.Text == "Contraseña")
            {
                lblError.Text = ("Introduzca una contraseña valida");
                lblError.Visible = true;
            }
        }

        private void NombreCheck (string nombreText)
        {
            nombreText = textNombre.Text;
            if (textNombre.Text == "Nombre")
            {
                lblError.Text = "Ingrese un nombre";
                lblError.Visible = true;   
            }
        }

        private void ApellidoCheck (string apellidoText)
        {
            apellidoText = textApellido.Text;
            if (textApellido.Text == "Apellido")
            {
                lblError.Text = "Ingrese un apellido";
                lblError.Visible = true;
            }

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ApellidoCheck(textApellido.Text);
            NombreCheck(textNombre.Text);
            ContraseñaCheck(textPass.Text);
            UserCheck(textUser.Text);
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
