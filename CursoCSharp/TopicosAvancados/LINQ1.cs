using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1
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

            Console.WriteLine("** Aprovado **********");
            var aprovados = alunos.Where(a => a.Nota >= 5.0).OrderBy(a => a.Nota);

            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome + " - " + aluno.Nota);
            }

            Console.WriteLine("\n** Chamada ************");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);

            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n** Aprovados (por idade) ************");
            var alunosAprovados = from aluno in alunos
                                  where aluno.Nota >= 5.0
                                  orderby aluno.Idade
                                  select aluno.Nome;

            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}
