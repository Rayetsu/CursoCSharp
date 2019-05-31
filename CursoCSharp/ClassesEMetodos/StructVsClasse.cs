﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class StructVsClasse
    {
        public struct SPonto
        {
            public int X;
            public int Y;
        }

        public class CPonto
        {
            public int X;
            public int Y;
        }
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; //Atribuição por VALOR!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 x:{0}", ponto1.X);
            Console.WriteLine("Cópia Ponto 1 x:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; //Atribuição por REFERÊNCIA!!
            ponto1.X = 4;

            Console.WriteLine("Ponto 2 x:{0}", ponto2.X);
            Console.WriteLine("Cópia Ponto 1 x:{0}", copiaPonto2.X);
        }
    }
}