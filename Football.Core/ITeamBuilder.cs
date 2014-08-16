namespace Football.Core
{
    using System.Diagnostics.Contracts;

    using Football.Core.Contracts;

    [ContractClass(typeof(TeamBuilderContract))]
    internal interface ITeamBuilder
    {
        Team BuildTeam();
    }
}