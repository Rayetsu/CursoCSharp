using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar() {
            var dateTime = new DateTime(year:2019, month:07,day: 28);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //sem hora

            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutos: " + diaAtual.Minute);
            Console.WriteLine("Data: " + diaAtual.Date);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("m"));
            Console.WriteLine(diaAtual.ToString("m"));
            Console.WriteLine(diaAtual.ToString("MM"));
            Console.WriteLine(diaAtual.ToString("yyyy"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
