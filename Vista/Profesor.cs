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
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
            
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
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm frm = new RegisterForm();
            frm.Show();
        }
        #endregion

        #region Checkeos De Campos
        private void NombreCheck (string textoNombre)
        {
            textoNombre = textNombre.Text;
            if (textoNombre == "Nombre")
            {
                lblError.Text = "Introduzca un nombre";
            }
        }

        private void ApellidoCheck (string textoApellido)
        {
            textoApellido = textApellido.Text;
            if (textoApellido == "Apellido")
            {
                lblError.Text = "Introduzca un apellido";
            }
        }
        #endregion
    }
}
