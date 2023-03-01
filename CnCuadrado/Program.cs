using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnCuadrado
{
    internal class Program
    {
        /// <summary>
        /// Nombre:Viviana Muñoz
        /// Fecha:26/02/2023
        /// Descripcion:Programa que solicita el lado de un cuadrado e imprime el perimetro y superficie del mismo
        /// </summary>
        /// 
        static void Main(string[] args)
        {
            //Instancia de clase
            ClsCuadrado cuadrado = new ClsCuadrado();

            //Llamada de metodos
            cuadrado.CargarDatos();
            Console.WriteLine("el valor del perimetro es: " + cuadrado.perimetro(cuadrado.Lado));
            Console.WriteLine("El valor de la superficie es: " + cuadrado.superficie(cuadrado.Lado));


            Console.ReadKey();
        }
    }
}
