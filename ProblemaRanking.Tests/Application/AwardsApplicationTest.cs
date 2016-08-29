using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemaRanking.Application;
using ProblemaRanking.Models.Rankings;
using ProblemaRanking.Mocks;

namespace ProblemaRanking.Tests.Application
{
    [TestClass]
    public class AwardsApplicationTest
    {
        [TestMethod]
        public void Unkillable()
        {
            // Arrange
            AwardsApplication awardsApplication = new AwardsApplication();
            var mock = new ProblemaOriginalMock();
            Ranking ranking = new RankingApplication().ConstruirRanking(mock.CurrentMatch);

            // Act
            var award = awardsApplication.GerarUnkillable(mock.CurrentMatch);

            // Assert
            Assert.IsNotNull(award);
            Assert.IsTrue(award.Count > 0);
            Assert.IsTrue(award.Any(x => x.WinnerId == 1));
            Assert.IsTrue(award.Any(x => x.WinnerId != 1));
        }
    }
}
