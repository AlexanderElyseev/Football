namespace Football.Core
{
    public interface ITeamStrategy
    {
        IPlayerStrategy GetPlayerStrategy(Player player);
    }
}