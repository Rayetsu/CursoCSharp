using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna() {
            return 1_407_033.65;
        }
    }

    //Não é possivel herdar
    //class SouFilho : SemFilho
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo
    {
        public override sealed bool HonrarNomeFamilia() {
            return true;
        }
    }


    class FilhoRebelde : Pai
    {
        //não é possivel sobrescrever com override uma vez que foi sealed, mas é possivel utilizar o "new" para criar
        //novo metodo com mesmo nome e assinatura
        //public override bool HonrarNomeFamilia() {
        //    return false;
        //}
    }
    class Sealed
    {

        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.HonrarNomeFamilia());
        }
    }
}
