
namespace Parcial_project
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.l_title = new System.Windows.Forms.Label();
            this.pb_menu = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.p_sideMenu = new System.Windows.Forms.Panel();
            this.ib_exit = new FontAwesome.Sharp.IconButton();
            this.ib_empleados = new FontAwesome.Sharp.IconButton();
            this.ib_productos = new FontAwesome.Sharp.IconButton();
            this.ib_clientes = new FontAwesome.Sharp.IconButton();
            this.ib_ventas = new FontAwesome.Sharp.IconButton();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.l_welcome = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.p_sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(136)))), ((int)(((byte)(182)))));
            this.panelSuperior.Controls.Add(this.l_title);
            this.panelSuperior.Controls.Add(this.pb_menu);
            this.panelSuperior.Controls.Add(this.pb_close);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1391, 34);
            this.panelSuperior.TabIndex = 0;
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.l_title.Location = new System.Drawing.Point(31, 7);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(199, 19);
            this.l_title.TabIndex = 4;
            this.l_title.Text = "Luke and Fede: Enterprise";
            this.l_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb_menu
            // 
            this.pb_menu.Image = ((System.Drawing.Image)(resources.GetObject("pb_menu.Image")));
            this.pb_menu.Location = new System.Drawing.Point(6, 6);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Size = new System.Drawing.Size(20, 20);
            this.pb_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_menu.TabIndex = 3;
            this.pb_menu.TabStop = false;
            this.pb_menu.Click += new System.EventHandler(this.pb_menu_Click);
            // 
            // pb_close
            // 
            this.pb_close.Image = global::Parcial_project.Properties.Resources.cerrar;
            this.pb_close.Location = new System.Drawing.Point(1369, 12);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(10, 10);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 0;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(77)))), ((int)(((byte)(121)))));
            this.panelLateral.Controls.Add(this.p_sideMenu);
            this.panelLateral.Controls.Add(this.pb_logo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 34);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(167, 662);
            this.panelLateral.TabIndex = 1;
            // 
            // p_sideMenu
            // 
            this.p_sideMenu.Controls.Add(this.ib_exit);
            this.p_sideMenu.Controls.Add(this.ib_empleados);
            this.p_sideMenu.Controls.Add(this.ib_productos);
            this.p_sideMenu.Controls.Add(this.ib_clientes);
            this.p_sideMenu.Controls.Add(this.ib_ventas);
            this.p_sideMenu.Location = new System.Drawing.Point(0, 220);
            this.p_sideMenu.Name = "p_sideMenu";
            this.p_sideMenu.Size = new System.Drawing.Size(165, 446);
            this.p_sideMenu.TabIndex = 2;
            this.p_sideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.p_sideMenu_Paint);
            // 
            // ib_exit
            // 
            this.ib_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ib_exit.FlatAppearance.BorderSize = 0;
            this.ib_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_exit.Font = new System.Drawing.Font("Raleway", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ib_exit.ForeColor = System.Drawing.Color.Snow;
            this.ib_exit.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.ib_exit.IconColor = System.Drawing.Color.White;
            this.ib_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_exit.IconSize = 30;
            this.ib_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ib_exit.Location = new System.Drawing.Point(0, 414);
            this.ib_exit.Name = "ib_exit";
            this.ib_exit.Size = new System.Drawing.Size(165, 32);
            this.ib_exit.TabIndex = 4;
            this.ib_exit.Text = "Salir";
            this.ib_exit.UseVisualStyleBackColor = true;
            this.ib_exit.Click += new System.EventHandler(this.ib_exit_Click);
            // 
            // ib_empleados
            // 
            this.ib_empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.ib_empleados.FlatAppearance.BorderSize = 0;
            this.ib_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_empleados.Font = new System.Drawing.Font("Raleway", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ib_empleados.ForeColor = System.Drawing.Color.Snow;
            this.ib_empleados.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.ib_empleados.IconColor = System.Drawing.Color.White;
            this.ib_empleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_empleados.IconSize = 30;
            this.ib_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ib_empleados.Location = new System.Drawing.Point(0, 96);
            this.ib_empleados.Name = "ib_empleados";
            this.ib_empleados.Size = new System.Drawing.Size(165, 32);
            this.ib_empleados.TabIndex = 3;
            this.ib_empleados.Text = "        Empleados";
            this.ib_empleados.UseVisualStyleBackColor = true;
            this.ib_empleados.Click += new System.EventHandler(this.ib_empleados_Click);
            // 
            // ib_productos
            // 
            this.ib_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ib_productos.FlatAppearance.BorderSize = 0;
            this.ib_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_productos.Font = new System.Drawing.Font("Raleway", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ib_productos.ForeColor = System.Drawing.Color.Snow;
            this.ib_productos.IconChar = FontAwesome.Sharp.IconChar.Bicycle;
            this.ib_productos.IconColor = System.Drawing.Color.White;
            this.ib_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_productos.IconSize = 30;
            this.ib_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ib_productos.Location = new System.Drawing.Point(0, 64);
            this.ib_productos.Name = "ib_productos";
            this.ib_productos.Size = new System.Drawing.Size(165, 32);
            this.ib_productos.TabIndex = 2;
            this.ib_productos.Text = "      Productos";
            this.ib_productos.UseVisualStyleBackColor = true;
            // 
            // ib_clientes
            // 
            this.ib_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ib_clientes.FlatAppearance.BorderSize = 0;
            this.ib_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_clientes.Font = new System.Drawing.Font("Raleway", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ib_clientes.ForeColor = System.Drawing.Color.Snow;
            this.ib_clientes.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.ib_clientes.IconColor = System.Drawing.Color.White;
            this.ib_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_clientes.IconSize = 30;
            this.ib_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ib_clientes.Location = new System.Drawing.Point(0, 32);
            this.ib_clientes.Name = "ib_clientes";
            this.ib_clientes.Size = new System.Drawing.Size(165, 32);
            this.ib_clientes.TabIndex = 1;
            this.ib_clientes.Text = "  Clientes";
            this.ib_clientes.UseVisualStyleBackColor = true;
            // 
            // ib_ventas
            // 
            this.ib_ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ib_ventas.FlatAppearance.BorderSize = 0;
            this.ib_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_ventas.Font = new System.Drawing.Font("Raleway", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ib_ventas.ForeColor = System.Drawing.Color.Snow;
            this.ib_ventas.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.ib_ventas.IconColor = System.Drawing.Color.White;
            this.ib_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_ventas.IconSize = 30;
            this.ib_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ib_ventas.Location = new System.Drawing.Point(0, 0);
            this.ib_ventas.Name = "ib_ventas";
            this.ib_ventas.Size = new System.Drawing.Size(165, 32);
            this.ib_ventas.TabIndex = 0;
            this.ib_ventas.Text = "Ventas";
            this.ib_ventas.UseVisualStyleBackColor = true;
            this.ib_ventas.Click += new System.EventHandler(this.ib_ventas_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::Parcial_project.Properties.Resources.Logo;
            this.pb_logo.Location = new System.Drawing.Point(-31, 32);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(225, 191);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 1;
            this.pb_logo.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoSize = true;
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Window;
            this.panelContenedor.Controls.Add(this.l_welcome);
            this.panelContenedor.Location = new System.Drawing.Point(162, 34);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1229, 662);
            this.panelContenedor.TabIndex = 2;
            // 
            // l_welcome
            // 
            this.l_welcome.AutoSize = true;
            this.l_welcome.Font = new System.Drawing.Font("Raleway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_welcome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.l_welcome.Location = new System.Drawing.Point(433, 273);
            this.l_welcome.Name = "l_welcome";
            this.l_welcome.Size = new System.Drawing.Size(363, 75);
            this.l_welcome.TabIndex = 8;
            this.l_welcome.Text = "Bienvenido";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 696);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.p_sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel p_sideMenu;
        private FontAwesome.Sharp.IconButton ib_exit;
        private FontAwesome.Sharp.IconButton ib_empleados;
        private FontAwesome.Sharp.IconButton ib_productos;
        private FontAwesome.Sharp.IconButton ib_clientes;
        private FontAwesome.Sharp.IconButton ib_ventas;
        private System.Windows.Forms.Label l_welcome;
    }
}