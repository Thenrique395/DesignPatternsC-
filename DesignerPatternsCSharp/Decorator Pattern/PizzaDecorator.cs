using DesignerPatternsCSharp.Decorator.Interface;

namespace DesignerPatternsCSharp.Decorator
{
    public class PizzaDecorator : IPizza
    {
        //Base Decorator
        private readonly IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string BuyscarTipoPizza()
        {
            var pizza = _pizza.BuyscarTipoPizza();
            return pizza;
        }
    }
}
