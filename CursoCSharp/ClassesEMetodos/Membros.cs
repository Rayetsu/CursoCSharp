using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Gabriel";
            sicrano.Idade = 24;

            Console.WriteLine($"{ sicrano.Nome} tem {sicrano.Idade} anos.");

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
