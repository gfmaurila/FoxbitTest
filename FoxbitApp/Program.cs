using Foxbit.Domain;
using Foxbit.Domain.Services;

namespace FoxbitApp;

class Program
{
    static void Main(string[] args)
    {
        Plateau plateau = new Plateau("5 5");

        RoverService rover1 = new RoverService("1 2 N", plateau);
        rover1.Execute("LMLMLMLMM");
        Console.WriteLine(rover1.ToString());

        RoverService rover2 = new RoverService("3 3 E", plateau);
        rover2.Execute("MMRMMRMRRM");
        Console.WriteLine(rover2.ToString());
    }
}


