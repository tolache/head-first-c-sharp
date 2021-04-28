using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Chapter_14_Jimmys_Comics
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            availableQueries.UnselectAll();
            if (String.IsNullOrEmpty(SessionManager.CurrentQuery)) return;
            var currentQuerySequence =
                from availableQuery in new ComicQueryManager().AvailableQueries
                where availableQuery.Title == SessionManager.CurrentQuery
                select availableQuery;

            if (currentQuerySequence.Count() != 1) return;
            ComicQuery query = currentQuerySequence.First();
            if (query == null) return;
            if (query.Title == "All comics in the collection")
            {
                throw new NotImplementedException();
                // NavigationService.Navigate(new QueryDetailZoom(query));
            }
            else
            {
                NavigationService.Navigate(new QueryDetail(query));
            }
        }

        private void availableQueries_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (availableQueries.SelectedItems.Count == 0)
                return;
            ComicQuery query = e.AddedItems[0] as ComicQuery;
            if (query != null)
            {
                SessionManager.CurrentQuery = query.Title;
                NavigationService.Navigate(new QueryDetail(query));
            }
        }
    }
}