using System;

namespace Calcular_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, x, y, z, w;

            Console.WriteLine("Digite a sua idade");
            idade = int.Parse(Console.ReadLine());

            x = idade*12;
            Console.WriteLine("Você viveu "+x+" meses");

            y = idade*365;
            Console.WriteLine("Você viveu "+y+" dias");

            z = y*24;
            Console.WriteLine("Você viveu "+z+" horas");

            w = z*60;
            Console.WriteLine("Você viveu "+w+" minutos");

            }
    }
}
