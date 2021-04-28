using System.Windows.Controls;

namespace BasketballRosterWPF.View
{
    public partial class RosterControl : UserControl
    {
        public RosterControl()
        {
            InitializeComponent();
        }

        private void StartersListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0 || BenchListView.SelectedItem == null)
                return; 
            BenchListView.UnselectAll();
        }

        private void BenchListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0 || StartersListView.SelectedItem == null)
                return;
            StartersListView.UnselectAll();
        }
    }
}