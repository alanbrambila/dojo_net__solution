using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemaRanking.Application;
using ProblemaRanking.Models.Characters;
using ProblemaRanking.Mocks;

namespace ProblemaRanking.Tests.Application
{
    [TestClass]
    public class RankingApplicationTest
    {
        [TestMethod]
        public void ConstruirRanking()
        {
            // Arrange
            RankingApplication rankingApplication = new RankingApplication();
            var mock = new ProblemaOriginalMock();

            // Act
            var ranking = rankingApplication.ConstruirRanking(mock.CurrentMatch);

            // Assert
            Assert.IsNotNull(ranking);
            Assert.IsNotNull(ranking.RankingItens);

            /*Verifica se o Roman está em primeiro */

            var primeiroDoRanking = ranking.RankingItens.First().Player.Name;
            var esperado = "Roman";

            Assert.AreEqual(primeiroDoRanking, esperado, string.Format("Primeiro do Ranking: {0}, esperado: {1}", primeiroDoRanking, esperado));
        }

        [TestMethod]
        public void ConstruirRankingProblemaNovo()
        {
            // Arrange
            RankingApplication rankingApplication = new RankingApplication();
            var mock = new ProblemaNovoMock();

            // Act
            var ranking = rankingApplication.ConstruirRanking(mock.CurrentMatch);

            // Assert
            Assert.IsNotNull(ranking);
            Assert.IsNotNull(ranking.RankingItens);

            /*Valida o primeiro lugar */
            var primeiroDoRanking = ranking.RankingItens.ElementAt(0).Player.Id;
            var primeiroEsperado = 5;

            Assert.AreEqual(primeiroDoRanking, primeiroEsperado);

            /*Valida o segundo lugar */
            var segundoDoRanking = ranking.RankingItens.ElementAt(1).Player.Id;
            var segundoEsperado = 4;

            Assert.AreEqual(segundoDoRanking, segundoEsperado);

            /*Valida o terceiro lugar*/
            var terceiroDoRanking = ranking.RankingItens.ElementAt(2).Player.Id;
            var terceiroEsperado = 6;

            Assert.AreEqual(terceiroDoRanking, terceiroEsperado);

            /*Valida o quarto lugar*/
            var quartoDoRanking = ranking.RankingItens.ElementAt(3).Player.Id;
            var quartoEsperado = 1;

            Assert.AreEqual(quartoDoRanking, quartoEsperado);

            /*Valida o quinto lugar*/
            var quintoDoRanking = ranking.RankingItens.ElementAt(4).Player.Id;
            var quintoEsperado = 2;

            Assert.AreEqual(quintoDoRanking, quintoEsperado);
        }

        [TestMethod]
        public void MontarLinhas()
        {
            // Arrange
            RankingApplication rankingApplication = new RankingApplication();
            var mock = new ProblemaOriginalMock();

            // Act
            var rankingItens = rankingApplication.MontarLinhas(mock.CurrentMatch);

            // Assert
            Assert.IsNotNull(rankingItens);

            Assert.AreEqual(rankingItens.Count, mock.CurrentMatch.MatchPlayers.Count - 1);

            foreach (var rankingItem in rankingItens)
            {
                Assert.IsInstanceOfType(rankingItem.Player, typeof(Bot));

                if ((rankingItem.Player.Name == "Nick") && (rankingItem.Deaths.Count != 2))
                    Assert.Fail(string.Format("Nick morreu duas vezes. Mas o retorno diz {0}", rankingItem.Deaths.Count));

            }
        }

        [TestMethod]
        public void ArmaFavorita()
        {
            // Arrange
            RankingApplication rankingApplication = new RankingApplication();
            var mock = new ProblemaNovoMock();
            var ranking = rankingApplication.ConstruirRanking(mock.CurrentMatch);
            
            // Act
            var rankingDto = rankingApplication.MontarDto(ranking);

            // Assert
            Assert.AreEqual("None", rankingDto.WinnerFavoriteWeapon);
        }

    }

}
