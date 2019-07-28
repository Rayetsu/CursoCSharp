using System;
using System.IO;

namespace CursoCSharp.Api
{
    class LendoArquivos
    {

        public static void Executar() {
            var path = @"~/lendo_Arquivos.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preco;Quantidade");
                    sw.WriteLine("Laranja;0.15;10");
                    sw.WriteLine("Pizza;2.00;2");
                }
            }

            try {
                using (StreamReader sr = new StreamReader(path)) {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
