namespace DesignerPatternsCSharp.Observer_Pattern.Interfaces
{
    public interface ISubject
    {
        void Anexar(IObserver observer);
        void Nofiticar();
    }
}
