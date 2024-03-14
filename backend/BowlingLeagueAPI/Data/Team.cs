using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BowlingLeagueAPI.Data
{
    public class Team
    {
        [ForeignKey("TeamId")]
        public int TeamId { get; set; }
          
        public string? TeamName { get; set; }
    }
}
