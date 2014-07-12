namespace Football.Core
{
    using System.Diagnostics.Contracts;

    [ContractClass(typeof(GameRunnerContract))]
    public interface IGameRunner
    {
        GamePosition Step(GamePosition currentPosition, GameAction gameAction);
    }
}