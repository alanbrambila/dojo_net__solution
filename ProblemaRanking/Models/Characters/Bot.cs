using ProblemaRanking.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemaRanking.Models.Characters
{
    public class Bot : MatchPlayer
    {
        public Bot(string name, WeaponEnum primaryWeapon, WeaponEnum secondaryWeapon)
            : base(name, primaryWeapon, secondaryWeapon)
        {

        }
    }
}