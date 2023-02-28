using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnCuadrado
{
    /// <summary>
    /// 22/02/2023
    /// Jaider Andres Oquendo Zapata.
    /// Programa que representa un Cuadrado y tiene los siguientes métodos:
    /// cargar el valor de su lado, imprimir su perímetro y su superficie.
    /// </summary>
    internal class Program
    {
        double Lado;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa del cuadrado.");
            //instancia la clase para invocar los metodos.
            Program cuadrado = new Program();
            cuadrado.ValorLado();
            cuadrado.perimetro();
            cuadrado.superficie();


            Console.ReadKey();
        }

        //Metodos.

        //Metodo para cargar el valor del lado del cuadrado.
        public void ValorLado()
        {
            Console.WriteLine("Por favor ingrese el valor del lado del cuadrado: ");
            Lado= Convert.ToDouble(Console.ReadLine());
        }
        //Metodo para imprimir su perímetro.
        public void perimetro()
        {
            double perimetro = Lado * 4;
            Console.WriteLine( "El perimetro del cuadrado es: "+perimetro );
        }
        //Metodo para imprimir su superficie.
        public void superficie()
        {
            double superficie = Lado * Lado;
            Console.WriteLine("La superficie del cuadrado es: " + superficie);

        }
    }
}
