using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProva1
{
    class H1N1 : Virus
    {
        public override void ImprimirRecomendacoesTratamento()
        {
            if (AnalisarVariacao(variacao = "AAA"))
            {
                Console.WriteLine("Pode trabalhar e usar mascara");
            }
            else
            {
                Console.WriteLine("Fica em casa por 5 dias!");
            }
           
        }
        public string AnalisarVariacao(string variacao)
        {

            Console.Write("A variação (AAA): ");
            variacao = Console.ReadLine();
            return variacao;
        }
    }
}
