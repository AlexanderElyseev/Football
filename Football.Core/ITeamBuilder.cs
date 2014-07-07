namespace Football.Core
{
    using System.Diagnostics.Contracts;

    [ContractClass(typeof(TeamBuilderContract))]
    internal interface ITeamBuilder
    {
        Team BuildTeam();
    }
}