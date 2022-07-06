using DesignerPatternsCSharp.Observer_Pattern.Interfaces;
using System.Collections.Generic;

namespace DesignerPatternsCSharp.Observer_Pattern
{
    public class EstacaoMeteorologica : ISubject
    {
        private List<IObserver> observers;
        private float _temperatura;

        public float Temperatura { get { return _temperatura; } set { _temperatura = value; Nofiticar(); } }
        public EstacaoMeteorologica()
        {
            this.observers = new List<IObserver>();
        }
        public void Anexar(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Nofiticar()
        {
            foreach (var item in observers)
            {
                item.Atualizar(this);
            }
        }
    }
}
