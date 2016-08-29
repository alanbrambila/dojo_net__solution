using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProblemaRanking.Models;
using ProblemaRanking.Models.Characters;
using ProblemaRanking.Models.Match;
using ProblemaRanking.Models.Rankings;

namespace ProblemaRanking.Models.Rankings
{
    public class Ranking
    {
        public Match.Match _Match { get; set; }
        public ICollection<RankingItem> RankingItens  { get; set; }

        public Ranking(Match.Match match)
        {
            _Match = match;
        }
    }
}