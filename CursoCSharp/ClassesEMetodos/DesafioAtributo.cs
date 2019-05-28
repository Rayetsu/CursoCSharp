using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar() {
            // Acessar variavel 'a' dentro do método Executar

            Console.WriteLine(new DesafioAtributo().a);
        }
    }
}
