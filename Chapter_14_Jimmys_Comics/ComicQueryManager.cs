using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media.Imaging;

namespace Chapter_14_Jimmys_Comics
{
    public class ComicQueryManager
    {
        private Asset defaultAsset = Asset.Purple;
        
        public ObservableCollection<ComicQuery> AvailableQueries { get; private set; }
        public ObservableCollection<object> CurrentQueryResults { get; private set; }
        public string Title { get; set; }
        public ComicQueryManager() {
            UpdateAvailableQueries();
            CurrentQueryResults = new ObservableCollection<object>();
        }
        private void UpdateAvailableQueries() {
            AvailableQueries = new ObservableCollection<ComicQuery> {
                new ComicQuery("LINQ makes queries easy", "A sample query",
                    "Let's show Jimmy how flexible LINQ is",
                    CreateImageFromAssets(Asset.Purple)),
                
                new ComicQuery("Expensive comics", "Comics over $500", 
                    "Comics whose value is over 500 bucks."
                        + " Jimmy can use this to figure out which comics are most coveted.", 
                    CreateImageFromAssets(Asset.CaptainAmazing)),
                
                new ComicQuery("LINQ is versatile 1", "Modify every item returned from the query",
                    "This code will add a string onto the end of each string in an array.",
                    CreateImageFromAssets(Asset.BlueGray)),
                
                new ComicQuery("LINQ is versatile 2", "Perform calculations on collections",
                    "LINQ provides extension methods for your collections (and anything else"
                    + " that implements IEnumerable<T>).",
                    CreateImageFromAssets(Asset.Purple)),
                
                new ComicQuery("LINQ is versatile 3",
                    "Store all or part of your results in a new sequence",
                    "Sometimes you’ll want to keep your results from a LINQ query around.",
                    CreateImageFromAssets(Asset.BlueGray)),
                
                new ComicQuery("Group comics by price range", "Combine Jimmy's values into groups",
                    "Jimmy buys a lot of cheap comic books, some midrange comic books, and a few expensive ones," +
                    "and he wants to know what his options are before he decides what comics to buy.",
                    CreateImageFromAssets(Asset.CaptainAmazing)),
                
                new ComicQuery("Join purchases with prices", "Let's see if Jimmy drives a hard bargain",
                    "This query creates a list of Purchase classes that contain Jimmy's purchases and compares" +
                    "them with the prices he found on Greg's List.",
                    CreateImageFromAssets(Asset.CaptainAmazing)),
            };
        }
        private static BitmapImage CreateImageFromAssets(Asset asset) {
            Uri uri = new Uri(@"Assets/" + asset.FileName,UriKind.RelativeOrAbsolute);
            return new BitmapImage(uri);
        }
        public void UpdateQueryResults(ComicQuery query) {
            Title = query.Title;
            switch (query.Title) {
                case "LINQ makes queries easy": LinqMakesQueriesEasy(); break;
                case "Expensive comics": ExpensiveComics(); break;
                case "LINQ is versatile 1": LinqIsVersatile1(); break;
                case "LINQ is versatile 2": LinqIsVersatile2(); break;
                case "LINQ is versatile 3": LinqIsVersatile3(); break;
                case "Group comics by price range": GroupComicsByPriceRange(); break;
                case "Join purchases with prices": JoinPurchasesWithPrices(); break;
            }
        }

        public static IEnumerable<Comic> BuildCatalog() {
            return new List<Comic> {
                new Comic { Name = "Johnny America vs. the Pinko", Issue = 6 },
                new Comic { Name = "Rock and Roll (limited edition)", Issue = 19 },
                new Comic { Name = "Woman’s Work", Issue = 36 },
                new Comic { Name = "Hippie Madness (misprinted)", Issue = 57 },
                new Comic { Name = "Revenge of the New Wave Freak (damaged)", Issue = 68 },
                new Comic { Name = "Black Monday", Issue = 74 },
                new Comic { Name = "Tribal Tattoo Madness", Issue = 83 },
                new Comic { Name = "The Death of an Object", Issue = 97 },
            };
        }

        private static Dictionary<int, decimal> GetPrices() {
            return new Dictionary<int, decimal> {
                { 6, 3600M }, { 19, 500M }, { 36, 650M }, { 57, 13525M },
                { 68, 250M }, { 74, 75M }, { 83, 25.75M }, { 97, 35.25M },
            };
        }

        private void LinqMakesQueriesEasy() {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var result = from v in values
                where v < 37
                orderby v
                select v;
            CurrentQueryResults.Clear();
            foreach (int i in result)
                CurrentQueryResults.Add(CreateAnonymousListViewItem(i.ToString(),Asset.Purple));
        }

