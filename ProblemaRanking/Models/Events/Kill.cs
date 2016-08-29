using ProblemaRanking.Enums;
using ProblemaRanking.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemaRanking.Models.Events
{
    public class Kill
    {
        public MatchPlayer Killer { get; set; }
        public MatchPlayer Killed { get; set; }
        public WeaponEnum Weapon { get; set; }
        public DeathEnum DeathType { get; set; }
        public DateTime TimeOfEvent { get; set; }

        public Kill(MatchPlayer killer, MatchPlayer killed, WeaponEnum weapon, DeathEnum deathType)
        {
            Killer = killer;
            Killed = killed;
            Weapon = weapon;
            DeathType = deathType;

            TimeOfEvent = DateTime.Now;
        }
    }
}