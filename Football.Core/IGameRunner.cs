namespace Football.Core
{
    using System.Collections.Generic;

    public interface IGameRunner
    {
        bool Step(IDictionary<Player, PlayerAction> playerActions, Dictionary<Player, PlayerPosition> playerPositions, ref BallPosition ballPosition);
    }
}