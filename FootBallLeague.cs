using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FootBallLeague2.Models
{
    [Table("FootBallLeague")]
    public class FootBallLeague
    {
        [Key]
        public int MatchId { get; set; }
        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }
        public string MatchStatus { get; set; }
        public string WinningTeam { get; set; }

        public int Points { get; set; }


    }
}