namespace Football.Core
{
    using System.Diagnostics.Contracts;

    using Football.Core.Contracts;

    [ContractClass(typeof(GameRunnerContract))]
    public interface IGameRunner
    {
        GamePosition Step(GamePosition currentPosition, GameAction gameAction);
    }
}