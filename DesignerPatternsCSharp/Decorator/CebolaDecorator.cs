using DesignerPatternsCSharp.Decorator.Interface;

namespace DesignerPatternsCSharp.Decorator
{
    public class CebolaDecorator : PizzaDecorator
    {
        public CebolaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string BuyscarTipoPizza()
        {
            var pizza = base.BuyscarTipoPizza();
            pizza += "com extra de cebola";
            return pizza;
        }
    }
}