        private void ExpensiveComics() {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();
            var mostExpensive = from comic in comics
                where values[comic.Issue] > 500
                orderby values[comic.Issue] descending
                select comic;
            CurrentQueryResults.Clear();
            foreach (Comic comic in mostExpensive)
                CurrentQueryResults.Add(CreateAnonymousListViewItem($"{comic.Name} is worth {values[comic.Issue]:c}",
                    Asset.CaptainAmazing));
        }

        private void LinqIsVersatile1()
        {
            string[] sandwiches = {"ham and cheese", "salami with mayo", "turkey and swiss", "chicken cutlet"};
            
            var sandwichesOnRye =
                from sandwich in sandwiches
                select sandwich + " on rye";
            
            CurrentQueryResults.Clear();
            foreach (var sandwich in sandwichesOnRye)
            {
                CurrentQueryResults.Add(CreateAnonymousListViewItem(sandwich, Asset.BlueGray));
            }
        }

        private void LinqIsVersatile2()
        {
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
            {
                listOfNumbers.Add(random.Next(100));
            }
            
            CurrentQueryResults.Clear();
            CurrentQueryResults.Add(CreateAnonymousListViewItem($"There are {listOfNumbers.Count} numbers"));
            CurrentQueryResults.Add(CreateAnonymousListViewItem($"The smallest is {listOfNumbers.Min()}"));
            CurrentQueryResults.Add(CreateAnonymousListViewItem($"The biggest is {listOfNumbers.Max()}"));
            CurrentQueryResults.Add(CreateAnonymousListViewItem($"The sum is {listOfNumbers.Sum()}"));
            CurrentQueryResults.Add(CreateAnonymousListViewItem($"The average is {listOfNumbers.Average()}"));
        }

        private void LinqIsVersatile3()
        {
            List<int> listOfNumbers = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                listOfNumbers.Add(i);
            }

            var under50sorted =
                from number in listOfNumbers
                where number < 50
                orderby number descending
                select number;

            var firstFive = under50sorted.Take(6);

            List<int> shortList = firstFive.ToList();
            foreach (int n in shortList)
            {
                CurrentQueryResults.Add(CreateAnonymousListViewItem(n.ToString(), Asset.Purple));
            }
        }

        private void GroupComicsByPriceRange()
        {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();
            
            var comicGroups =
                from pair in values
                group pair.Key by Purchase.EvaluatePrice(pair.Value)
                into comicGroup
                orderby comicGroup.Key
                select comicGroup;

            CurrentQueryResults.Clear();

            foreach (var comicGroup in comicGroups)
            {
                CurrentQueryResults.Add(CreateAnonymousListViewItem($"{comicGroup.Count()} {comicGroup.Key} comics:",
                    Asset.Purple));
                
                var orderedComicGroup = from issue in comicGroup
                    orderby values[issue] ascending 
                    select issue;
                
                foreach (var issue in orderedComicGroup)
                {
                    string comicName = GetComicByIssue(comics, issue).Name;
                    CurrentQueryResults.Add(CreateAnonymousListViewItem($"Issue #{issue} ({comicName}) is worth {values[issue]:C}",
                        Asset.CaptainAmazing));
                }
            }
        }

        private void JoinPurchasesWithPrices()
        {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();
            IEnumerable<Purchase> purchases = Purchase.FindPurchases();

            var results =
                from comic in comics
                join purchase in purchases 
                    on comic.Issue equals purchase.Issue
                orderby comic.Issue ascending
                select new {comic.Name, comic.Issue, purchase.Price};
            decimal gregsListValue = 0;
            decimal totalSpent = 0;
            
            CurrentQueryResults.Clear();
            
            foreach (var result in results)
            {
                gregsListValue += values[result.Issue];
                totalSpent += result.Price;
                CurrentQueryResults.Add(CreateAnonymousListViewItem(
                    $"Issue #{result.Issue} ({result.Name}) bought for {result.Price:C}.",
                    Asset.CaptainAmazing));
            }

            CurrentQueryResults.Add(CreateAnonymousListViewItem(
                $"I spent {totalSpent:C} on comics worth {gregsListValue:C}"));
        }

        private static Comic GetComicByIssue(IEnumerable<Comic> comics, int issue)
        {
            var comicIssue =
                from comic in comics
                where comic.Issue == issue
                select comic;

            return comicIssue.First();
        }

        private object CreateAnonymousListViewItem(string title, Asset asset = null)
        {
            asset ??= Asset.Purple;
            return new
            {
                Title = title,
                Image = CreateImageFromAssets(asset),
            };
        }
    }
}