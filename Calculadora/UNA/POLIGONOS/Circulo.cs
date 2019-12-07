using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    public class Circulo : Figura
    {

        public double Radio
        {
            get;
            set;
        }

        public override double CalcularArea()
        {
            return 2 * Math.PI * Radio;
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * Math.Pow(Radio,2);
        }
    }
}