using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnCuadrado
{
    internal class ClsCuadrado
    {
        //Variable
        private double lado;

        public double Lado { get => lado; set => lado = value; }

        //Metodos
        public void CargarDatos()
        {
            Console.WriteLine("ingresa el valor de un lado");
            Lado = double.Parse(Console.ReadLine());
        }

        public double perimetro(double lado)
        {
            double perimetro1 = lado * 4;
            return perimetro1;


        }

        public double superficie(double lado)
        {
            double superficie1 = lado * lado;
            return superficie1;
        }
    }
}
