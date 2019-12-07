using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    public class Cuadrado : Figura
    {
         
        public Cuadrado(double lado)
        {
            Lado = lado;
        }
        public double Lado
        {
            get;
            set;
        }
        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return Lado * 4; 
        }
    }
}