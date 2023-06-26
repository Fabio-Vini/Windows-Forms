using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_distancias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double converter;
            Console.WriteLine("Opções de conversão:");
            Console.WriteLine("1- Metros para quilômetros");
            Console.WriteLine("2- quilômetros para metros");
            Console.WriteLine("3- Milhas para quilômetros");
            Console.WriteLine("4- Quilômetros para milhas");
            Console.WriteLine("5- Léguas para quilômetros");
            Console.WriteLine("6- Quilômetros para léguas");
            Console.WriteLine("");
            Console.Write("Digite a opção desejada:");
            double op = double.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Informe a distãncia (em metros): ");
                    double dist = double.Parse(Console.ReadLine());

                    converter = dist / 1000;
                    Console.Write("Distância em quilômetros: " + converter + "Km");
                    break;
                ///
                case 2:
                    Console.Write("Informe a distância (em Km): ");
                    dist = double.Parse(Console.ReadLine());

                    converter = dist * 1000;
                    Console.Write("Distância em metros: " + converter + "m");
                    break;
                ///
                case 3:
                    Console.Write("Informe a distância (em milhas): ");
                    dist = double.Parse(Console.ReadLine());

                    converter = dist * 1.609;
                    Console.Write("Distância em quilômetros: " + converter + "Km");
                    break;
                ///
                case 4:
                    Console.Write("Informe a distância (em Km): ");
                    dist = double.Parse(Console.ReadLine());

                    converter = dist * 1.609;
                    Console.Write("Distância em milhas: " + converter + "mi");
                    break;
                ///
                case 5:
                    Console.Write("Informe a distância (em léguas): ");
                    dist = double.Parse(Console.ReadLine());

                    converter = dist * 4.828;
                    Console.Write("Distância em quilômetros: " + converter + "Km");
                    break;
                ///
                case 6:
                    Console.Write("Informe a distância (em km): ");
                    dist = double.Parse(Console.ReadLine());

                    converter = dist / 4.828;
                    Console.Write("Distância em léguas: " + converter + "Km");
                    break;
                ///
                default:
                    Console.WriteLine("Opção inválida!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
