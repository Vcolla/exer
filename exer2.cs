using System;


namespace Reajuste_salarial
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            Console.Write("Digite o valor do salario: ");
            valor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a % do reajuste: ");
            double percentual = Convert.ToDouble(Console.ReadLine()) / 100.0; //
           
            double valor_final = valor + (percentual * valor);

            Console.WriteLine("Salario Reajustado é:");
            Console.WriteLine(valor_final);


        }
        }
    }

