
namespace Parcial_project
{
    partial class FormAgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ib_minimize = new FontAwesome.Sharp.IconButton();
            this.l_newUser = new System.Windows.Forms.Label();
            this.ic_close = new FontAwesome.Sharp.IconButton();
            this.pb_userIcon = new System.Windows.Forms.PictureBox();
            this.pb_fondo = new System.Windows.Forms.PictureBox();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.l_apellido = new System.Windows.Forms.Label();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.l_nombre = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.l_dni = new System.Windows.Forms.Label();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.l_calle = new System.Windows.Forms.Label();
            this.tb_calle = new System.Windows.Forms.TextBox();
            this.l_numero = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.l_piso = new System.Windows.Forms.Label();
            this.tb_piso = new System.Windows.Forms.TextBox();
            this.l_dpto = new System.Windows.Forms.Label();
            this.tb_depto = new System.Windows.Forms.TextBox();
            this.datetime1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_legajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.l_error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.ib_minimize);
            this.panel1.Controls.Add(this.l_newUser);
            this.panel1.Controls.Add(this.ic_close);
            this.panel1.Controls.Add(this.pb_userIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 154);
            this.panel1.TabIndex = 0;
            // 
            // ib_minimize
            // 
            this.ib_minimize.FlatAppearance.BorderSize = 0;
            this.ib_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ib_minimize.IconColor = System.Drawing.Color.White;
            this.ib_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_minimize.IconSize = 15;
            this.ib_minimize.Location = new System.Drawing.Point(483, 7);
            this.ib_minimize.Name = "ib_minimize";
            this.ib_minimize.Size = new System.Drawing.Size(28, 23);
            this.ib_minimize.TabIndex = 14;
            this.ib_minimize.UseVisualStyleBackColor = true;
            this.ib_minimize.Click += new System.EventHandler(this.ib_minimize_Click);
            // 
            // l_newUser
            // 
            this.l_newUser.AutoSize = true;
            this.l_newUser.Font = new System.Drawing.Font("Raleway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_newUser.ForeColor = System.Drawing.Color.White;
            this.l_newUser.Location = new System.Drawing.Point(127, 97);
            this.l_newUser.Name = "l_newUser";
            this.l_newUser.Size = new System.Drawing.Size(303, 41);
            this.l_newUser.TabIndex = 1;
            this.l_newUser.Text = "Nuevo empleado";
            // 
            // ic_close
            // 
            this.ic_close.FlatAppearance.BorderSize = 0;
            this.ic_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ic_close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ic_close.IconColor = System.Drawing.Color.White;
            this.ic_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_close.IconSize = 15;
            this.ic_close.Location = new System.Drawing.Point(508, 7);
            this.ic_close.Name = "ic_close";
            this.ic_close.Size = new System.Drawing.Size(28, 23);
            this.ic_close.TabIndex = 13;
            this.ic_close.UseVisualStyleBackColor = true;
            this.ic_close.Click += new System.EventHandler(this.ic_close_Click);
            // 
            // pb_userIcon
            // 
            this.pb_userIcon.Image = global::Parcial_project.Properties.Resources.user;
            this.pb_userIcon.Location = new System.Drawing.Point(232, 14);
            this.pb_userIcon.Name = "pb_userIcon";
            this.pb_userIcon.Size = new System.Drawing.Size(83, 75);
            this.pb_userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_userIcon.TabIndex = 0;
            this.pb_userIcon.TabStop = false;
            // 
            // pb_fondo
            // 
            this.pb_fondo.Image = ((System.Drawing.Image)(resources.GetObject("pb_fondo.Image")));
            this.pb_fondo.Location = new System.Drawing.Point(-6, 595);
            this.pb_fondo.Name = "pb_fondo";
            this.pb_fondo.Size = new System.Drawing.Size(555, 159);
            this.pb_fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_fondo.TabIndex = 2;
            this.pb_fondo.TabStop = false;
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(38)))), ((int)(((byte)(121)))));
            this.b_cancel.FlatAppearance.BorderSize = 0;
            this.b_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancel.Font = new System.Drawing.Font("Raleway SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.b_cancel.Location = new System.Drawing.Point(275, 556);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(156, 33);
            this.b_cancel.TabIndex = 16;
            this.b_cancel.Text = "Cancelar";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(178)))));
            this.b_save.FlatAppearance.BorderSize = 0;
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_save.ForeColor = System.Drawing.SystemColors.Window;
            this.b_save.Location = new System.Drawing.Point(106, 556);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(156, 33);
            this.b_save.TabIndex = 15;
            this.b_save.Text = "Guardar";
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // l_apellido
            // 
            this.l_apellido.AutoSize = true;
            this.l_apellido.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_apellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.l_apellido.Location = new System.Drawing.Point(45, 236);
            this.l_apellido.Name = "l_apellido";
            this.l_apellido.Size = new System.Drawing.Size(65, 18);
            this.l_apellido.TabIndex = 18;
            this.l_apellido.Text = "Apellido";
            // 
            // tb_apellido
            // 
            this.tb_apellido.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_apellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_apellido.Location = new System.Drawing.Point(37, 246);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(460, 31);
            this.tb_apellido.TabIndex = 17;
            this.tb_apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_nombre
            // 
            this.l_nombre.AutoSize = true;
            this.l_nombre.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_nombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.l_nombre.Location = new System.Drawing.Point(45, 299);
            this.l_nombre.Name = "l_nombre";
            this.l_nombre.Size = new System.Drawing.Size(66, 18);
            this.l_nombre.TabIndex = 20;
            this.l_nombre.Text = "Nombre";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_nombre.Location = new System.Drawing.Point(37, 309);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(460, 31);
            this.tb_nombre.TabIndex = 19;
            this.tb_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_dni
            // 
            this.l_dni.AutoSize = true;
            this.l_dni.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_dni.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.l_dni.Location = new System.Drawing.Point(46, 361);
            this.l_dni.Name = "l_dni";
            this.l_dni.Size = new System.Drawing.Size(35, 18);
            this.l_dni.TabIndex = 22;
            this.l_dni.Text = "DNI";
            // 
            // tb_dni
            // 
            this.tb_dni.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_dni.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_dni.Location = new System.Drawing.Point(38, 371);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(291, 31);
            this.tb_dni.TabIndex = 21;
            this.tb_dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_calle
            // 
            this.l_calle.AutoSize = true;
            this.l_calle.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_calle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.l_calle.Location = new System.Drawing.Point(46, 423);
            this.l_calle.Name = "l_calle";
            this.l_calle.Size = new System.Drawing.Size(43, 18);
            this.l_calle.TabIndex = 24;
            this.l_calle.Text = "Calle";
            // 
            // tb_calle
            // 
            this.tb_calle.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_calle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_calle.Location = new System.Drawing.Point(38, 433);
            this.tb_calle.Name = "tb_calle";
            this.tb_calle.Size = new System.Drawing.Size(460, 31);
            this.tb_calle.TabIndex = 23;
            this.tb_calle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_numero
            // 
            this.l_numero.AutoSize = true;
            this.l_numero.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_numero.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.l_numero.Location = new System.Drawing.Point(46, 480);
            this.l_numero.Name = "l_numero";
            this.l_numero.Size = new System.Drawing.Size(66, 18);
            this.l_numero.TabIndex = 26;
            this.l_numero.Text = "Número";
            // 
            // tb_numero
            // 
            this.tb_numero.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_numero.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_numero.Location = new System.Drawing.Point(38, 490);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(122, 31);
            this.tb_numero.TabIndex = 25;
            this.tb_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_piso
            // 
            this.l_piso.AutoSize = true;
            this.l_piso.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_piso.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.l_piso.Location = new System.Drawing.Point(214, 482);
            this.l_piso.Name = "l_piso";
            this.l_piso.Size = new System.Drawing.Size(107, 18);
            this.l_piso.TabIndex = 28;
            this.l_piso.Text = "Piso (opcional)";
            // 
            // tb_piso
            // 
            this.tb_piso.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_piso.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_piso.Location = new System.Drawing.Point(207, 492);
            this.tb_piso.Name = "tb_piso";
            this.tb_piso.Size = new System.Drawing.Size(122, 31);
            this.tb_piso.TabIndex = 27;
            this.tb_piso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_dpto
            // 
            this.l_dpto.AutoSize = true;
            this.l_dpto.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_dpto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.l_dpto.Location = new System.Drawing.Point(380, 482);
            this.l_dpto.Name = "l_dpto";
            this.l_dpto.Size = new System.Drawing.Size(113, 18);
            this.l_dpto.TabIndex = 30;
            this.l_dpto.Text = "Dpto (opcional)";
            // 
            // tb_depto
            // 
            this.tb_depto.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_depto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_depto.Location = new System.Drawing.Point(376, 492);
            this.tb_depto.Name = "tb_depto";
            this.tb_depto.Size = new System.Drawing.Size(122, 31);
            this.tb_depto.TabIndex = 29;
            this.tb_depto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datetime1
            // 
            this.datetime1.CalendarFont = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datetime1.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datetime1.Font = new System.Drawing.Font("Raleway", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datetime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime1.Location = new System.Drawing.Point(338, 371);
            this.datetime1.Name = "datetime1";
            this.datetime1.Size = new System.Drawing.Size(159, 31);
            this.datetime1.TabIndex = 32;
            this.datetime1.Value = new System.DateTime(2022, 6, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(341, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // tb_legajo
            // 
            this.tb_legajo.Enabled = false;
            this.tb_legajo.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_legajo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_legajo.Location = new System.Drawing.Point(206, 194);
            this.tb_legajo.Name = "tb_legajo";
            this.tb_legajo.Size = new System.Drawing.Size(122, 31);
            this.tb_legajo.TabIndex = 34;
            this.tb_legajo.Text = "1";
            this.tb_legajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(236, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Legajo";
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.BackColor = System.Drawing.SystemColors.Window;
            this.l_error.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(178)))));
            this.l_error.Location = new System.Drawing.Point(72, 601);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(0, 22);
            this.l_error.TabIndex = 36;
            // 
            // FormAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 729);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_legajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datetime1);
            this.Controls.Add(this.l_dpto);
            this.Controls.Add(this.tb_depto);
            this.Controls.Add(this.l_piso);
            this.Controls.Add(this.tb_piso);
            this.Controls.Add(this.l_numero);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.l_calle);
            this.Controls.Add(this.tb_calle);
            this.Controls.Add(this.l_dni);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.l_nombre);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.l_apellido);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.pb_fondo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarEmpleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_newUser;
        private System.Windows.Forms.PictureBox pb_userIcon;
        private System.Windows.Forms.PictureBox pb_fondo;
        private FontAwesome.Sharp.IconButton ib_minimize;
        private FontAwesome.Sharp.IconButton ic_close;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label l_apellido;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.Label l_nombre;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label l_dni;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.Label l_calle;
        private System.Windows.Forms.TextBox tb_calle;
        private System.Windows.Forms.Label l_numero;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Label l_piso;
        private System.Windows.Forms.TextBox tb_piso;
        private System.Windows.Forms.Label l_dpto;
        private System.Windows.Forms.TextBox tb_depto;
        private System.Windows.Forms.DateTimePicker datetime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_legajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_error;
    }
}