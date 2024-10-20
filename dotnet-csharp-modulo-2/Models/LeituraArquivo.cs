using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_csharp_modulo_2.Models
{
    public class LeituraArquivo
    {

        // método que retorna uma tupla
        public (bool Sucesso, string[] Linhas, int QuantidadeDeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);

                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}