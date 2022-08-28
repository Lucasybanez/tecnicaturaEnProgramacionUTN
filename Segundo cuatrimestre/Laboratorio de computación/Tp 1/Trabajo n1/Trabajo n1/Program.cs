using System;

namespace Trabajo_n1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool bandera = true;


            while (bandera == true)
            {
                Console.WriteLine(""); Console.WriteLine("");
                Console.Write("Ingrese el punto del trabajo que desea ejecutar o bien ' 0 ' para cerrar: ");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        puntoUno();
                        break;

                    case 2:
                        puntoDos();
                        break;

                    case 3:
                        puntoTres();
                        break;

                    case 4:
                        puntoCuatro();
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;

                    case 10:
                        break;

                    case 0:
                        Console.WriteLine("-----Fin de la ejecución del programa, presione una tecla cualquiera para cerrar-----");
                        bandera = false;
                        break;

                    default:
                        Console.WriteLine("Numero ingresado no válido, intente otra vez");
                        break;
                }
            }

            Console.ReadKey();
        }


        static void puntoUno()
        {
            float precio = 0, cantidad = 0;

            Console.Clear();
            Console.WriteLine("-----Ejecutando el punto numero 1-----");
            Console.WriteLine(""); Console.WriteLine("");

            Console.Write("Ingrese el precio del producto: ");
            precio = float.Parse(Console.ReadLine());

            Console.Write("Ingrese las unidades de producto: ");
            cantidad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("El total a abonar es: $" + precio * cantidad);

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("-----El punto a terminado su ejecución-----");
        }

        static void puntoDos()
        {
            int sumaDeValores=0;

            Console.Clear();
            Console.WriteLine("-----Ejecutando el punto numero 2-----");
            Console.WriteLine(""); Console.WriteLine("");

            Console.Write("Ingrese el primer valor: ");
            sumaDeValores = Int32.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            sumaDeValores = sumaDeValores + Int32.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer valor: ");
            sumaDeValores = sumaDeValores + Int32.Parse(Console.ReadLine());

            Console.WriteLine("La sumatoria de los valores ingresados es " + sumaDeValores + " y el promedio de ellos es " + sumaDeValores/3);

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("-----El punto a terminado su ejecución-----");
        }

        static void puntoTres()
        {
            int sumaDeValores = 0;

            Console.Clear();
            Console.WriteLine("-----Ejecutando el punto numero 3-----");
            Console.WriteLine(""); Console.WriteLine("");

            Console.Write("Ingrese la primera nota: ");
            sumaDeValores = Int32.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");
            sumaDeValores = sumaDeValores + Int32.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");
            sumaDeValores = sumaDeValores + Int32.Parse(Console.ReadLine());

            if (sumaDeValores/3>=7)
            {
                Console.WriteLine("El alumno ha promocionado");
            }
            else
            {
                Console.WriteLine("El alumno no ha promocionado");
            }

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("-----El punto a terminado su ejecución-----");
        }

        static void puntoCuatro()
        {
            int valor = 0;

            Console.Clear();
            Console.WriteLine("-----Ejecutando el punto numero 4-----");
            Console.WriteLine(""); Console.WriteLine("");


            Console.Write("Ingrese un número de uno o dos dígitos");
            valor = Int32.Parse(Console.ReadLine());

            if (valor>0 && valor<10)
            {
                Console.WriteLine("El número tiene un dígito");
            }
            else if (valor>=10 && valor<1000)
            {
                Console.WriteLine("El número tiene dos dígitos");
            }
            else
            {
                Console.WriteLine("El número ingresado no es válido");
            }

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("-----El punto a terminado su ejecución-----");
        }

        static void puntoCinco()
        {

        }

        static void puntoSeis()
        {

        }

        static void puntoSiete()
        {

        }

        static void puntoOcho()
        {

        }

        static void puntoNueve()
        {

        }

        static void puntoDiez()
        {

        }

    }



}
