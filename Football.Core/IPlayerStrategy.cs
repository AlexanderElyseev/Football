namespace Football.Core
{
    public interface IPlayerStrategy
    {
        PlayerAction GetAction(IGameState state);
    }
}