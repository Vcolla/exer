using System;

namespace Converter_celsius_em_fahrenheit_e_vice_versa_ex_3
{

    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            decimal numero1 = 32;
            string resposta;


            Console.WriteLine("Graus // Fahrenheit");


            Console.WriteLine("Para qual conversão deseja realizar, Celsius ou Fahrenheit?");
            resposta = Convert.ToString(Console.ReadLine());

            if (resposta == "Celsius" || resposta == "celsius")
            {

                Console.WriteLine("Digite a temperatura em Fahrenheit:");
                fahrenheit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("A conversão de " + (fahrenheit - 32) / 1.8 );

            }
            else if (resposta == "Fahrenheit" || resposta == "fahrenheit")
            {
                Console.WriteLine("Digite a temperatura em Celsius:");
                celsius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("A conversão de " + (celsius * 1.8 + 32));

            }
              
        }

   
    }
}
            
        
