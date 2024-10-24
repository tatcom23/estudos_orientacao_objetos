﻿using System;
using System.Globalization;

namespace Exercicio
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Largura, 2))+( Math.Pow(Altura, 2)));
        }

        public override string ToString()
        {
            return "Area: "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + ", perimetro: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + ", diagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
