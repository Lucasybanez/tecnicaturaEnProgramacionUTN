using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Parcial_project
{
    public partial class FormPrincipal : Form
    {
        // Determina el estado de si el side menú está abierto o cerrado

        private int stateMenu = 1;

        public FormPrincipal()
        {
            InitializeComponent();
            convertMenu();              //Oculta la barra al iniciar el programa
        }



        //Convierte el menú al click

        private void pb_menu_Click(object sender, EventArgs e)
        {
            convertMenu();
        }


        private void convertMenu() {   //Convierte el menu deslizable

            if (stateMenu == 1)
            {
                //oculta 

                ib_clientes.Text = "";
                ib_ventas.Text = "";
                ib_productos.Text = "";
                ib_empleados.Text = "";
                ib_exit.Text = "";

                pb_logo.Visible = false;

                //cambia de lugar
                p_sideMenu.Location = new Point(0, 5);
                p_sideMenu.Size = new Size(44, 660);
                panelLateral.Size = new Size(43, 665);
                panelContenedor.Size = new Size(1352, 678);
                panelContenedor.Location = new Point(43, 23); 

                stateMenu = 0;
            }
            else {
                //Muestra

                ib_clientes.Text = "  Clientes";
                ib_ventas.Text = "Ventas";
                ib_productos.Text = "      Productos";
                ib_empleados.Text = "        Empleados";
                ib_exit.Text = "Salir";

                pb_logo.Visible = true;

                //cambia de lugar
                p_sideMenu.Location = new Point(0, 220);
                p_sideMenu.Size = new Size(165, 446);
                panelLateral.Size = new Size(165, 665);
                panelContenedor.Size = new Size(1232, 678);
                panelContenedor.Location = new Point(164, 23);

                stateMenu = 1;
            }

        }

        // Cierra la ventana
        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Cierra la ventana
        private void ib_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        //Abre los forms dentro del panel del Form principal
        private void formInPanel(object formSon)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formSon as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }



        //Cambia el titulo del panel al click
        private void ib_empleados_Click(object sender, EventArgs e)
        {
            formInPanel(new FormEmpleados());
            l_title.Text = "Empleados";
        }


        //BASURA DE CÓDIGO
        private void p_sideMenu_Paint(object sender, PaintEventArgs e)
        {

        }  //Basura
        private void label1_Click(object sender, EventArgs e)
        {

        }   //Basura
        private void ib_ventas_Click(object sender, EventArgs e)
        {

        }       //Basura
        private void button1_Click(object sender, EventArgs e)
        {

        }           //Basura
        private void label2_Click(object sender, EventArgs e)
        {

        }            //Basura

    }
}
