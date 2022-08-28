
namespace Parcial_project
{
    partial class FormLogin
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.l_error = new System.Windows.Forms.Label();
            this.ib_inVisiblePass = new FontAwesome.Sharp.IconButton();
            this.ib_visiblePass = new FontAwesome.Sharp.IconButton();
            this.ib_minimize = new FontAwesome.Sharp.IconButton();
            this.ic_close = new FontAwesome.Sharp.IconButton();
            this.b_register = new System.Windows.Forms.Button();
            this.l_password = new System.Windows.Forms.Label();
            this.l_user = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.ll_restaurar = new System.Windows.Forms.LinkLabel();
            this.b_login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.panelLeft.Controls.Add(this.pb_Logo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(263, 446);
            this.panelLeft.TabIndex = 0;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = global::Parcial_project.Properties.Resources.Logo1;
            this.pb_Logo.Location = new System.Drawing.Point(-1, 105);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(265, 241);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.l_error);
            this.panelRight.Controls.Add(this.ib_inVisiblePass);
            this.panelRight.Controls.Add(this.ib_visiblePass);
            this.panelRight.Controls.Add(this.ib_minimize);
            this.panelRight.Controls.Add(this.ic_close);
            this.panelRight.Controls.Add(this.b_register);
            this.panelRight.Controls.Add(this.l_password);
            this.panelRight.Controls.Add(this.l_user);
            this.panelRight.Controls.Add(this.tb_password);
            this.panelRight.Controls.Add(this.tb_user);
            this.panelRight.Controls.Add(this.ll_restaurar);
            this.panelRight.Controls.Add(this.b_login);
            this.panelRight.Controls.Add(this.pictureBox2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(263, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(650, 446);
            this.panelRight.TabIndex = 1;
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(38)))), ((int)(((byte)(121)))));
            this.l_error.Location = new System.Drawing.Point(97, 324);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(160, 22);
            this.l_error.TabIndex = 15;
            this.l_error.Text = "                              ";
            // 
            // ib_inVisiblePass
            // 
            this.ib_inVisiblePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_inVisiblePass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ib_inVisiblePass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ib_inVisiblePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_inVisiblePass.IconSize = 30;
            this.ib_inVisiblePass.Location = new System.Drawing.Point(568, 184);
            this.ib_inVisiblePass.Name = "ib_inVisiblePass";
            this.ib_inVisiblePass.Size = new System.Drawing.Size(29, 31);
            this.ib_inVisiblePass.TabIndex = 14;
            this.ib_inVisiblePass.UseVisualStyleBackColor = true;
            this.ib_inVisiblePass.Click += new System.EventHandler(this.ib_inVisiblePass_Click);
            // 
            // ib_visiblePass
            // 
            this.ib_visiblePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_visiblePass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.ib_visiblePass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ib_visiblePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_visiblePass.IconSize = 30;
            this.ib_visiblePass.Location = new System.Drawing.Point(568, 184);
            this.ib_visiblePass.Name = "ib_visiblePass";
            this.ib_visiblePass.Size = new System.Drawing.Size(29, 31);
            this.ib_visiblePass.TabIndex = 13;
            this.ib_visiblePass.UseVisualStyleBackColor = true;
            this.ib_visiblePass.Click += new System.EventHandler(this.ib_visiblePass_Click_1);
            // 
            // ib_minimize
            // 
            this.ib_minimize.FlatAppearance.BorderSize = 0;
            this.ib_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ib_minimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ib_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_minimize.IconSize = 15;
            this.ib_minimize.Location = new System.Drawing.Point(583, 12);
            this.ib_minimize.Name = "ib_minimize";
            this.ib_minimize.Size = new System.Drawing.Size(28, 23);
            this.ib_minimize.TabIndex = 12;
            this.ib_minimize.UseVisualStyleBackColor = true;
            this.ib_minimize.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ic_close
            // 
            this.ic_close.FlatAppearance.BorderSize = 0;
            this.ic_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ic_close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ic_close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ic_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_close.IconSize = 15;
            this.ic_close.Location = new System.Drawing.Point(608, 12);
            this.ic_close.Name = "ic_close";
            this.ic_close.Size = new System.Drawing.Size(28, 23);
            this.ic_close.TabIndex = 11;
            this.ic_close.UseVisualStyleBackColor = true;
            this.ic_close.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // b_register
            // 
            this.b_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(38)))), ((int)(((byte)(121)))));
            this.b_register.FlatAppearance.BorderSize = 0;
            this.b_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_register.Font = new System.Drawing.Font("Raleway SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_register.ForeColor = System.Drawing.SystemColors.Window;
            this.b_register.Location = new System.Drawing.Point(328, 239);
            this.b_register.Name = "b_register";
            this.b_register.Size = new System.Drawing.Size(269, 33);
            this.b_register.TabIndex = 10;
            this.b_register.Text = "Nuevo empleado";
            this.b_register.UseVisualStyleBackColor = false;
            this.b_register.Click += new System.EventHandler(this.b_register_Click);
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.l_password.Location = new System.Drawing.Point(55, 175);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(87, 18);
            this.l_password.TabIndex = 8;
            this.l_password.Text = "Contraseña";
            // 
            // l_user
            // 
            this.l_user.AutoSize = true;
            this.l_user.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_user.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.l_user.Location = new System.Drawing.Point(56, 106);
            this.l_user.Name = "l_user";
            this.l_user.Size = new System.Drawing.Size(60, 18);
            this.l_user.TabIndex = 7;
            this.l_user.Text = "Usuario";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_password.Location = new System.Drawing.Point(48, 184);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(520, 31);
            this.tb_password.TabIndex = 6;
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_user.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_user.Location = new System.Drawing.Point(48, 116);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(549, 31);
            this.tb_user.TabIndex = 5;
            this.tb_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ll_restaurar
            // 
            this.ll_restaurar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(178)))));
            this.ll_restaurar.AutoSize = true;
            this.ll_restaurar.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ll_restaurar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ll_restaurar.Location = new System.Drawing.Point(213, 293);
            this.ll_restaurar.Name = "ll_restaurar";
            this.ll_restaurar.Size = new System.Drawing.Size(229, 19);
            this.ll_restaurar.TabIndex = 4;
            this.ll_restaurar.TabStop = true;
            this.ll_restaurar.Text = "¿Has olivdado tu contraseña?";
            this.ll_restaurar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_restaurar_LinkClicked);
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(178)))));
            this.b_login.FlatAppearance.BorderSize = 0;
            this.b_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_login.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_login.ForeColor = System.Drawing.SystemColors.Window;
            this.b_login.Location = new System.Drawing.Point(48, 239);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(269, 33);
            this.b_login.TabIndex = 3;
            this.b_login.Text = "Acceder";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Parcial_project.Properties.Resources.esquina1;
            this.pictureBox2.Location = new System.Drawing.Point(418, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 446);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.LinkLabel ll_restaurar;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Label l_user;
        private System.Windows.Forms.Button b_register;
        private FontAwesome.Sharp.IconButton ib_minimize;
        private FontAwesome.Sharp.IconButton ic_close;
        private FontAwesome.Sharp.IconButton ib_visiblePass;
        private FontAwesome.Sharp.IconButton ib_inVisiblePass;
        private System.Windows.Forms.Label l_error;
    }
}