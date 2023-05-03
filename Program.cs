using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_ex_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, h, s, imc;

            Console.Write("digite o peso: ");
            p = double.Parse(Console.ReadLine());
            Console.Write("digite a altura ");
            h = double.Parse(Console.ReadLine());
            Console.Write("informe o sexo (1 para homem ou outro valor para mulher):");
            s = double.Parse(Console.ReadLine());
            imc = p / (h * h);
            if (s == 1)
                if(imc>=25)
                Console.Write("acima da média! IMC: " + imc);
            else
                if (imc >= 20)
                Console.WriteLine("peso ideal! IMC: " + imc);
            else
                Console.WriteLine("abaixo da média! IMC: " + imc);


            else

            if (imc >= 24)
                Console.Write("acima da media! IMC: " + imc);
            else
                if (imc >= 19)
                Console.WriteLine("peso ideal! IMC : " + imc);
            else
                Console.WriteLine("abaixo da media! IMC: " + imc);

                


        }
    }
}
