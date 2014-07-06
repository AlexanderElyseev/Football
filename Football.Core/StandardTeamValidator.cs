namespace Football.Core
{
    using System.Linq;

    public class StandardTeamValidator : ITeamValidator
    {
        public bool Validate(Team team)
        {
            if (team.Players.Any(p => p == null))
                return false;

            return team.Players.Count() == 11;
        }
    }
}