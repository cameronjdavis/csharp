namespace NetCamerond.Skillz.DesignPatterns;
public class DecoratorExample(IDecorator decorator) : IDecorator
{
    public bool IsWorkDone {get; private set;} = false;

    public void DoWork()
    {
        decorator.DoWork();
        this.IsWorkDone = true;
    }
}
