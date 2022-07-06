using DesignerPatternsCSharp.Decorator;
using DesignerPatternsCSharp.Decorator.Interface;
using System;

namespace DesignerPatternsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPizza pizza = new Pizza();

            //Console.WriteLine(pizza.BuyscarTipoPizza());

            IPizza queijoDecorator = new QueijoDecorator(pizza);
            Console.WriteLine(queijoDecorator.BuyscarTipoPizza());

            IPizza baconDecorator = new BaconDecorator(queijoDecorator);
            Console.WriteLine(baconDecorator.BuyscarTipoPizza());

            IPizza cebolaDecorator = new CebolaDecorator(baconDecorator);
            Console.WriteLine(baconDecorator.BuyscarTipoPizza());

        }
    }
}
