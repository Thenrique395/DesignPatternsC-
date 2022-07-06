using DesignerPatternsCSharp.Decorator.Interface;

namespace DesignerPatternsCSharp.Decorator
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string BuyscarTipoPizza()
        {
            var pizza = base.BuyscarTipoPizza();
            pizza += "\r\n com extra de bacon";
            return pizza;
        }

    }
}
