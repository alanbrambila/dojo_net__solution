using ProblemaRanking.Application;
using ProblemaRanking.DTOs;
using ProblemaRanking.Mocks;
using ProblemaRanking.Models.Match;
using ProblemaRanking.Models.Rankings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProblemaRanking.Controllers
{
    public class RankingController : ApiController
    {
        private IRankingApplication _rankingApplication;

        public RankingController()
        {
            _rankingApplication = new RankingApplication();
        }

        // GET: api/Ranking
        public RankingDTO Get(int? Id = null)
        {
            Mock mock;

            if (Id == 11348970) mock = new ProblemaNovoMock();
            else mock = new ProblemaOriginalMock();

            var ranking = _rankingApplication.ConstruirRanking(mock.CurrentMatch);

            return _rankingApplication.MontarDto(ranking);

        }
    }
}
