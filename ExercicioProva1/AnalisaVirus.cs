using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProva1
{

    class AnalisaVirus
    {
         Covid covid = new Covid();

         H1N1 h1n1 = new H1N1();
        public void AnalisarVirus()
        {
            int Opcao = 0;
            do
            {
                Console.WriteLine("Escolha o Virus: ");
                Console.WriteLine("1 - Covid");
                Console.WriteLine("2 - H1N1");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("");
                Console.Write("A opção escolhida é: ");
                Opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (Opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o Nome do paciente: ");
                        covid.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a Observação: ");
                        covid.Observacao = Console.ReadLine();
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("Digite o Nome do paciente: ");
                        h1n1.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a observação: ");
                        h1n1.Observacao = Console.ReadLine();
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Escolha outra opção, porque essa é inválida!");
                        break;
                }

            } while (Opcao != 3);

            Console.ReadKey();
        }
    }
}
