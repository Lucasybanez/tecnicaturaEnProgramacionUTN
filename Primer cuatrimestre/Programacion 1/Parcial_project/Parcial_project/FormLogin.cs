using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Parcial_project
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Cierra la ventana
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;       //minimiza la ventana
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = true;                   //Oculta la contraseña
        }

        private void ll_restaurar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("La contraseña es: P.a.s.s.","Recordatorio",MessageBoxButtons.OK,MessageBoxIcon.Information);               //Muestra la contraseña
        }

        private void ib_visiblePass_Click_1(object sender, EventArgs e)
        {
       
                tb_password.UseSystemPasswordChar = true;               //Muestra/oculta la contraseña
                ib_visiblePass.Visible = false;
                ib_inVisiblePass.Visible = true;

        }



        private void ib_inVisiblePass_Click(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = false;              //Muestra u oculta la contraseña
            ib_inVisiblePass.Visible = false;
            ib_visiblePass.Visible = true;
        }


        //basura
        private void ib_visiblePass_Click(object sender, EventArgs e) { }

        private void b_login_Click(object sender, EventArgs e)
        {

            // Toma los datos de los campos ingresados

            String user = tb_user.Text;
            String password = tb_password.Text;

            // Llama la función de verificación

            verificacion(user, password);
            
        }

        private void b_register_Click(object sender, EventArgs e)
        {
            // Abrir form
            var frm = new FormAgregarEmpleado(); frm.Show();

        }

        private void verificacion(String user, String password) {

            //Prueba

            String puser = "", pass="P.a.s.s.";


            //Comprueba si están rellenos los campos

            bool isCorrect = false;


            if (String.IsNullOrEmpty(user) == true || String.IsNullOrEmpty(password) == true)
            {
                l_error.Text = "                       Debe rellenar los campos.";
            }
            else {

                //Verifica que están bien puestas las contraseñas

                //Cargar del txt

                String[] celda;
                String dataBaseUser = "";

                StreamReader lector = new StreamReader("C:\\Users\\Lucas21\\Desktop\\Programación\\codigos\\c#\\Parcial_project\\dataBaseUser.txt");
                dataBaseUser = lector.ReadToEnd();
                lector.Close();

                String[] lineas = dataBaseUser.Split("-");

                for (int i = 0; i < lineas.Length; i++)
                {
                    celda = lineas[i].Split(",");
                    puser = celda[0];

                    if (user.ToLower() == puser)
                    { 
                        isCorrect = true;
                        i = lineas.Length;
                    }

                }

                if (isCorrect == true && password==pass)
                {

                    var frm = new FormPrincipal(); frm.Show();
                }
                else {

                    l_error.Text="La contraseña o el usuario ingresado no son válidos.";
                }
            }
        }
    }
}
