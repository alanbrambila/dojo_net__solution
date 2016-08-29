using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemaRanking.DTOs
{
    public class RankingItemDTO
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
    }
}
