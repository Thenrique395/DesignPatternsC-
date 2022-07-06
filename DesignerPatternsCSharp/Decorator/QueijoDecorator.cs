using DesignerPatternsCSharp.Decorator.Interface;

namespace DesignerPatternsCSharp.Decorator
{
    //concrete
    public class QueijoDecorator : PizzaDecorator
    {
        public QueijoDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string BuyscarTipoPizza()
        {
            var pizza = base.BuyscarTipoPizza();
            pizza += "\r\n com extra de queijo";
            return pizza;
        }
    }
}
