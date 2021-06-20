using System;
using System.Collections.Generic;
using System.Text;

namespace percentual_de_voto_exer_09
{
    class PercVotos
    {

        public float total;
        public float validos;
        public float brancos;
        public float nulos;

        public void Validos()
        {
            float perc = validos / total * 100;
            Console.WriteLine("Votos válidos é de: " + perc + "% com relação a " + total + " eleitores");
        }
        public void Brancos()
        {
            float perc = brancos / total * 100;
            Console.WriteLine("Votos em branco é de: " + perc + "% com relação a " + total + " eleitores");
        }
        public void Nulos()
        {
            float perc = nulos / total * 100;
            Console.WriteLine("Votos em nulo é de: " + perc + "% com relação a " + total + " eleitores");
        }
    }
}
