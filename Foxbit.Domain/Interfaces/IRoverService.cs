namespace Foxbit.Domain.Interfaces;

public interface IRoverService
{
    void Execute(string commands);
    void TurnLeft();
    void TurnRight();
    void Move();
    string ToString();
}