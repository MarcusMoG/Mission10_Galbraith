using Microsoft.EntityFrameworkCore;

namespace BowlingLeagueAPI.Data
{
    public class BowlerContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) { }   
        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
