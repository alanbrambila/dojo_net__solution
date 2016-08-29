using ProblemaRanking.DTOs;
using ProblemaRanking.Models.Rankings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemaRanking.Application
{
    interface IAwardsApplication
    {
        ICollection<AwardsDTO> ConstruirAwards(Ranking ranking);
    }
}