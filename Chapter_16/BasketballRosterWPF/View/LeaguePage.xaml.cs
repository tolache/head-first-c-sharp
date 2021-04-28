using System;
using System.Windows;
using System.Windows.Controls;
using BasketballRosterWPF.ViewModel;

namespace BasketballRosterWPF.View
{
    public partial class LeaguePage : Page
    {
        private LeagueViewModel _leagueViewModel;
        private bool _jimmysStarterIsSelected;
        private int _jimmysSelectedPlayerIndex
        {
            get
            {
                if (JimmysTeamControl.StartersListView.SelectedIndex > -1)
                {
                    _jimmysStarterIsSelected = true;
                    return JimmysTeamControl.StartersListView.SelectedIndex;
                }

                if (JimmysTeamControl.BenchListView.SelectedIndex > -1)
                {
                    _jimmysStarterIsSelected = false;
                    return JimmysTeamControl.BenchListView.SelectedIndex;
                }

                _jimmysStarterIsSelected = false;
                return -1;
            }
        }

        private bool _briansStarterIsSelected;
        private int _briansSelectedPlayerIndex
        {
            get
            {
                if (BriansTeamControl.StartersListView.SelectedIndex > -1)
                {
                    _briansStarterIsSelected = true;
                    return BriansTeamControl.StartersListView.SelectedIndex;
                }

                if (BriansTeamControl.BenchListView.SelectedIndex > -1)
                {
                    _briansStarterIsSelected = false;
                    return BriansTeamControl.BenchListView.SelectedIndex;
                }

                _briansStarterIsSelected = false;
                return -1;
            }
        }
        
        public LeaguePage()
        {
            InitializeComponent();
            _leagueViewModel = FindResource("LeagueViewModel") as LeagueViewModel;
        }

        private void TradeButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (_jimmysSelectedPlayerIndex < 0 || _briansSelectedPlayerIndex < 0)
            {
                MessageBox.Show("Cannot trade. Select a player in each team.", "Error: Cannot trade.");
                return;
            }
            
            _leagueViewModel.Trade(_jimmysSelectedPlayerIndex, _jimmysStarterIsSelected, _briansSelectedPlayerIndex, _briansStarterIsSelected);
        }
    }
}