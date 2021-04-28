using System;
using System.Collections.Generic;

namespace BasketballRosterWPF.Model
{
    public class RosterEventArgs : EventArgs
    {
        public IEnumerable<Player> Players { get; }

        public RosterEventArgs(IEnumerable<Player> players)
        {
            Players = new List<Player>(players);
        }
    }
}