using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemaRanking;
using ProblemaRanking.Controllers;
using ProblemaRanking.DTOs;
using ProblemaRanking.Models.Rankings;
using System.Collections.Generic;
using System.Linq;

namespace ProblemaRanking.Tests.Controllers
{
    [TestClass]
    public class RankingControllerTest
    {
        [TestMethod]
        public void ObterRanking()
        {
            // Arrange
            RankingController controller = new RankingController();

            // Act
            RankingDTO result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RankingTemPartida()
        {
            // Arrange
            RankingController controller = new RankingController();

            // Act
            RankingDTO result = controller.Get();

            // Assert
            Assert.IsTrue(result.MatchId > 0);
        }

        [TestMethod]
        public void RankingTemPersonagens()
        {
            // Arrange
            RankingController controller = new RankingController();

            // Act
            RankingDTO result = controller.Get();

            // Assert
            Assert.IsNotNull(result.RankingItens); 
            Assert.IsTrue(result.RankingItens.All(x => x.PlayerId > 0));
        }

        [TestMethod]
        public void RankingTemKillsOuDeaths()
        {
            // Arrange
            RankingController controller = new RankingController();

            // Act
            RankingDTO result = controller.Get();

            // Assert
            Assert.IsNotNull(result.RankingItens);

            Assert.IsTrue(result.RankingItens.Any(x => x.Kills > 0 || x.Deaths > 0));
        }

        [TestMethod]
        public void Awards()
        {
            // Arrange
            RankingController controller = new RankingController();
            
            // Act
            RankingDTO result = controller.Get();

            // Assert
            Assert.IsNotNull(result.Awards);
        }


    }
}
