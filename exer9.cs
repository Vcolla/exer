using System;

namespace percentual_de_voto_exer_09
{


    class Ex9
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Percentual de votos");


            string aux;

            PercVotos obj = new PercVotos();

            Console.WriteLine("Informe o total de votos");
            obj.total = Convert.ToInt32(Console.ReadLine());

            do
            {

                Console.WriteLine("Qual percentual de votos deseja saber: [v] válidos, [b] brancos, [n] nulos");
                aux = Convert.ToString(Console.ReadLine());

                if (aux == "v")
                {
                    Console.WriteLine("Informe o número de votos válidos");
                    obj.validos = Convert.ToInt32(Console.ReadLine());
                    obj.Validos();
                }
                else if (aux == "b")
                {
                    Console.WriteLine("Informe o total de votos em branco");
                    obj.brancos = Convert.ToInt32(Console.ReadLine());
                    obj.Brancos();
                }
                else if (aux == "n")
                {
                    Console.WriteLine("Informe o total de votos nulos");
                    obj.nulos = Convert.ToInt32(Console.ReadLine());
                    obj.Nulos();
                }
                Console.WriteLine("Digite sair para finalizar ou aperte a tecla Enter para saber outro percentual com relação a " + obj.total + " votos.");
                aux = Convert.ToString(Console.ReadLine());

            } while (aux != "sair");
        }
    }
}  
  
