using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProva1
{
    abstract class Virus
    {
        public string Nome;
        public string Observacao;

        public abstract void ImprimirRecomendacoesTratamento();
    }
}
