namespace Football.Tests
{
    using System;

    using Football.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StandardTeamValidatorTest
    {
        [TestMethod]
        public void TestPlayersCount()
        {
            var players = new Player[10];

            var team = new Team(players);
            var validator = new StandardTeamValidator();

            Assert.IsFalse(validator.Validate(team));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullTeam()
        {
            new StandardTeamValidator().Validate(null);
        }

        [TestMethod]
        public void TestNullPlayers()
        {
            var players = new Player[11];
            for (int i = 0; i < 11; i++)
                players[i] = new Player("Player" + i);

            var team = new Team(players);
            var validator = new StandardTeamValidator();

            Assert.IsTrue(validator.Validate(team));
        }



    }
}
