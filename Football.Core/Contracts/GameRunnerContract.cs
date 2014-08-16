namespace Football.Core.Contracts
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Linq;

    [ContractClassFor(typeof(IGameRunner))]
    abstract class GameRunnerContract : IGameRunner
    {
        GamePosition IGameRunner.Step(GamePosition currentPosition, GameAction gameAction)
        {
            Contract.Requires<ArgumentNullException>(currentPosition != null);
            Contract.Requires<ArgumentNullException>(gameAction != null);

            Contract.Ensures(Contract.Result<GamePosition>() != null);
            Contract.Ensures(Contract.Result<GamePosition>().FirstTeamPosition != null);
            Contract.Ensures(Contract.Result<GamePosition>().FirstTeamPosition.Count() == currentPosition.FirstTeamPosition.Count());
            Contract.Ensures(Contract.Result<GamePosition>().SecondTeamPosition != null);
            Contract.Ensures(Contract.Result<GamePosition>().SecondTeamPosition.Count() == currentPosition.SecondTeamPosition.Count());

            throw new InvalidOperationException();
        }
    }
}