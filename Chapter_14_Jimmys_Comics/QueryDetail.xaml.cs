using System.Windows;
using System.Windows.Controls;

namespace Chapter_14_Jimmys_Comics
{
    public partial class QueryDetail : Page
    {
        private ComicQuery comicQuery;
        private ComicQueryManager comicQueryManager;
        
        public QueryDetail(object query)
        {
            InitializeComponent();
            comicQuery = query as ComicQuery;
            comicQueryManager = Resources["comicQueryManager"] as ComicQueryManager;
        }

        private void QueryDetail_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (comicQuery != null)
            {
                comicQueryManager.UpdateQueryResults(comicQuery);
                resultsHeader.Text += ": " + comicQuery.Title;
            }
        }

        private void QueryDetail_OnUnloaded(object sender, RoutedEventArgs e)
        {
            SessionManager.CurrentQuery = null;
        }
    }
}