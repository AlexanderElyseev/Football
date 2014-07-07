namespace Football.Tests
{
    using Football.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RandomTeamBuilderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            new RandomTeamBuilder().BuildTeam();
        }
    }
}
