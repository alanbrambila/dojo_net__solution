using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemaRanking.DTOs
{
    public class RankingDTO
    {
        public int MatchId { get; set; }
        public string Winner { get; set; }
        public string WinnerFavoriteWeapon { get; set; }
        public ICollection<AwardsDTO> Awards { get; set; }
        public ICollection<RankingItemDTO> RankingItens { get; set; }
    }
}