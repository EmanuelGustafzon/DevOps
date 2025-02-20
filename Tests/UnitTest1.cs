using consoleApplication;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int ten = CountToTen.Count();

        Assert.Equal(10, ten);
    }
}
