using System;

namespace Triangulo_exer10
{
    using System;

    namespace Exe10
    {
        class Ex10
        {
            static void Main(string[] args)
            {

                
                Console.WriteLine("Verificação de triângulo");
                



                CalcTriangulo obj = new CalcTriangulo();


                Console.Write("Informe o primeiro lado: ");
                obj.a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o segundo lado: ");
                obj.b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o terceiro lado: ");
                obj.c = Convert.ToInt32(Console.ReadLine());

                obj.Triangulo();
            }
        }
    }


    // Classe para cálculodo triângulo


    class CalcTriangulo
    {

        public int a;
        public int b;
        public int c;

        public void Triangulo()
        {

            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.WriteLine("É um Triângulo");
            }
            else
            {
                Console.WriteLine("Não é um Triângulo");
            }
        }
    }
}