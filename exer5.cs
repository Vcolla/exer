﻿using System;

namespace Somar_os_dígitos_de_um_número_inteiro_exer_5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(" Soma de Dígitos");
           

            int num, digito;
            int sum = 0;

            Console.Write("Informe um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                
                digito = num % 10;
                sum = sum + digito;
                num = num / 10;

            }

            Console.WriteLine("O valor da soma é: " + sum);
            Console.ReadKey();
        }
    }
}
        
   
