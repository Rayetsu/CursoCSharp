using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno(){Nome = "João", Idade = 21, Nota = 8.0},
                new Aluno(){Nome = "Bruna", Idade = 23, Nota = 9.1},
                new Aluno(){Nome = "Gabriel", Idade = 24, Nota = 10.0},
                new Aluno(){Nome = "Miguelito", Idade = 21, Nota = 4.3},
                new Aluno(){Nome = "João", Idade = 26, Nota = 6.7},
                new Aluno(){Nome = "Madalena", Idade = 20, Nota = 7.7},
                new Aluno(){Nome = "Asdrubal", Idade = 18, Nota = 3.7},
            };

            var gabriel = alunos.Single(a => a.Nome.Equals("Gabriel"));
            Console.WriteLine($"{gabriel.Nome} {gabriel.Nota}");

            var fulano = alunos.SingleOrDefault(a => a.Nome.Equals("Fulano"));
            if (fulano == null) {
                Console.WriteLine("Aluno inexistente!");
            }

            var joao = alunos.First(a => a.Nome.Equals("João"));
            Console.WriteLine($"{joao.Nome} {joao.Nota}");

            var sicrano = alunos.FirstOrDefault(a => a.Nome.Equals("Sicrano"));
            if (sicrano == null) {
                Console.WriteLine("Aluno inexistente!");
            }

            var outroJoao = alunos.LastOrDefault(a => a.Nome.Equals("João"));
            Console.WriteLine($"{joao.Nome} {joao.Nota}");

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(a => a.Nota);
            Console.WriteLine(maiorNota);
            var menorNota = alunos.Min(a => a.Nota);
            Console.WriteLine(menorNota);

            var somatorioNota = alunos.Sum(a => a.Nota);
            Console.WriteLine(somatorioNota);

            var mediaDaTurma = alunos.Average(a => a.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
