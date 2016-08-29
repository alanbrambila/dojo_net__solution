using ProblemaRanking.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemaRanking.Models.Characters
{
    public class MatchPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WeaponEnum PrimaryWeapon { get; set; }
        public WeaponEnum SecondaryWeapon { get; set; }

        public MatchPlayer(string name, WeaponEnum primaryWeapon, WeaponEnum secondaryWeapon)
        {
            Name = name;
            PrimaryWeapon = primaryWeapon;
            SecondaryWeapon = secondaryWeapon;
        }

    }
}