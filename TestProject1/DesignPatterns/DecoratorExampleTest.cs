namespace NetCamerond.Test.Skillz.DesignPatterns;
using Moq;
using NetCamerond.Skillz.DesignPatterns;
using Subject = NetCamerond.Skillz.DesignPatterns.DecoratorExample;
public class DecoratorExampleTest
{
    private Subject subject;
    private Mock<IDecorator> decorator;
    public DecoratorExampleTest() {
        this.decorator = new Mock<IDecorator>();
        this.subject = new Subject(this.decorator.Object);
    }
    [Fact]
    public void CallInternalDecorator()
    {
        this.subject.DoWork();
        this.decorator.Verify(x => x.DoWork(), Times.Once());
    }
    [Fact]
    public void MarkWorkDone()
    {
        Assert.False(this.subject.IsWorkDone);
        this.subject.DoWork();
        Assert.True(this.subject.IsWorkDone);
    }
}
