using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----- DETERMINAR A MÉDIA DO ALUNO -----");

            Console.WriteLine("Informe a 1 nota: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a 2 nota: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a 3 nota: ");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            int media = (nota1 + nota2 + nota3) / 3;

            if (nota1 <= 10 && nota2 <= 10 && nota3 <= 10)
            {
                if (media >= 7)
                {
                    Console.WriteLine("Parabéns, você foi aprovado com média:" + " " + (media));
                }

                {
                    Console.WriteLine("Que pena, você foi reprovado com média" + " " + (media));

                }
            }
        }
    }
}
