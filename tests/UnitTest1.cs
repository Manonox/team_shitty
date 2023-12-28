namespace tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(1, Fubonakki.Calculate(0));
        Assert.Equal(1, Fubonakki.Calculate(1));
        Assert.Equal(1, Fubonakki.Calculate(2));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(9, Fubonakki.Calculate(5));
        Assert.Equal(17, Fubonakki.Calculate(6));
        Assert.Equal(85525, Fubonakki.Calculate(20));
    }

    [Fact]
    public void Test3()
    {
        Assert.Throws<Exception>(() => Fubonakki.Calculate(-1));
        Assert.Throws<Exception>(() => Fubonakki.Calculate(-5));
        Assert.Throws<Exception>(() => Fubonakki.Calculate(-10000));
    }
}