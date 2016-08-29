using ProblemaRanking.DTOs;
using ProblemaRanking.Models.Events;
using ProblemaRanking.Models.Match;
using ProblemaRanking.Models.Rankings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemaRanking.Application
{
    interface IRankingApplication
    {
        RankingDTO MontarDto(Ranking ranking);
        Ranking ConstruirRanking(Match match);
    }
}
