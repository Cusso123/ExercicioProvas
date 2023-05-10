using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProva1
{
    class Covid : Virus
    {
        public int TotalQuarantenaDias;
        public DateTime DiaPronto;
        public override void ImprimirRecomendacoesTratamento()
        {
            DiaPronto = DiaPronto.AddDays(TotalQuarantenaDias);
            Console.WriteLine("O dia que voce pode retornar é: " + DiaPronto);

        }
        public void CalcularDataRetorno()
        {
            Console.WriteLine("Digite a quantidade de dias em quarantena: ");
            TotalQuarantenaDias = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
    }
}
