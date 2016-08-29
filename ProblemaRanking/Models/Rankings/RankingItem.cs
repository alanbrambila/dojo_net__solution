using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProblemaRanking.Models.Characters;
using ProblemaRanking.Models.Events;

namespace ProblemaRanking.Models.Rankings
{
    public class RankingItem
    {
        public Bot Player { get; set; }
        public ICollection<Kill> Kills { get; set; }
        public ICollection<Kill> Deaths { get; set; }
    }
}