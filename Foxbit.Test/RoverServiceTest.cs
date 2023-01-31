using Foxbit.Domain;
using Foxbit.Domain.Services;

namespace Foxbit.Test;

public class RoverServiceTest
{
    [Fact]
    public void TestInitialPosition()
    {
        Plateau plateau = new Plateau("5 5");

        RoverService rover1 = new RoverService("1 2 N", plateau);
        rover1.Execute("LMLMLMLMM");
        Assert.Equal("1 3 N", rover1.ToString());

        RoverService rover2 = new RoverService("3 3 E", plateau);
        rover2.Execute("MMRMMRMRRM");
        Assert.Equal("5 1 E", rover2.ToString());
        Console.WriteLine(rover2.ToString());
    }
}