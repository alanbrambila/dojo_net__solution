using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProblemaRanking.Models.Characters;
using ProblemaRanking.Models.Events;

namespace ProblemaRanking.Models.Match
{
    public class Match
    {
        public int Id { get; set; }
        public ICollection<MatchPlayer> MatchPlayers { get; set; }
        public ICollection<Kill> Kills { get; set; }
    }
}