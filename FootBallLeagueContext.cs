using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FootBallLeague2.Models
{
    public class FootBallLeagueContext : DbContext
    {
        public DbSet<FootBallLeague> FootBallLeagues { get; set; }
    }
}