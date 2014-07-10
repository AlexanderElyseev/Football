namespace Football.Core
{
    public interface IPlayerStrategy
    {
        PlayerAction GetAction(IGameRunnerState runnerState);
    }
}