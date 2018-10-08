using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{

    class Comentarios
    {
        /// <summary>
        /// XML Comments
        /// </summary>
        public static void Executar()
        {
            // Cuidado  com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");

            /*
             * Comentário de
             * múltiplas linhas
             */
            Console.WriteLine("O C# tem o XML Comments");

            //ctr + k, ctr + c ---> Comentar
            //ctr + k, ctr + u ---> Descomentar
            Console.WriteLine("1");
            Console.WriteLine("2");
            // ctr + d ---> Duplica a linha onde o cursor está
        }
    }
}
