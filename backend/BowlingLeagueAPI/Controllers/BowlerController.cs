using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BowlingLeagueAPI.Data;
using System.Linq;

namespace YourNamespace.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersDataController : ControllerBase
    {
        private readonly BowlerContext _context;

        public BowlersDataController(BowlerContext context)
        {
            _context = context;
        }

        // GET: api/BowlersDataController
        [HttpGet]
        public IEnumerable<BowlerWithTeam> GetBowlersWithTeams()
        {
            var bowlersWithTeams = from bowler in _context.Bowlers
                                   join team in _context.Teams on bowler.TeamId equals team.TeamId
                                   where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                                   select new BowlerWithTeam
                                   {
                                       BowlerId = bowler.BowlerId,
                                       TeamId = team.TeamId,
                                       TeamName = team.TeamName,
                                       BowlerFirstName = bowler.BowlerFirstName,
                                       BowlerMiddleInit = bowler.BowlerMiddleInit,
                                       BowlerLastName = bowler.BowlerLastName,
                                       BowlerAddress = bowler.BowlerAddress,
                                       BowlerCity = bowler.BowlerCity,
                                       BowlerState = bowler.BowlerState,
                                       BowlerZip = bowler.BowlerZip,
                                       BowlerPhoneNumber = bowler.BowlerPhoneNumber
                                   };

            return bowlersWithTeams.ToList();
        }
    }

    // Define a class to hold the result of the join
    public class BowlerWithTeam
    {
        public int BowlerId { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string BowlerFirstName { get; set; }
        public string BowlerMiddleInit { get; set; }
        public string BowlerLastName { get; set; }
        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        public string BowlerState { get; set; }
        public string BowlerZip { get; set; }
        public string BowlerPhoneNumber { get; set; }
    }
}
