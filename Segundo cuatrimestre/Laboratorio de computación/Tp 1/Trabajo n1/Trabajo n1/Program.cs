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
                        puntoCinco();
                        break;

                    case 6:
                        puntoSeis();
                        break;

                    case 7:
                        puntoSiete();
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
            int total = 0, correctas=0, porcentaje=0;

            Console.Clear();
            Console.WriteLine("-----Ejecutando el punto numero 5-----");
            Console.WriteLine(""); Console.WriteLine("");


            Console.Write("Ingrese la cantidad de preguntas: ");
            total = Int32.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de preguntas respondidas correctamente: ");
            correctas = Int32.Parse(Console.ReadLine());

            porcentaje = (correctas * 100) / total;

            if (porcentaje>50)
            {
                if (porcentaje <= 75)
                {
                    Console.WriteLine("Nivel regular: " + porcentaje + "%");
                }

                else if (porcentaje>75 && porcentaje<90)
                {
                    Console.WriteLine("Nivel medio: " + porcentaje + "%");
                }

                else
                {
                    Console.WriteLine("Nivel máximo: " + porcentaje + "%");
                }
            }

            else
            {
                Console.WriteLine("Menos de 50% " + porcentaje);
            }

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("-----El punto a terminado su ejecución-----");
        }

        static void puntoSeis()
        {
            int sueldo = 0, antiguedad = 0;

            Console.Clear();
            Console.WriteLine("-----Ejecutando el punto numero 6-----");
            Console.WriteLine(""); Console.WriteLine("");


            Console.Write("Ingrese el sueldo del empleado: $");
            sueldo = Int32.Parse(Console.ReadLine());

            Console.Write("Ingrese la antiguedad del empleado: ");
            antiguedad = Int32.Parse(Console.ReadLine());

            if (sueldo<500 && antiguedad>10)
            {
                Console.WriteLine("Se le otorgará un aumento del 20%, el nuevo sueldo es: $" + sueldo*1.20);
            }

            else
            {
                Console.WriteLine("Sueldo sin cambios $"+sueldo);
            }

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("-----El punto a terminado su ejecución-----");
        }

        static void puntoSiete()
        {
            int sueldo=1, sueldosMenores = 0, sueldosMayores=0, gasto=0, empleados=1;

            Console.Clear();
            Console.WriteLine("-----Ejecutando el punto numero 7-----");
            Console.WriteLine(""); Console.WriteLine("");

            Console.WriteLine("Para terminar el ingreso de empleados ingrese 0");

            while (sueldo != 0)
            {
                Console.WriteLine("");
                Console.Write("Ingrese el sueldo del empleado numero "+ empleados +": $");
                sueldo = Int32.Parse(Console.ReadLine());

                if (sueldo >= 100 & sueldo<=300)
                {
                    empleados++;
                    sueldosMenores++;
                    gasto = gasto + sueldo;
                }

                else if (sueldo>300 && sueldo<=500)
                {
                    empleados++;
                    sueldosMayores++;
                    gasto = gasto + sueldo;
                }

                else if (sueldo == 0){}

                else
                {
                    Console.WriteLine("Valor ingresado no válido");
                }

                
            }
            Console.Clear();
            Console.WriteLine("El numero total de empleados ingresados es " + (empleados-1));
            Console.WriteLine("El numero total de empleados con sueldos menores es " + sueldosMenores);
            Console.WriteLine("El numero total de empleados con sueldos mayores es " + sueldosMayores);
            Console.WriteLine("El gasto total generado por la empresa es $" + gasto);

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("-----El punto a terminado su ejecución-----");
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
