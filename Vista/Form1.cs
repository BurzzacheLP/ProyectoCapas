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
using Logica;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
        }

        
        private void textPass_Enter(object sender, EventArgs e)
        {
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SelectorComandos Cmd = new SelectorComandos();
            Cmd.Consulta(textBox1.Text, textBox2.Text, textBox3.Text);

            foreach (DataRow Fila in Cmd.Resultado.Rows)
            {
                foreach (var item in Fila.ItemArray)
                {
                    MessageBox.Show(Convert.ToString(item));
                }
            }
        }
    }
}
