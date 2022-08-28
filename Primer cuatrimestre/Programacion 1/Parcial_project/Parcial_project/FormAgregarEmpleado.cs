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
    public partial class FormAgregarEmpleado : Form
    {
        public FormAgregarEmpleado()
        {
            InitializeComponent();
            startLegajo();
        }

        // Oculta la ventana
        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Oculta la ventana
        private void ic_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        // Minimiza la ventana
        private void ib_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Verifica que los campos no estén vaciós
        int verificadorEmpty(String textBox) {

            // 0 es cero errores y 1 es que hay un error

            int bandera=0;
            if (String.IsNullOrEmpty(textBox) == true)
            {
                bandera = 1;
                return bandera;
            }
            else {
                return bandera; }

        }
        // Verifica el DNI
        int verificarDni(String dni) {

            int bandera=0;

            int numDni = int.Parse(dni);

            if (numDni < 9999999 || numDni > 99999999) { bandera = 1; return bandera; }
            else { return bandera; }

        }
        //Verifica el número ingresado de piso
        int verificarPiso(String piso)
        {

            int bandera = 0;

            int numPiso = int.Parse(piso);

            if (numPiso < 0 || numPiso > 99) { bandera = 1; return bandera; }
            else { return bandera; }

        }
        //Verifica el número ingresado de calle
        int verificarCalle(String calle)
        {

            int bandera = 0;

            int numCalle = int.Parse(calle);

            if (numCalle < 0 || numCalle > 999) { bandera = 1; return bandera; }
            else { return bandera; }

        }

        //Realiza todas las ejecuciones de verificación
        private void verificador() {

            // Recupera los datos de los textbox
            String apellido = tb_apellido.Text, nombre = tb_nombre.Text, dni = tb_dni.Text, calle = tb_calle.Text, numeroCalle = tb_numero.Text,
                   numeroPiso = tb_piso.Text, numeroDpto = tb_depto.Text, legajo=tb_legajo.Text;

            int leg = int.Parse(legajo);

            // Procede a verificar que no estén vacios

            int bandera = 0;

            bandera = bandera + verificadorEmpty(apellido);
            bandera = bandera + verificadorEmpty(nombre);
            bandera = bandera + verificadorEmpty(dni);
            bandera = bandera + verificadorEmpty (calle);
            bandera = bandera + verificadorEmpty(numeroCalle);

            // Verifica que esté todo bien ingresado

            if (bandera == 0)
            {
                // Verifica el DNI
                bandera=verificarDni(dni);

                if (bandera == 0)
                {
                    // Si está bien verifica la calle
                    bandera = verificarCalle(numeroCalle);

                    if (bandera == 0)
                    {   
                        // Si está bien verifica si está vacío el piso
                        if (String.IsNullOrEmpty(numeroPiso) == false)
                        {
                            bandera=verificarPiso(numeroPiso);
                            if (bandera == 0)
                            { 
                                // Si está bien guarda las cosas en el TXT
                                guardador(legajo, apellido, nombre, dni, calle, numeroCalle, numeroPiso, numeroDpto);
                                l_error.Text = "                Guardado correctamente.";
                                limpiador(); startLegajo(); crearUsuario(nombre,apellido);
                            }
                            else { l_error.Text = "Numero de piso ingresado no es válido."; }
                        }
                        else {
                            
                            //Si no fué ingresado piso y lo demás está bien guarda las cosas en el TXT
                            guardador(legajo, apellido, nombre, dni, calle, numeroCalle, numeroPiso, numeroDpto);
                            l_error.Text = "                Guardado correctamente.";
                            limpiador(); startLegajo(); crearUsuario(nombre,apellido);
                        }
                    }

                    else { l_error.Text = "Número de calle ingresado no es válido"; }
                }
                else { l_error.Text = "               DNI ingresado no es válido."; }
            }
            else {
                l_error.Text = "Debe rellenar todos los campos obligatorios.";
            }


        }

        private void startLegajo() {

            String database;
            String[] lineas;
            int numLeg;

            StreamReader lector = new StreamReader("C:\\Users\\Lucas21\\Desktop\\Programación\\codigos\\c#\\Parcial_project\\dataBaseEmpleados.txt");
            database = lector.ReadToEnd();
            lector.Close();

            lineas = database.Split("-");

            numLeg = lineas.Length;
            tb_legajo.Text = numLeg.ToString();

           

        }

        private void guardador(String legajo,String apellido,String nombre ,String dni ,String calle ,String numeroCalle ,String numeroPiso ,String numeroDpto) {


            //StreamReader lector = new StreamReader("C:\\Users\\Lucas21\\Desktop\\Programación\\codigos\\c#\\Parcial_project\\dataBaseEmpleados.txt");

            String olddata;
            //Lee el bloc de notas

            StreamReader lector = new StreamReader("C:\\Users\\Lucas21\\Desktop\\Programación\\codigos\\c#\\Parcial_project\\dataBaseEmpleados.txt");
            olddata = lector.ReadToEnd();
            lector.Close();

            //Escribe el bloc de notas

            StreamWriter escritor = new StreamWriter("C:\\Users\\Lucas21\\Desktop\\Programación\\codigos\\c#\\Parcial_project\\dataBaseEmpleados.txt");
            escritor.Write(olddata + legajo + "," + apellido + "," + nombre + "," + dni + "," + datetime1.Text + "," + calle + " " + numeroCalle + " Dpto: " + numeroDpto + " Piso: " + numeroPiso+"-");
            escritor.Close();


        }

        // Ejecuta las acciones del botón guardar
        private void b_save_Click(object sender, EventArgs e)
        {
          
            verificador();

        }

        private void limpiador()
        {
            tb_apellido.Text = "";
            tb_nombre.Text = "";
            tb_dni.Text = "";
            tb_calle.Text = "";
            tb_numero.Text = "";
            tb_piso.Text = "";
            tb_depto.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificador();
            //crearUsuario();
        }

        private void crearUsuario(String nombre, String apellido) {


            String oldDataUser = "";
            String[] celda;
            String comparar;

            nombre = nombre.ToLower(); apellido = apellido.ToLower();

            //Crea el nombre de usuario
            String usuario = "";


            StreamReader lector = new StreamReader("C:\\Users\\Lucas21\\Desktop\\Programación\\codigos\\c#\\Parcial_project\\dataBaseUser.txt");
            oldDataUser = lector.ReadToEnd();
            lector.Close();

            String[] lineas = oldDataUser.Split("-");

            bool bandera = true, bandera2 = true;
            int contador = 1;

            do
            {
                if (bandera2 == true)
                {
                    usuario = nombre.Substring(0, contador) + apellido;
                    bandera2 = false;
                }

                for (int i = 0; i < lineas.Length; i++)
                {
                    celda = lineas[i].Split(",");
                    comparar = celda[0];

                    if (usuario == comparar)
                    {
                        bandera = false; bandera2 = true; i = lineas.Length;
                    }

                 
                }

                if (bandera2 == false || contador == nombre.Length) { bandera = true; bandera2=true; }
                contador++;

            } while (bandera == false);

            StreamWriter escritor = new StreamWriter("C:\\Users\\Lucas21\\Desktop\\Programación\\codigos\\c#\\Parcial_project\\dataBaseUser.txt");
            escritor.WriteLine(oldDataUser + "-" + usuario  + ","+nombre + " " + apellido+"-");
            escritor.Close();

        }
    }
}
