using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Chapter_10_Sloppy_Joe
{
    public class MenuMaker : INotifyPropertyChanged
    {
        Random random = new Random();

        List<string> meats = new List<string> { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };
        List<string> condiments = new List<string> { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        List<string> breads = new List<string> { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

        public MenuMaker()
        {
            
            NumberOfItems = 10;
            Menu = new ObservableCollection<MenuItem> { };
            UpdateMenu();
        }

        public int NumberOfItems { get; set; }
        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; private set; }

        public MenuItem CreateMenuItem()
    	{
            string randomMeat = meats[random.Next(meats.Count)];
            string randomCondiment = condiments[random.Next(condiments.Count)];
            string randomBread = breads[random.Next(breads.Count)];
            return new MenuItem(randomMeat, randomCondiment, randomBread);
        }

        public void UpdateMenu()
        {
            Menu.Clear();
            for (int i = 0; i < NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;
            
            OnPropertyChanged("GeneratedDate");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}