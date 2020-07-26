using System;

namespace ExercicioPOO4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Controle Remoto");
            ControleRemoto controle = new ControleRemoto();
            Console.WriteLine($"Canal Atual: {controle.ConsultarCanal()}");
            Console.WriteLine($"Volume Atual: {controle.ConsultarVolume()}");
            Console.WriteLine("Aumentando Canal");
            controle.AumentarCanal();
            Console.WriteLine($"Canal Atual: {controle.ConsultarCanal()}");
            Console.WriteLine("Diminuindo Canal");
            controle.DiminuirCanal();
            Console.WriteLine($"Canal Atual: {controle.ConsultarCanal()}");
            Console.WriteLine("Aumentando Volume");
            controle.AumentarVolume();
            Console.WriteLine($"Volume Atual: {controle.ConsultarVolume()}");
            Console.WriteLine("Diminuindo Volume");
            controle.DiminuirVolume();
            Console.WriteLine($"Volume Atual: {controle.ConsultarVolume()}");
            Console.WriteLine("Definir Canal 10");
            controle.DefinirCanal(10);
            Console.WriteLine($"Canal Atual: {controle.ConsultarCanal()}");

        }
    }
}
