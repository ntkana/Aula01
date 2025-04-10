using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Classes
{
    public class Calculadora
    {
        private double x = 0;
        private double y = 0;

        public Calculadora(double a, double b)
        {
            x = a;
            y = b;
        }

        public double Somar()
        {
            return x + y;
        }
        public double Subtrair()
        {
            return x - y;
        }
        public double Multiplicar()
        {
            return x * y;
        }
        public double Dividir()
        {
            return x / y;
        }
    }
}
