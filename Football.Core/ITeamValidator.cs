namespace Football.Core
{
    using System.Diagnostics.Contracts;

    [ContractClass(typeof(TeamValidatorContract))]
    public interface ITeamValidator
    {
        bool Validate(Team team);
    }
}