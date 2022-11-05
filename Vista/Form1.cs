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

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
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
            if(textUser.Text == "Fulanito Gomez")
            {
                textUser.Clear();
            }
            textUser.ForeColor = Color.FromArgb (99,99,150);
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "Fulanito Gomez";
            }
            textUser.ForeColor = Color.DimGray;
        }

        
        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "Pancho32;")
            {
                textPass.Clear();
            }
            textPass.ForeColor = Color.FromArgb(99, 99, 150);
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "Pancho32";
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
    }
}
