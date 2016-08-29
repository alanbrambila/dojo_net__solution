using ProblemaRanking.DTOs;
using ProblemaRanking.Models.Characters;
using ProblemaRanking.Models.Events;
using ProblemaRanking.Models.Match;
using ProblemaRanking.Models.Rankings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemaRanking.Application
{
    public class RankingApplication : IRankingApplication
    {
        private IAwardsApplication _awardsApplication;
        public RankingApplication()
        {
            _awardsApplication = new AwardsApplication();
        }
        public RankingDTO MontarDto(Ranking ranking)
        {
            return new RankingDTO()
            {
                MatchId = ranking._Match.Id,
                RankingItens = ranking.RankingItens.Select(x => new RankingItemDTO()
                {
                    PlayerId = x.Player.Id,
                    PlayerName = x.Player.Name,
                    Deaths = x.Deaths.Count,
                    Kills = x.Kills.Count,
                }).ToList(),
                Awards = _awardsApplication.ConstruirAwards(ranking),
                Winner = ranking.RankingItens.First().Player.Name,
                WinnerFavoriteWeapon = ObterArmaFavorita(ranking.RankingItens.First().Player, ranking._Match.Kills)
            };
        }

        public Ranking ConstruirRanking(Match match)
        {
            var ranking = new Ranking(match);

            ranking.RankingItens = MontarLinhas(match);

            ranking.RankingItens = OrdenarRanking(ranking.RankingItens);

            return ranking;
        }

        public ICollection<RankingItem> MontarLinhas(Match match)
        {
            var linhas = new List<RankingItem>();
            
            foreach (var player in match.MatchPlayers)
            {
                if (player is Player) continue;

                linhas.Add(new RankingItem() 
                    {
                        Player = player as Bot,
                        Kills = RetornarKillsPorAssassino(player, match.Kills),
                        Deaths = RetornarKillsPorAssassinado(player, match.Kills)
                    });
            }

            return linhas;
        }

        public ICollection<RankingItem> OrdenarRanking(ICollection<RankingItem> linhas)
        {
            return linhas.OrderByDescending(x => x.Kills.Count).ThenBy(x => x.Deaths.Count).ToList();
        }

        private ICollection<Kill> RetornarKillsPorAssassino(MatchPlayer assassino, ICollection<Kill> kills)
        {
            return kills.Where(x => x.Killer.Id == assassino.Id).ToList();
        }

        private ICollection<Kill> RetornarKillsPorAssassinado(MatchPlayer assassinado, ICollection<Kill> kills)
        {
            return kills.Where(x => x.Killed.Id == assassinado.Id).ToList();
        }

        private string ObterArmaFavorita(MatchPlayer player, ICollection<Kill> kills)
        {
            return kills.Where(x => x.Killer.Id == player.Id)
                .GroupBy(x => x.Weapon)
                .Select(x => x.ToList())
                .OrderByDescending(x => x.Count)
                .First().First()
                .Weapon
                .ToString();;
        }
    }
}