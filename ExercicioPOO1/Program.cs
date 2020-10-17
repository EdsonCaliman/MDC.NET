using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

//O que é POO?
/* 
 é um paradigma de programação que tem como base dois conceitos chave: classes e objetos.
 surgiu como alternativa a programação estruturada. 
 O intuito foi aproximar o manuseio das estruturas de um programa ao manuseio das coisas do mundo real.
 Abaixo segue um exemplo de uma classe Carro que seria possível ter uma instancia de um objeto através da instanciação da classe.
    class Carro
    {
        double velocidade;
        string modelo;

        public Carro(string modelo)
        {
            modelo = modelo;
            velocidade = 0;
        }

        public void acelerar()
        {
            //código para o carro acelerar
        }
    }
 */

//O que é polimorfismo?
/*
É o efeito que dizemos quando um método pode ser implementado de formas diferentes em classes diferentes.
Um carro elétrico e outro a combustão tem o mesmo método acelerar, mas internamente cada classe tem sua implementação de forma de aceleração.

    class Carro
    {
        protected virtual void mecanismoParaAcelerar()
        {
            //código que define quanto o carro acelera
        }

        public void acelerar()
        {
            mecanismoParaAcelerar();
        }
    }


    class CarroEletrico : Carro
    {
        protected override void mecanismoParaAcelerar()
        {
            //código para acelerar carro elétrico
        }
    }

    class CarroCombustao : Carro
    {
        protected override void mecanismoParaAcelerar()
        {
            //código para acelerar carro a combustão
        }
    }
 */

//O que é abstração?
/*
É utilizada para definir as entidades do mundo real no paradigma de orientação a objetos, tendo como consideração as suas características e ações.
A classe carro apresentada acima é uma abstração de um objeto no mundo real.
 */

//O que é encapsulamento?
/*
O encapsulamento impede o acesso a métodos e atributos por alguém que não deveria vê-lo.
No exemplo da classe carro não é interessante expor o acesso ao método que faz o carro acelerar,
mas sim a um método que chama o mecanismo de aceleração, assim só permitindo acelerar e não alterar a forma de aceleração.
No exemplo abaixo o método mecanismoParaAcelerar está encapsulado, pois não permite o acesso externo a classe.
Também foram alteradas as propriedades velocidade e modelo, para não serem acessadas por fora da classe.

    class Carro
    {
        private double velocidade;
        private string modelo;
        public Carro(string modelo)
        {
            modelo = modelo;
            velocidade = 0;
        }

        private void mecanismoParaAcelerar()
        {
            //código que define quanto o carro acelera
        }

        public void acelerar()
        {
            mecanismoParaAcelerar();
        }
    }


 */

//Quando usar uma classe abstrata e quando devo usar uma interface?
/*
Uma interface é um contrato, não pode ter código, somente assinatura, todos os métodos são abstratos.
Uma classe abstrata pode ter a assinatura de métodos abstratos e também métodos com códigos, para ser utilizado através da herança.

    abstract class Carro
    {
        abstract public void acelerar();

        public void frear()
        {
              //código para frear, comum a todas as classes filhas  
        }
    }

    interface IVeiculo
    {
        void acelerar();
    }

 */

//O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
/*
IDisposable
A interface IDisposable fornece um mecanismo para liberar recursos não gerenciados.
Usamos o método Dispose método desta interface para explicitamente liberar recursos não gerenciados em conjunto com o coletor de lixo. 
O consumidor de um objeto pode chamar esse método quando o objeto não for mais necessário.

    class GerenciadorArquivos : IDisposable
    {
        FileStream fs;

        public GerenciadorArquivos(string caminho)
        {
            fs = new FileStream(caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        public void Escrever(byte[] dados)
        {
            fs.Write(dados, 0, dados.Length);
        }

        public void Dispose()
        {
            fs.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            using (GerenciadorArquivos gerenciador = new GerenciadorArquivos("teste.data"))
            {
                byte[] dados = Encoding.ASCII.GetBytes("Edson Caliman");
                gerenciador.Escrever(dados);
            }
        }
    }


IComparable
A interface IComparable define um método genérico de comparação para ordenar ou classificar suas instâncias.

    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> lista = new List<Carro>();
            lista.Add(new Carro() { AnoFabricacao = 2020, Tipo = "Novo", Preco = 1000 });
            lista.Add(new Carro() { AnoFabricacao = 2020, Tipo = "Novo", Preco = 900 });
            lista.Add(new Carro() { AnoFabricacao = 2009, Tipo = "Usado", Preco = 200 });
            lista.Add(new Carro() { AnoFabricacao = 2006, Tipo = "Usado", Preco = 200 });

            // Utiliza o método da interface :  IComparable.CompareTo()
            lista.Sort();

            lista.ForEach(carro => Console.WriteLine(carro));
        }

        public class Carro : IComparable<Carro>
        {
            public int Preco { get; set; }
            public string Tipo { get; set; }
            public int AnoFabricacao { get; set; }
            public int CompareTo([AllowNull] Carro other)
            {
                if (Tipo.Contains("Novo"))
                {
                    return Preco.CompareTo(other.Preco);
                }

                return AnoFabricacao.CompareTo(other.AnoFabricacao);
            }

            public override string ToString()
            {
                return "Fabricação: " + AnoFabricacao + "Preço: " + Preco + "Tipo: " + Tipo;
            }
        }
    }

ICloneable
A interface ICloneable dá suporte à clonagem, que cria uma nova instância de uma classe com o mesmo valor de uma instância existente.

    class Carro : ICloneable
    {
        public int Ano { get; set; }
        public Carro() {}

        public Carro(Carro c)
        {
            Ano = c.Ano;
        }

        public object Clone()
        {
            return new Carro();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro() { Ano = 2000 };

            var c2 = (Carro)c1.Clone();
        }
    }

IEnumerable
A interface IEnumerable suporta uma iteração sobre uma coleção não genérica. 
A interface possui apenas o método GetEnumerator que retorna um enumerador que itera sobre a coleção.
No exemplo abaixo é possível executar o foreach na no array de strings por conta da implementação da interface IEnumerable

    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Edson", "Augusto" };

            foreach (string item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }

 */

//Existe herança múltipla(de classes) em C#?
/*
C# não suporta herança múltipla.
Para superar essa limitação, são utilizadas interfaces.

    class Forma
    {
            public void setLado(int s)
            {
                lado = s;
            }
            protected int lado;
    }
    interface ICusto
    {
            int getCusto(int area);
    }
    class Quadrado : Forma, ICusto
    {
            public int getArea()
            {
                return (lado * lado);
            }
            public int getCusto(int area)
            {
                return area * 10;
            }
    }


 */


namespace ExercicioPOO1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

}
