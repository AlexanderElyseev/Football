namespace Football.Core
{
    public interface IGameRunnerStateBuilder
    {
        IGameState BuildState(GamePosition gamePosition);
    }
}