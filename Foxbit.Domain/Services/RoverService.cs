using Foxbit.Domain.Enums;
using Foxbit.Domain.Interfaces;

namespace Foxbit.Domain.Services;
public class RoverService : IRoverService
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public EDirection Direction { get; private set; }

    private Plateau plateau;

    public RoverService(string position, Plateau plateau)
    {
        this.plateau = plateau;

        string[] parts = position.Split(' ');
        X = int.Parse(parts[0]);
        Y = int.Parse(parts[1]);
        Direction = (EDirection)Enum.Parse(typeof(EDirection), parts[2]);
    }

    public void Execute(string commands)
    {
        foreach (char command in commands)
        {
            switch (command)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'M':
                    Move();
                    break;
            }
        }
    }

    public void TurnLeft()
    {
        Direction = Direction - 1 < EDirection.N ? EDirection.W : Direction - 1;
    }

    public void TurnRight()
    {
        Direction = Direction + 1 > EDirection.W ? EDirection.N : Direction + 1;
    }

    public void Move()
    {
        switch (Direction)
        {
            case EDirection.N:
                Y = Math.Min(Y + 1, plateau.MaxY);
                break;
            case EDirection.E:
                X = Math.Min(X + 1, plateau.MaxX);
                break;
            case EDirection.S:
                Y = Math.Max(Y - 1, 0);
                break;
            case EDirection.W:
                X = Math.Max(X - 1, 0);
                break;
        }
    }

    public override string ToString()
    {
        return $"{X} {Y} {Direction}";
    }
}
