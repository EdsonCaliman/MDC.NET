namespace Exercicio4
{
    public class Aluno
    {
        public string Nome {get; set;}
        public double Nota { get; set; }

        public bool AlunoComNotaMaiorQueSete()
        {
            return Nota > 7;
        }
    }
}
