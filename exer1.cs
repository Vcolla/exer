using System;

namespace calculando_dias_dos_meses_ex_1
{
  
  
        class Program
        {
            static void Main(string[] args)
            {

                int mes;
                
               

            
                Console.WriteLine("Calculadora de dias em meses");
              

                Console.Write("Por favor, informe quanto(s) mes(es) deseja saber a quantidade de dia(s): ");
                mes = Convert.ToInt32(Console.ReadLine());

               
                Console.WriteLine(mes * 30 );

            }
            
            }
        }

