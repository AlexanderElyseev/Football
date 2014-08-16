namespace Football.Core.Contracts
{
    using System;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(ITeamValidator))]
    abstract class TeamValidatorContract : ITeamValidator
    {
        bool ITeamValidator.Validate(Team team)
        {
            Contract.Requires<ArgumentNullException>(team != null);

            return true;
        }
    }
}