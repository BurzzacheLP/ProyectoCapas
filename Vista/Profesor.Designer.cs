namespace Vista
{
    partial class Profesor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnFaltasAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.lblFaltas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlumnoQuitar = new System.Windows.Forms.Button();
            this.btnAlumnoAgregar = new System.Windows.Forms.Button();
            this.btnFaltasQuit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 360);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(40, 115);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(157, 128);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 17;
            this.logo.TabStop = false;
            // 
            // btnFaltasAdd
            // 
            this.btnFaltasAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFaltasAdd.FlatAppearance.BorderSize = 0;
            this.btnFaltasAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(120)))));
            this.btnFaltasAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(150)))));
            this.btnFaltasAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaltasAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnFaltasAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFaltasAdd.Location = new System.Drawing.Point(193, 203);
            this.btnFaltasAdd.Name = "btnFaltasAdd";
            this.btnFaltasAdd.Size = new System.Drawing.Size(78, 41);
            this.btnFaltasAdd.TabIndex = 7;
            this.btnFaltasAdd.Text = "Agregar";
            this.btnFaltasAdd.UseVisualStyleBackColor = false;
            this.btnFaltasAdd.Click += new System.EventHandler(this.btnFaltasAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(263, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 269);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(7, 240);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 15);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.lblApellido.Location = new System.Drawing.Point(7, 152);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(7, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(440, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Panel de Profesor";
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(758, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 20);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 15;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(722, 9);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 20);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 16;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(189, 27);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(103, 20);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textApellido);
            this.groupBox3.Controls.Add(this.lblError);
            this.groupBox3.Controls.Add(this.lblFaltas);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnAlumnoQuitar);
            this.groupBox3.Controls.Add(this.btnAlumnoAgregar);
            this.groupBox3.Controls.Add(this.btnFaltasQuit);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnFaltasAdd);
            this.groupBox3.Controls.Add(this.textNombre);
            this.groupBox3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(412, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 269);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textApellido.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textApellido.ForeColor = System.Drawing.Color.DimGray;
            this.textApellido.Location = new System.Drawing.Point(193, 59);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(154, 22);
            this.textApellido.TabIndex = 14;
            this.textApellido.Text = "Apellido";
            this.textApellido.Enter += new System.EventHandler(this.textApellido_Enter);
            this.textApellido.Leave += new System.EventHandler(this.textApellido_Leave);
            // 
            // lblFaltas
            // 
            this.lblFaltas.AutoSize = true;
            this.lblFaltas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFaltas.ForeColor = System.Drawing.Color.DimGray;
            this.lblFaltas.Location = new System.Drawing.Point(246, 174);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(13, 15);
            this.lblFaltas.TabIndex = 6;
            this.lblFaltas.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Opciones de Alumno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Faltas";
            // 
            // btnAlumnoQuitar
            // 
            this.btnAlumnoQuitar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAlumnoQuitar.FlatAppearance.BorderSize = 0;
            this.btnAlumnoQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(120)))));
            this.btnAlumnoQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(150)))));
            this.btnAlumnoQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnoQuitar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAlumnoQuitar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlumnoQuitar.Location = new System.Drawing.Point(96, 203);
            this.btnAlumnoQuitar.Name = "btnAlumnoQuitar";
            this.btnAlumnoQuitar.Size = new System.Drawing.Size(78, 41);
            this.btnAlumnoQuitar.TabIndex = 11;
            this.btnAlumnoQuitar.Text = "Quitar";
            this.btnAlumnoQuitar.UseVisualStyleBackColor = false;
            this.btnAlumnoQuitar.Click += new System.EventHandler(this.btnAlumnoQuitar_Click);
            // 
            // btnAlumnoAgregar
            // 
            this.btnAlumnoAgregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAlumnoAgregar.FlatAppearance.BorderSize = 0;
            this.btnAlumnoAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(120)))));
            this.btnAlumnoAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(150)))));
            this.btnAlumnoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnoAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnoAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlumnoAgregar.Location = new System.Drawing.Point(12, 203);
            this.btnAlumnoAgregar.Name = "btnAlumnoAgregar";
            this.btnAlumnoAgregar.Size = new System.Drawing.Size(78, 41);
            this.btnAlumnoAgregar.TabIndex = 10;
            this.btnAlumnoAgregar.Text = "Agregar";
            this.btnAlumnoAgregar.UseVisualStyleBackColor = false;
            this.btnAlumnoAgregar.Click += new System.EventHandler(this.btnAlumnoAgregar_Click);
            // 
            // btnFaltasQuit
            // 
            this.btnFaltasQuit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFaltasQuit.FlatAppearance.BorderSize = 0;
            this.btnFaltasQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(120)))));
            this.btnFaltasQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(150)))));
            this.btnFaltasQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaltasQuit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnFaltasQuit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFaltasQuit.Location = new System.Drawing.Point(277, 203);
            this.btnFaltasQuit.Name = "btnFaltasQuit";
            this.btnFaltasQuit.Size = new System.Drawing.Size(78, 41);
            this.btnFaltasQuit.TabIndex = 9;
            this.btnFaltasQuit.Text = "Quitar";
            this.btnFaltasQuit.UseVisualStyleBackColor = false;
            this.btnFaltasQuit.Click += new System.EventHandler(this.btnFaltasQuit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccionar Alumno";
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textNombre.ForeColor = System.Drawing.Color.DimGray;
            this.textNombre.Location = new System.Drawing.Point(10, 59);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(154, 22);
            this.textNombre.TabIndex = 8;
            this.textNombre.Text = "Nombre";
            this.textNombre.Enter += new System.EventHandler(this.textNombre_Enter);
            this.textNombre.Leave += new System.EventHandler(this.textNombre_Leave);
            // 
            // Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profesor";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inciar Sesion";
            this.Load += new System.EventHandler(this.Profesor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFaltasAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button btnAlumnoQuitar;
        private System.Windows.Forms.Button btnAlumnoAgregar;
        private System.Windows.Forms.Button btnFaltasQuit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFaltas;
        private System.Windows.Forms.TextBox textApellido;
    }
}

