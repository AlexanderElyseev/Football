namespace Football.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    class SimpleGameRunner : IGameRunner
    {
        private readonly float _stepTime;

        public SimpleGameRunner(float stepTime)
        {
            Contract.Requires<ArgumentException>(stepTime > 0);

            _stepTime = stepTime;
        }

        public GamePosition Step(GamePosition currentPosition, GameAction gameAction)
        {
            var newFirstTeamPosition = GetNewTeamPosition(currentPosition.FirstTeamPosition, gameAction.FirstTeamAction);
            var newSecondTeamPosition = GetNewTeamPosition(currentPosition.SecondTeamPosition, gameAction.SecondTeamAction);
            var newBallPosition = GetNewBallPosition(currentPosition.BallPosition);

            return new GamePosition(currentPosition.Field, newFirstTeamPosition, newSecondTeamPosition, newBallPosition);
        }

        private static TeamPosition GetNewTeamPosition(TeamPosition currentTeamPosition, TeamAction secondTeamAction)
        {
            IDictionary<Player, PlayerPosition> firstTeamPositions = new Dictionary<Player, PlayerPosition>();
            foreach (KeyValuePair<Player, PlayerPosition> playerPosition in currentTeamPosition)
            {
                firstTeamPositions.Add(playerPosition.Key, new PlayerPosition());
            }

            return new TeamPosition(firstTeamPositions);
        }
        
        private static BallPosition GetNewBallPosition(BallPosition currentBallPosition)
        {
            return new BallPosition();
        }
    }
}