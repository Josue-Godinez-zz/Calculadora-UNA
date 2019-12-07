using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    public class Triangulo : Figura
    {
        public double Base
        {
            get;
            set;
        }
        public double Altura
        {
            get;
            set;
        }

        public double Lado1
        {
            get;
            set;
        }
        public double Lado2
        {
            get;
            set;
        }
        
        public override double CalcularArea()
        {
            return Base * Altura / 2;
        }

        public override double CalcularPerimetro()
        {
            return Base + Lado1 + Lado2;
        }
    }
}