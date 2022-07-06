using DesignerPatternsCSharp.Observer_Pattern.Interfaces;
using System;

namespace DesignerPatternsCSharp.Observer_Pattern
{
    public class NovasAgenciaNoticias : IObserver
    {

        public string NomeAgencia { get; set; }
        public NovasAgenciaNoticias(string nomeAgencia)
        {
            NomeAgencia = nomeAgencia;
        }

        public void Atualizar(ISubject subject)
        {
            if (subject is EstacaoMeteorologica estacaoMeteorologica)
            {
                Console.WriteLine(string.Format("{0} reportando a temperatura {1} graus celsius", NomeAgencia, estacaoMeteorologica.Temperatura));
                Console.WriteLine();
            }
        }
    }
}
