using ProblemaRanking.DTOs;
using ProblemaRanking.Enums;
using ProblemaRanking.Models.Match;
using ProblemaRanking.Models.Rankings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemaRanking.Application
{
    public class AwardsApplication : IAwardsApplication
    {
        public ICollection<AwardsDTO> ConstruirAwards(Ranking ranking)
        {
            var awards = new List<AwardsDTO>();

            awards.AddRange(GerarUnkillable(ranking._Match));

            return awards;
        }

        public ICollection<AwardsDTO> GerarUnkillable(Match match)
        {
            var awards = new List<AwardsDTO>();

            foreach (var player in match.MatchPlayers)
            {
                if (!match.Kills.Where(x => x.Killed == player).Any())
                {
                    awards.Add(new AwardsDTO()
                        {
                            AwardType = AwardEnum.Unkillable.ToString(),
                            WinnerId = player.Id,
                            WinnerName = player.Name
                        });
                }
            }
            return awards;
        }
    }
}