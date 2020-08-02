using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4
{
    public class Aluno
    {
        public string Nome {get; set;}
        public double Nota { get; set; }

        public bool AlunoComNotaMaiorQueSete()
        {
            return this.Nota > 7;
        }
    }
}
