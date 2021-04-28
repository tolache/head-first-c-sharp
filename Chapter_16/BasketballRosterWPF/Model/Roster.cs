using System.Collections.Generic;

namespace BasketballRosterWPF.Model
{
    public class Roster
    {
        public string TeamName { get; }

        private List<Player> _players = new List<Player>();
        public IEnumerable<Player> Players => new List<Player>(_players);

        public Roster(string teamName, IEnumerable<Player> players)
        {
            TeamName = teamName;
            _players.AddRange(players);
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
            OnRosterUpdated(_players);
        }

        public void RemovePlayer(Player playerToRemove)
        {
            List<Player> playersTemp = new List<Player>();
            playersTemp.AddRange(_players);
            foreach (Player player in playersTemp)
            {
                if (player.Name == playerToRemove.Name && player.Number == playerToRemove.Number)
                    _players.Remove(player);
            }
            OnRosterUpdated(_players);
        }

        public delegate void RosterUpdatedEventHandler(object sender, RosterEventArgs args);
        public event RosterUpdatedEventHandler RosterUpdated;

        protected virtual void OnRosterUpdated(IEnumerable<Player> players)
        {
            RosterUpdated?.Invoke(this, new RosterEventArgs(players));
        }
    }
}