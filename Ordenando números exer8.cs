using System;

namespace Empilhar_números_e_invertê_los_de_posição_exer_7
{

            class Ex7
        {
            static void Main(string[] args)
            {


               
                Console.WriteLine("Empilhar números e inverter posição#");
               ;


                int[] array = new int[10];
                int numero;

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Informe um número");
                    numero = Convert.ToInt32(Console.ReadLine());

                    array[i] = numero;
                }

                Console.WriteLine("Posição inicial da pilha.");

                foreach (int value in array) Console.WriteLine("[" + value + "]");


                Console.ReadKey();

                //Forma manual de inverter um array
                /*
                            Console.WriteLine("Posição inicial da pilha.");
                            for (int i = 0; i < 10; i++) {
                                Console.WriteLine("[" + array[i] + "]");
                            }
                            Console.WriteLine("Posição invertida da pilha.");
                            for (int i = 9; i >= 0; i--) {
                                Console.WriteLine("[" + array[i] + "]");
                            }
                */
            }
        }
 }
