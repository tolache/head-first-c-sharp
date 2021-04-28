using BasketballRoster.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace BasketballRoster.ViewModel
{
    class RosterViewModel : INotifyPropertyChanged
    {
        private Roster _roster;
        
        private string _teamName;
        public string TeamName
        {
            get { return _teamName; }
            set
            {
                _teamName = value;
                OnPropertyChanged("TeamName");
            }
        }

        public RosterViewModel(Roster roster)
        {
            _roster = roster;
            
            Starters = new ObservableCollection<PlayerViewModel>();
            Bench = new ObservableCollection<PlayerViewModel>();

            TeamName = _roster.TeamName;
            
            UpdateRoster();
        }

        public ObservableCollection<PlayerViewModel> Starters { get; private set; }
        public ObservableCollection<PlayerViewModel> Bench { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void UpdateRoster()
        {
            var starterPlayerss = 
                from player in _roster.Players
                where player.Starter == true
                select player;
            Starters.Clear();
            foreach (Player player in starterPlayerss)
            {
                Starters.Add(new PlayerViewModel(player.Name, player.Number));
            }

            var benchPlayers =
                from player in _roster.Players
                where player.Starter == false
                select player;
            Bench.Clear();
            foreach (Player player in benchPlayers)
            {
                Bench.Add(new PlayerViewModel(player.Name, player.Number));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            propertyChangedEvent?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
