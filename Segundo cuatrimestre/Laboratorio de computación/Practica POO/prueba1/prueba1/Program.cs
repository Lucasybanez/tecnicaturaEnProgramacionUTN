using System;

namespace prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno est1 = new Alumno();
            est1.imprimir();
            Console.ReadKey();
        }
    }

    class Alumno
    {
        public string nombre;
        public string apellido;

        public Alumno()
        {
            Console.WriteLine("Ingrese el nombre del alumno: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del alumno: ");
            apellido = Console.ReadLine();
        }

        public void imprimir()
        {
            Console.WriteLine("El nombre del alumno es: " + nombre);
            Console.WriteLine("El apellido del alumno es: " + apellido);
        }
    }
}
