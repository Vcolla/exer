using System;

namespace Equação_de_2_grau_exer_4
{
    namespace Exe04
    {
        class Program
        {
            static void Main(string[] args)
            {
                double valorA, valorB, valorC;

                Console.WriteLine("Bhaskara");

                Console.WriteLine("Digite o Valor A: ");
                valorA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o Valor B: ");
                valorB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o Valor C: ");
                valorC = Convert.ToDouble(Console.ReadLine());

                double delta = (valorB* valorB) - (4 * valorA * valorC);
                double raiz = Math.Sqrt(delta);
                var x1 = ((-(valorB)) + raiz) / (2 * valorA);
                var x2 = ((-(valorB)) - raiz) / (2 * valorA);

                Console.WriteLine("Valor de X: " + x1 + " Valor de X: " + x2);

            }
        }
    }
}
