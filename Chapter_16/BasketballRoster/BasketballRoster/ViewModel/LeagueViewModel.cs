using BasketballRoster.Model;
using System.Collections.Generic;

namespace BasketballRoster.ViewModel
{
    class LeagueViewModel
    {
        public RosterViewModel JimmysTeam { get; private set; }
        public RosterViewModel BriansTeam { get; private set; }

        public LeagueViewModel()
        {
            Roster briansRoster = new Roster("Bombers", GetBomberPlayers());
            BriansTeam = new RosterViewModel(briansRoster);

            Roster jimmysRoster = new Roster("Amazins", GetAmazinPlayers());
            JimmysTeam = new RosterViewModel(jimmysRoster);
        }

        private IEnumerable<Player> GetAmazinPlayers()
        {
            List<Player> amazinPlayers = new List<Player>() {
                new Player("Player 1", 1, true),
                new Player("Player 2", 2, true),
                new Player("Player 3", 3, true),
                new Player("Player 4", 4, true),
                new Player("Player 5", 5, true),
                new Player("Player 6", 6, false),
                new Player("Player 7", 7, false),
            };
            return amazinPlayers;
        }

        private IEnumerable<Player> GetBomberPlayers()
        {
            List<Player> bomberPlayers = new List<Player>() {
                new Player("Player 1", 8, true),
                new Player("Player 2", 9, true),
                new Player("Player 3", 10, true),
                new Player("Player 4", 11, true),
                new Player("Player 5", 12, true),
                new Player("Player 6", 13, false),
                new Player("Player 7", 14, false),
            };
            return bomberPlayers;
        }
    }
}
