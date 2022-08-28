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
    public partial class FormEmpleados : Form
    {

        public FormEmpleados()
        {
            InitializeComponent();
            loadGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ic_nuevoEmpleado_Click(object sender, EventArgs e)
        {
            // Abrir form
            var frm = new FormAgregarEmpleado(); frm.Show();
        }

        private void loadGrid() {



            String database = "";
            String[] celda;
            String[] lineas;
           
            //Lee el bloc de notas

            StreamReader lector = new StreamReader("C:\\Users\\Lucas21\\Desktop\\Programación\\codigos\\c#\\Parcial_project\\dataBaseEmpleados.txt");
            database = lector.ReadToEnd();
            lector.Close();

            lineas = database.Split("-");

            for(int i = 0; i < lineas.Length-1; i++) {
                celda = lineas[i].Split(",");
                grid1.Rows.Add(celda);
            }

        }

        private void ib_buscar_Click(object sender, EventArgs e)
        {
            buscador(tb_search.Text);
        }

        private void buscador(String buscado) {

            String database = "";
            String[] celda;
            String[] lineas;


            //Lee el bloc de notas

            StreamReader lector = new StreamReader("C:\\Users\\Lucas21\\Desktop\\Programación\\codigos\\c#\\Parcial_project\\dataBaseEmpleados.txt");
            database = lector.ReadToEnd();
            lector.Close();

            lineas = database.Split("-");

            grid1.Rows.Clear();

            for (int i = 0; i < lineas.Length; i++)
            {
                celda = lineas[i].Split(",");

                for(int j = 0; j < celda.Length; j++)
                {
                    if (buscado.ToLower() == celda[j].ToLower())
                    { 
                        grid1.Rows.Add(celda);
                    }

                }

            }



        }


        //basura
        private void FormEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void ib_refresh_Click(object sender, EventArgs e)
        {
            grid1.Rows.Clear();
            loadGrid();
        }
    }
}
