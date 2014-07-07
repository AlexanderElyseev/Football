namespace Football.Core
{
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(ITeamBuilder))]
    abstract class TeamBuilderContract : ITeamBuilder
    {
        Team ITeamBuilder.BuildTeam()
        {
            Contract.Ensures(Contract.Result<Team>() != null);

            return null;
        }
    }
}