
namespace Parcial_project
{
    partial class FormEmpleados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ib_refresh = new FontAwesome.Sharp.IconButton();
            this.ib_buscar = new FontAwesome.Sharp.IconButton();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.ic_nuevoEmpleado = new FontAwesome.Sharp.IconButton();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.c_legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.ib_refresh);
            this.panel1.Controls.Add(this.ib_buscar);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.ic_nuevoEmpleado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 47);
            this.panel1.TabIndex = 0;
            // 
            // ib_refresh
            // 
            this.ib_refresh.FlatAppearance.BorderSize = 0;
            this.ib_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_refresh.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ib_refresh.ForeColor = System.Drawing.Color.White;
            this.ib_refresh.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.ib_refresh.IconColor = System.Drawing.Color.White;
            this.ib_refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_refresh.IconSize = 20;
            this.ib_refresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ib_refresh.Location = new System.Drawing.Point(185, 15);
            this.ib_refresh.Name = "ib_refresh";
            this.ib_refresh.Size = new System.Drawing.Size(108, 25);
            this.ib_refresh.TabIndex = 3;
            this.ib_refresh.Text = "Refresh";
            this.ib_refresh.UseVisualStyleBackColor = true;
            this.ib_refresh.Click += new System.EventHandler(this.ib_refresh_Click);
            // 
            // ib_buscar
            // 
            this.ib_buscar.FlatAppearance.BorderSize = 0;
            this.ib_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ib_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ib_buscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ib_buscar.IconColor = System.Drawing.Color.White;
            this.ib_buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ib_buscar.IconSize = 20;
            this.ib_buscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ib_buscar.Location = new System.Drawing.Point(1074, 17);
            this.ib_buscar.Name = "ib_buscar";
            this.ib_buscar.Size = new System.Drawing.Size(75, 23);
            this.ib_buscar.TabIndex = 2;
            this.ib_buscar.Text = "Buscar";
            this.ib_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ib_buscar.UseVisualStyleBackColor = true;
            this.ib_buscar.Click += new System.EventHandler(this.ib_buscar_Click);
            // 
            // tb_search
            // 
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Location = new System.Drawing.Point(893, 21);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(183, 16);
            this.tb_search.TabIndex = 1;
            // 
            // ic_nuevoEmpleado
            // 
            this.ic_nuevoEmpleado.FlatAppearance.BorderSize = 0;
            this.ic_nuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ic_nuevoEmpleado.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ic_nuevoEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ic_nuevoEmpleado.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ic_nuevoEmpleado.IconColor = System.Drawing.Color.White;
            this.ic_nuevoEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_nuevoEmpleado.IconSize = 20;
            this.ic_nuevoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ic_nuevoEmpleado.Location = new System.Drawing.Point(26, 14);
            this.ic_nuevoEmpleado.Name = "ic_nuevoEmpleado";
            this.ic_nuevoEmpleado.Size = new System.Drawing.Size(153, 28);
            this.ic_nuevoEmpleado.TabIndex = 0;
            this.ic_nuevoEmpleado.Text = "Nuevo empleado";
            this.ic_nuevoEmpleado.UseVisualStyleBackColor = true;
            this.ic_nuevoEmpleado.Click += new System.EventHandler(this.ic_nuevoEmpleado_Click);
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_legajo,
            this.l_name,
            this.Nombre,
            this.c_dni,
            this.c_Fecha,
            this.c_domicilio});
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.Location = new System.Drawing.Point(0, 47);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.RowTemplate.Height = 25;
            this.grid1.Size = new System.Drawing.Size(1157, 652);
            this.grid1.TabIndex = 1;
            // 
            // c_legajo
            // 
            this.c_legajo.HeaderText = "Legajo";
            this.c_legajo.Name = "c_legajo";
            this.c_legajo.ReadOnly = true;
            this.c_legajo.Width = 70;
            // 
            // l_name
            // 
            this.l_name.HeaderText = "Apellido";
            this.l_name.Name = "l_name";
            this.l_name.ReadOnly = true;
            this.l_name.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // c_dni
            // 
            this.c_dni.FillWeight = 70F;
            this.c_dni.HeaderText = "DNI";
            this.c_dni.Name = "c_dni";
            this.c_dni.ReadOnly = true;
            this.c_dni.Width = 200;
            // 
            // c_Fecha
            // 
            this.c_Fecha.HeaderText = "Fecha de nacimiento";
            this.c_Fecha.Name = "c_Fecha";
            this.c_Fecha.ReadOnly = true;
            this.c_Fecha.Width = 200;
            // 
            // c_domicilio
            // 
            this.c_domicilio.HeaderText = "Domicilio";
            this.c_domicilio.Name = "c_domicilio";
            this.c_domicilio.ReadOnly = true;
            this.c_domicilio.Width = 500;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 699);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleados";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ib_buscar;
        private System.Windows.Forms.TextBox tb_search;
        private FontAwesome.Sharp.IconButton ic_nuevoEmpleado;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_domicilio;
        private FontAwesome.Sharp.IconButton ib_refresh;
    }
}