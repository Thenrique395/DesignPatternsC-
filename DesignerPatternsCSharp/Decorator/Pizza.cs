using DesignerPatternsCSharp.Decorator.Interface;

namespace DesignerPatternsCSharp.Decorator
{
    public class Pizza : IPizza
    {
        public string BuyscarTipoPizza()
        {
            var pizza = "Essa é uma pizza normal";

            return pizza;
        }
    }
}
