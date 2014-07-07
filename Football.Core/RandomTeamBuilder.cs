namespace Football.Core
{
    public class RandomTeamBuilder : ITeamBuilder
    {
        public Team BuildTeam()
        {
            return new Team(new Player[11]);
        }
    }
}