using DesignerPatternsCSharp.Decorator;
using DesignerPatternsCSharp.Decorator.Interface;
using DesignerPatternsCSharp.Observer_Pattern;
using System;

namespace DesignerPatternsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------Decorator----------------------------------------------------

            IPizza pizza = new Pizza();
            Console.WriteLine(pizza.BuyscarTipoPizza());

            IPizza queijoDecorator = new QueijoDecorator(pizza);
            Console.WriteLine(queijoDecorator.BuyscarTipoPizza());

            IPizza baconDecorator = new BaconDecorator(queijoDecorator);
            Console.WriteLine(baconDecorator.BuyscarTipoPizza());

            IPizza cebolaDecorator = new CebolaDecorator(baconDecorator);
            Console.WriteLine(baconDecorator.BuyscarTipoPizza());

            //-----------------Observer----------------------------------------------------

            EstacaoMeteorologica estacaoMeteorologica = new EstacaoMeteorologica();

            NovasAgenciaNoticias novasAgenciaNoticias = new NovasAgenciaNoticias("Agencia de noticia são paulo");
            estacaoMeteorologica.Anexar(novasAgenciaNoticias);

            NovasAgenciaNoticias novasAgenciaNoticias2 = new NovasAgenciaNoticias("Agencia de noticia Suzano");
            estacaoMeteorologica.Anexar(novasAgenciaNoticias2);

            estacaoMeteorologica.Temperatura = 31.4f;
            estacaoMeteorologica.Temperatura = 25f;
            estacaoMeteorologica.Temperatura = 26.7f;
            estacaoMeteorologica.Temperatura = 34.7f;
            estacaoMeteorologica.Temperatura = 22.7f;
            estacaoMeteorologica.Temperatura = 15.7f;

            Console.ReadLine();





        }
    }
}
