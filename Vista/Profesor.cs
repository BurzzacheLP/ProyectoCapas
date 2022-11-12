using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;
using System.Drawing;

namespace Vista
{
    public partial class Profesor : Form
    {
        private void Error(string Msg, bool Visible)
        {
            lblError.Text = Msg;
            lblError.Visible = Visible;
        }
        public Profesor(string Usuario)
        {
            InitializeComponent();
            SelectorComandos Peticion = new SelectorComandos();
            Peticion.Consulta("RecibirInfo", Usuario);
            MessageBox.Show(Peticion.Resultado.Rows.Count.ToString());
            if (Peticion.Resultado.Rows.Count > 0)
            {
                lblNombre.Text = Peticion.Resultado.Rows[0]["Nombre"].ToString();
                lblApellido.Text = Peticion.Resultado.Rows[0]["Apellido"].ToString();
                lblUser.Text = Usuario;
            }
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

        private void Profesor_Load(object sender, EventArgs e)
        {

        }
        private void ActualizarAlumno()
        {
            if (textNombre.Text != "Nombre" && textApellido.Text != "Apellido")
            {
                try
                {
                    SelectorComandos Peticion = new SelectorComandos();
                    Peticion.Consulta("LeerFaltas", textNombre.Text, textApellido.Text);
                    lblFaltas.Text = Peticion.Resultado.Rows[0]["Faltas"].ToString();
                    Error("", false);
                }
                catch
                { 
                    lblFaltas.Text = "0";
                    Error("Alumno no encontrado", true);
                }
            }
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                textNombre.Text = "Nombre";
            }
            textNombre.ForeColor = Color.DimGray;
            ActualizarAlumno();
        }
        private void textApellido_Leave(object sender, EventArgs e)
        {
            if (textApellido.Text == "")
            {
                textApellido.Text = "Apellido";
            }
            textApellido.ForeColor = Color.DimGray;
            ActualizarAlumno();
        }

        private void btnAlumnoQuitar_Click(object sender, EventArgs e)
        {
            SelectorComandos Peticion = new SelectorComandos();
            Peticion.Consulta("SacarAlumno", textNombre.Text, textApellido.Text);
            textNombre.Text = "Nombre";
            textApellido.Text = "Apellido";
            ActualizarAlumno();
        }

        private void btnAlumnoAgregar_Click(object sender, EventArgs e)
        {
            SelectorComandos Peticion = new SelectorComandos();
            Peticion.Consulta("AgregarAlumno", textNombre.Text, textApellido.Text);
            ActualizarAlumno();
        }

        private void textNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Text == "Nombre")
            {
                textNombre.Clear();
            }
            textNombre.ForeColor = Color.FromArgb(99, 99, 150);
        }

        private void textApellido_Enter(object sender, EventArgs e)
        {
            if (textApellido.Text == "Apellido")
            {
                textApellido.Clear();
            }
            textApellido.ForeColor = Color.FromArgb(99, 99, 150);
        }

        private void btnFaltasAdd_Click(object sender, EventArgs e)
        {
            SelectorComandos Peticion = new SelectorComandos();
            Peticion.Consulta("SumarFaltas", textNombre.Text, textApellido.Text);
            ActualizarAlumno();
        }

        private void btnFaltasQuit_Click(object sender, EventArgs e)
        {
            SelectorComandos Peticion = new SelectorComandos();
            Peticion.Consulta("RestarFaltas", textNombre.Text, textApellido.Text);
            ActualizarAlumno();
        }
    }
}
