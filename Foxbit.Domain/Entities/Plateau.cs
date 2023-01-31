namespace Foxbit.Domain;
public class Plateau
{
    public int MaxX { get; private set; }
    public int MaxY { get; private set; }

    public Plateau(string size)
    {
        string[] parts = size.Split(' ');
        MaxX = int.Parse(parts[0]);
        MaxY = int.Parse(parts[1]);
    }
}
