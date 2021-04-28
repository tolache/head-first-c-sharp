using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BasketballRosterWPF.Model;

namespace BasketballRosterWPF.ViewModel
{
    public class RosterViewModel
    {
        private Roster _roster;

        public string TeamName { get; private set;}
        public ObservableCollection<PlayerViewModel> Starters { get; private set; }
        public ObservableCollection<PlayerViewModel> Bench { get; private set; }

        public RosterViewModel(Roster roster)
        {
            Starters = new ObservableCollection<PlayerViewModel>();
            Bench = new ObservableCollection<PlayerViewModel>();
            
            _roster = roster;
            TeamName = roster.TeamName;
            UpdatePlayers();

            _roster.RosterUpdated += OnRosterUpdated;
        }

        private void UpdatePlayers()
        {
            Starters.Clear();
            var starterPlayers =
                from player in _roster.Players
                where player.Starter
                select player;
            foreach (Player player in starterPlayers)
            {
                Starters.Add(new PlayerViewModel(player.Name, player.Number));
            }
            
            Bench.Clear();
            var benchPlayers =
                from player in _roster.Players
                where player.Starter == false
                select player;
            foreach (Player player in benchPlayers)
            {
                Bench.Add(new PlayerViewModel(player.Name, player.Number));
            }
        }

        public void TradePlayer(Player outgoing, Player incoming)
        {
            _roster.RemovePlayer(outgoing);
            _roster.AddPlayer(incoming);
        }

        private void OnRosterUpdated(object sender, RosterEventArgs args)
        {
            UpdatePlayers();
        }
    }
}