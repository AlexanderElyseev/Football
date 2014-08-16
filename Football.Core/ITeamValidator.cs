namespace Football.Core
{
    using System.Diagnostics.Contracts;

    using Football.Core.Contracts;

    [ContractClass(typeof(TeamValidatorContract))]
    public interface ITeamValidator
    {
        bool Validate(Team team);
    }
}