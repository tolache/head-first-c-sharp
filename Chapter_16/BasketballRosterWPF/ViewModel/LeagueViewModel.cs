using System.Collections;
using System.Collections.Generic;
using BasketballRosterWPF.Model;

namespace BasketballRosterWPF.ViewModel
{
    public class LeagueViewModel
    {
        public RosterViewModel JimmysTeam { get; private set; }
        public RosterViewModel BriansTeam { get; private set; }

        public LeagueViewModel()
        {
            JimmysTeam = new RosterViewModel(PopulateJimmysTeam());
            BriansTeam = new RosterViewModel(PopulateBriansTeam());
        }
        
        private Roster PopulateJimmysTeam()
        {
            List<Player> players = new List<Player>()
            {
                new Player("Winston", 42, true),
                new Player("Tracer", 8, true),
                new Player("Genji", 2, true),
                new Player("Mercy", 80, true),
                new Player("Ana", 23, true),
                new Player("Reinhardt", 45, false),
                new Player("Lucio",10,false)
            };
            return new Roster("Overwatch",players);
        }

        private Roster PopulateBriansTeam()
        {
            List<Player> players = new List<Player>()
            {
                new Player("Reaper",66,true),
                new Player("Widowmaker", 13, true),
                new Player("Doomfist", 90, true),
                new Player("Sigma", 0, true),
                new Player("Moira",45,true),
                new Player("Baptiste",35,false),
                new Player("Hanzo", 4, false),
            };
            return new Roster("Talon", players);
        }

        public void Trade(int jimmyIndex, bool jimmyStarter, int brianIndex, bool brianStarter)
        {
            IList<PlayerViewModel> jimmysPool = jimmyStarter ? JimmysTeam.Starters : JimmysTeam.Bench;
            PlayerViewModel jimmysPlayerViewModel = jimmysPool[jimmyIndex]; 
            Player jimmysPlayer = new Player(jimmysPlayerViewModel.Name, jimmysPlayerViewModel.Number, jimmyStarter);

            IList<PlayerViewModel> briansPool = brianStarter ? BriansTeam.Starters : BriansTeam.Bench;
            PlayerViewModel briansPlayerViewModel = briansPool[brianIndex];
            Player briansPlayer = new Player(briansPlayerViewModel.Name, briansPlayerViewModel.Number, brianStarter);
            
            JimmysTeam.TradePlayer(jimmysPlayer,briansPlayer);
            BriansTeam.TradePlayer(briansPlayer,jimmysPlayer);
        }
    }
}