namespace Football.Core
{
    using System.Collections.Generic;

    public interface IGameRunner
    {
        bool Step(GamePosition playerActions, GameAction playerPositions, ref BallPosition ballPosition);
    }
}