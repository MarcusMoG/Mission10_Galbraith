﻿namespace BowlingLeagueAPI.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
    }

}
