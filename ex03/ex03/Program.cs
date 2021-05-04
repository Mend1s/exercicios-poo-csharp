using System;
using System.Globalization;


namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();

            Console.Write("DIGITE A ALTURA E LARGURA: ");
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + x.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
