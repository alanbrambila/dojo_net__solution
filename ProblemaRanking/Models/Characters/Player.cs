using ProblemaRanking.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemaRanking.Models.Characters
{
    public class Player : MatchPlayer
    {
        public Player(string name, WeaponEnum primaryWeapon, WeaponEnum secondaryWeapon)
            : base(name, primaryWeapon, secondaryWeapon)
        {

        }
    }
}