using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1")); //1 casa décimal
            Console.WriteLine(valor.ToString("C")); //símbolo monetário
            Console.WriteLine(valor.ToString("P")); //x100 percentagem 
            Console.WriteLine(valor.ToString("#.##")); //duas casas decimais

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
