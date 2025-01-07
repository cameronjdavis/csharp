namespace NetCamerond.Skillz.DesignPatterns;
public class DecoratorExample : IDecorator
{
    private IDecorator decorator;
    public DecoratorExample(IDecorator decorator)
    {
        this.decorator = decorator;
    }
    public void DoWork()
    {
        this.decorator.DoWork();
        // todo do more work
    }
}
