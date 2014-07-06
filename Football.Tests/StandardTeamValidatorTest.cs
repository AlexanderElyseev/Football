using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Football.Tests
{
    using Football.Core;

    [TestClass]
    public class StandardTeamValidatorTest
    {
        [TestMethod]
        public void TestCountOfPlayers()
        {
            var team = new Team(new Player[11]);
            var validator = new StandardTeamValidator();

            Assert.IsTrue(validator.Validate(team));
        }
    }
}
