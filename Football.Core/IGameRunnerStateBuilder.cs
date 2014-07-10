namespace Football.Core
{
    public interface IGameRunnerStateBuilder
    {
        IGameRunnerState BuildState(GamePosition gamePosition);
    }
}