using ProblemaRanking.Enums;
using ProblemaRanking.Models.Characters;
using ProblemaRanking.Models.Events;
using ProblemaRanking.Models.Match;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaRanking.Mocks
{
    public class ProblemaNovoMock : Mock
    {
        /// <summary>
        /// Alfred: 5 Kills, 2 Deaths
        /// Jim: 2 Kills,  2 Deaths |
        /// Matt: 2 Kills, 2 Deaths |
        /// Roman: 1 Kills, 1 Deaths |
        /// Player 1: 1 Kills, 2 Deaths |
        /// Nick: 0 Kills, 2 Deaths |
        /// </summary>
        public ProblemaNovoMock()
        {
            CurrentMatch = new Match() { Id = 11348970, Kills = new List<Kill>() };
            CurrentMatch.MatchPlayers = new List<MatchPlayer>();

            //0
            CurrentMatch.MatchPlayers.Add(new Bot("Roman", WeaponEnum.M16, WeaponEnum.Knife) { Id = 1 });
            //1
            CurrentMatch.MatchPlayers.Add(new Bot("Nick", WeaponEnum.AK47, WeaponEnum.Knife) { Id = 2 });
            //2
            CurrentMatch.MatchPlayers.Add(new Player("Player 1", WeaponEnum.M16, WeaponEnum.None) { Id = 3 });
            //3
            CurrentMatch.MatchPlayers.Add(new Bot("Matt", WeaponEnum.AK47, WeaponEnum.None) { Id = 4 });
            //4
            CurrentMatch.MatchPlayers.Add(new Bot("Alfred", WeaponEnum.M16, WeaponEnum.Knife) { Id = 5 });
            //5
            CurrentMatch.MatchPlayers.Add(new Bot("Jim", WeaponEnum.AK47, WeaponEnum.None) { Id = 6 });

            #region Round 1
            // Jim mata Roman com tiro no torso
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(5),
                CurrentMatch.MatchPlayers.ElementAt(0),
                CurrentMatch.MatchPlayers.ElementAt(5).PrimaryWeapon,
                DeathEnum.ShotInTorso) { TimeOfEvent = new DateTime(2013,4,25,15,10,12) });

            // Jim mata o jogador com tiro na cabeça
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(5),
                CurrentMatch.MatchPlayers.ElementAt(2),
                CurrentMatch.MatchPlayers.ElementAt(5).PrimaryWeapon,
                DeathEnum.Headshot) { TimeOfEvent = new DateTime(2013, 4, 25, 15, 10, 24) });

            // Alfred mata Jim com tiro nas pernas
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(4),
                CurrentMatch.MatchPlayers.ElementAt(5),
                CurrentMatch.MatchPlayers.ElementAt(4).PrimaryWeapon,
                DeathEnum.ShotInLegs) { TimeOfEvent = new DateTime(2013, 4, 25, 15, 11, 5) });

            // Alfred mata Nick com tiro na cabeça
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(4),
                CurrentMatch.MatchPlayers.ElementAt(1),
                CurrentMatch.MatchPlayers.ElementAt(4).PrimaryWeapon,
                DeathEnum.Headshot) { TimeOfEvent = new DateTime(2013, 4, 25, 15, 13, 47) });

            // Matt mata Alfred com tiro na cabeça
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(3),
                CurrentMatch.MatchPlayers.ElementAt(4),
                CurrentMatch.MatchPlayers.ElementAt(3).PrimaryWeapon,
                DeathEnum.Headshot) { TimeOfEvent = new DateTime(2013, 4, 25, 15, 15, 12) });

            // Matt mata a si próprio caindo
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(3),
                CurrentMatch.MatchPlayers.ElementAt(3),
                WeaponEnum.None,
                DeathEnum.Fall) { TimeOfEvent = new DateTime(2013, 4, 25, 15, 15, 16) });
            #endregion

            #region Round 2
            // Jogador mata Jim com facada na caveira
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(2),
                CurrentMatch.MatchPlayers.ElementAt(5),
                CurrentMatch.MatchPlayers.ElementAt(2).SecondaryWeapon,
                DeathEnum.Headshot) { TimeOfEvent = new DateTime(2013, 4, 25, 15, 21, 5) });

            // Alfred mata Nick com explosão
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(4),
                CurrentMatch.MatchPlayers.ElementAt(1),
                WeaponEnum.None,
                DeathEnum.Explosion) { TimeOfEvent = new DateTime(2013, 4, 25, 15, 22, 2) });

            // Alfred mata Matt com explosão
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(4),
                CurrentMatch.MatchPlayers.ElementAt(3),
                WeaponEnum.None,
                DeathEnum.Explosion) { TimeOfEvent = new DateTime(2013, 4, 25, 15, 22, 2) });

            // Alfred mata a si próprio com explosão
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(4),
                CurrentMatch.MatchPlayers.ElementAt(4),
                WeaponEnum.None,
                DeathEnum.Explosion) { TimeOfEvent = new DateTime(2013, 4, 25, 15, 22, 2) });

            // Roman mata Player com esmagamento
            CurrentMatch.Kills.Add(new Kill(CurrentMatch.MatchPlayers.ElementAt(0),
                CurrentMatch.MatchPlayers.ElementAt(2),
                WeaponEnum.None,
                DeathEnum.Crush) { TimeOfEvent = new DateTime(2013, 4, 25, 15, 24, 25) });
            #endregion
        }
    }
}
