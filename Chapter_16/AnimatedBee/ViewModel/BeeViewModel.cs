using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using AnimatedBee.View;

namespace AnimatedBee.ViewModel
{
    public class BeeViewModel
    {
        private readonly ObservableCollection<UIElement> _sprites =
            new ObservableCollection<UIElement>();
        public INotifyCollectionChanged Sprites => _sprites;

        public BeeViewModel()
        {
            AnimatedImage firstBee = BeeHelper.BeeFactory(50, 50, TimeSpan.FromMilliseconds(10));
            AnimatedImage secondBee = BeeHelper.BeeFactory(200, 200, TimeSpan.FromMilliseconds(50));
            AnimatedImage thirdBee = BeeHelper.BeeFactory(300, 125, TimeSpan.FromMilliseconds(100));
            _sprites.Add(firstBee);
            _sprites.Add(secondBee);
            _sprites.Add(thirdBee);
            BeeHelper.MakeBeeMove(firstBee,50,450,40);
            BeeHelper.SetBeeLocation(secondBee,80,260);
            BeeHelper.SetBeeLocation(thirdBee, 230,100);
        }
    }
}