namespace NetCamerond.Test;

public class Cam1Test
{
    [Fact]
    public void Test1()
    {
        Cam1 cam1 = new(); 
        Assert.Equal(2, cam1.returnTwo());
    }
    [Fact]
    public void Test2()
    {
        Cam1 cam1 = new(); 
        Assert.Equal(2, cam1.returnTwo());
    }
}
