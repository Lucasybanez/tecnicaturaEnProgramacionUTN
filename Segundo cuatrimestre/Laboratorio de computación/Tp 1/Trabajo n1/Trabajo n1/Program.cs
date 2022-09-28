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
                        puntoOcho();
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
           
            int edadTMañana;
            int edadTTarde;
            int edadTNoche;
            int i;
            double sumadorTMañana;
            double sumadorTTarde;
            double sumadorTNoche;
            double promedioTMañana;
            double promedioTTarde;
            double promedioTNoche;

            Console.Clear();
            Console.WriteLine("-----Ejecutando el punto numero 8-----");
            Console.WriteLine(""); Console.WriteLine("");

            sumadorTMañana = 0;
            for (i = 0; i < 50; i++)
            {
                Console.Write($"Ingresar la edad del alumno {i} de Turno Mañana: ");
                edadTMañana = Convert.ToInt32(Console.ReadLine());
                sumadorTMañana = sumadorTMañana + edadTMañana;
            }
            Console.WriteLine();
            sumadorTTarde = 0;
            for (i = 0; i < 60; i++)
            {
                Console.Write($"Ingresar la edad del alumno {i} de Turno Tarde: ");
                edadTMañana = Convert.ToInt32(Console.ReadLine());
                sumadorTTarde = sumadorTTarde + edadTMañana;
            }
            Console.WriteLine();
            sumadorTNoche = 0;
            for (i = 0; i < 110; i++)
            {
                Console.Write($"Ingresar la edad del alumno {i} de Turno Noche: ");
                edadTMañana = Convert.ToInt32(Console.ReadLine());
                sumadorTNoche = sumadorTNoche + edadTMañana;
            }
            Console.WriteLine();
            promedioTMañana = sumadorTMañana / 50;
            Console.WriteLine();
            promedioTTarde = sumadorTTarde / 60;
            Console.WriteLine();
            promedioTNoche = sumadorTNoche / 110;
            Console.WriteLine();
            Console.Write($"Promedio de edad del turno mañana: {promedioTMañana}");
            Console.Write($"Promedio de edad del turno tarde: {promedioTTarde}");
            Console.Write($"Promedio de edad del turno noche: {promedioTNoche}");
            Console.WriteLine();
            if (promedioTMañana < promedioTTarde && promedioTMañana < promedioTNoche)
            {
                Console.WriteLine("El turno mañana tiene un promedio de edad menor");
            }
            if (promedioTTarde < promedioTMañana && promedioTTarde < promedioTNoche) ;
            {
                Console.WriteLine("El turno tarde tiene un promedio de edad menor");
            }
            if (promedioTNoche < promedioTMañana && promedioTNoche < promedioTTarde) ;
            {
                Console.WriteLine("El turno noche tiene un promedio de edad menor");
            }

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("-----El punto a terminado su ejecución-----");
        }

        static void puntoNueve()
        {
            int x;
            int numero;
            double saldo;
            double saldoAcreedores;


            Console.Clear();
            Console.WriteLine("-----Ejecutando el punto numero 9-----");
            Console.WriteLine(""); Console.WriteLine("");

            saldoAcreedores = 0;
            x = 1;
            do
            {
                Console.WriteLine();
                Console.Write("Ingresar el número de la cuenta: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingresar el saldo de la cuenta: ");
                saldo = Convert.ToDouble(Console.ReadLine());

                if (numero >= 0)
                {
                    if (saldo > 0)
                    {
                        Console.WriteLine();
                        Console.Write($"Número de la cuenta: {numero}");
                        Console.WriteLine();
                        Console.Write("Estado de la cuenta: Acreedor");
                        saldoAcreedores = saldoAcreedores + saldo;
                    }
                    else
                    {
                        if (saldo < 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Número de la cuenta: {numero}");
                            Console.WriteLine("Estado de la cuenta: Deudor");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Número de la cuenta: {numero}");
                            Console.WriteLine("Estado de la cuenta: Nulo");
                        }
                    }
                    Console.WriteLine();
                }
                else { break; }
            } while (x != 0);

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("-----El punto a terminado su ejecución-----");
        }

        static void puntoDiez()
        {
            Console.Clear();
            Console.WriteLine("-----Ejecutando el punto numero 10-----");
            Console.WriteLine(""); Console.WriteLine("");

            int[] alumnoA;
            int[] alumnoB;
            double sumadorA;
            double sumadorB;
            double promedioA;
            double promedioB;
            int i;


            Console.Clear(); //borrar pantalla
            Console.WriteLine();

            alumnoA = new int[5];
            alumnoB = new int[5];
            sumadorA = 0;

            for (i = 0; i < alumnoA.Length; i++)
            {
                Console.Write($"Ingrese la nota del alumno {i} del curso A: ");
                alumnoA[i] = Convert.ToInt32(Console.ReadLine());
                sumadorA = sumadorA + alumnoA[i];
            }
            Console.WriteLine();
            sumadorB = 0;
            for (i = 0; i < alumnoA.Length; i++)
            {
                Console.Write($"Ingrese la nota del alumno {i} del curso B: ");
                alumnoB[i] = Convert.ToInt32(Console.ReadLine());
                sumadorB = sumadorB + alumnoB[i];
            }
            promedioA = sumadorA / 5;
            promedioB = sumadorB / 5;
            Console.WriteLine();

            if (promedioA > promedioB)
            {
                Console.Write($"El curso A tuvo un mayor promedio general de: {promedioA}");
            }
            else
            {
                Console.Write($"El curso B tuvo un mayor promedio general de: {promedioB}");
            }

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("-----El punto a terminado su ejecución-----");
        }

    }



}
