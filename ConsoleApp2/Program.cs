using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual forma geometrica voce gostaria de medir? 1(Quadrado), 2(Retangulo), 3(Trapézio), 4(Losango)");
            int geometrica = int.Parse(Console.ReadLine());

            switch (geometrica)
            {

                case 1:
                    Console.WriteLine("Digite o tamanho do lado do quadrado: ");
                    int lado = int.Parse(Console.ReadLine());
                    int quadrado = lado * lado;
                    Console.WriteLine("A area do quadrado é de: " + quadrado);
                    break;
                case 2:
                    Console.WriteLine("Digite a altura do retângulo: ");
                    int altura = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a medida da base do retângulo: ");
                    int basee = int.Parse(Console.ReadLine());
                    int retangulo = basee * altura;
                    Console.WriteLine("A area do retângulo é de: " + retangulo);
                    break;
                case 3:
                    Console.WriteLine("Digite a medida da base maior do trapézio: ");
                    int base1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a medida da base menor do trapézio: ");
                    int base2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura do trapézio: ");
                    int alto = int.Parse(Console.ReadLine());
                    int trape = ((base1 + base2) * alto) / 2;
                    Console.WriteLine("A area do trapézio é de: " + trape);
                    break;
                case 4:
                    Console.WriteLine("Digite a medida da diagonal maior do losango: ");
                    int diago1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a medida da diagonal menor do losango: ");
                    int diago2 = int.Parse(Console.ReadLine());
                    int losango = (diago1 * diago2) / 2;
                    Console.WriteLine("A area do trapézio é de: " + losango);
                break;
            }

            Console.ReadKey();
            }
    }
}
