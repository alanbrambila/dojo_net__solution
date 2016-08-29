using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemaRanking.Models.Events;
using ProblemaRanking.Models.Characters;
using ProblemaRanking.Enums;
using ProblemaRanking.Models.Match;

namespace ProblemaRanking.Mocks
{
    public class ProblemaOriginalMock : Mock
    {
        
        public ProblemaOriginalMock()
        {
            CurrentMatch = new Match() { Id = 11348965, Kills = new List<Kill>() };
            CurrentMatch.MatchPlayers = new List<MatchPlayer>();

            CurrentMatch.MatchPlayers.Add(new Bot("Roman", WeaponEnum.M16, WeaponEnum.Knife) { Id = 1 });
            CurrentMatch.MatchPlayers.Add(new Bot("Nick", WeaponEnum.AK47, WeaponEnum.Knife) { Id = 2 });
            CurrentMatch.MatchPlayers.Add(new Player("Player 1", WeaponEnum.M16, WeaponEnum.None) { Id = 3 });

            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(0),
                CurrentMatch.MatchPlayers.ElementAt(1), 
                CurrentMatch.MatchPlayers.ElementAt(1).PrimaryWeapon,
                DeathEnum.ShotInTorso));

            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(2),
                CurrentMatch.MatchPlayers.ElementAt(1),
                CurrentMatch.MatchPlayers.ElementAt(2).PrimaryWeapon,
                DeathEnum.Drown));
        }
    }
}
