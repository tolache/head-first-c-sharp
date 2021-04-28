using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using StarryNight.Model;
using StarryNight.View;
using UIElement = System.Windows.UIElement;
using DispatcherTimer = System.Windows.Threading.DispatcherTimer;

namespace StarryNight.ViewModel
{
    public class BeeStarViewModel
    {
        private readonly Dictionary<Bee, AnimatedImage> _bees = new Dictionary<Bee, AnimatedImage>();
        private readonly Dictionary<Star, StarControl> _stars = new Dictionary<Star, StarControl>();
        private readonly List<StarControl> _fadedStars = new List<StarControl>();
        private BeeStarModel _model = new BeeStarModel();
        private DispatcherTimer _timer = new DispatcherTimer();
        
        private readonly ObservableCollection<UIElement> _sprites = new ObservableCollection<UIElement>();
        public INotifyCollectionChanged Sprites => _sprites;


        public Size PlayAreaSize
        {
            get => _model.PlayAreaSize;
            set => _model.PlayAreaSize = value;
        }

        public BeeStarViewModel()
        {
            _model.BeeMoved += BeeMovedEventHandler;
            _model.StarChanged += StarChangedEventHandler;
            
            _timer.Interval = TimeSpan.FromSeconds(2);
            _timer.Tick += timer_Tick;
            _timer.Start();
        }

        private void BeeMovedEventHandler(object sender, BeeMovedEventArgs args)
        {
            Bee bee = args.BeeThatMoved;
            if (!_bees.ContainsKey(bee))
            {
                TimeSpan flapInterval = TimeSpan.FromMilliseconds((int) bee.Width / 2);
                AnimatedImage beeControl = BeeStarHelper.BeeFactory(bee.Width, bee.Height, flapInterval);
                _bees[bee] = beeControl;
                _sprites.Add(beeControl);
            }
            BeeStarHelper.SetCanvasLocation(_bees[bee], bee.Location.X, bee.Location.Y);
            BeeStarHelper.MoveElementOnCanvas(_bees[bee],args.X, args.Y);
        }

        private void StarChangedEventHandler(object sender, StarChangedEventArgs args)
        {
            StarControl starControl;
            if (args.Removed)
            {
                starControl = _stars[args.StarThatChanged];
                _stars.Remove(args.StarThatChanged);
                _fadedStars.Add(starControl);
                starControl.FadeOut();
                return;
            }

            if (_stars.ContainsKey(args.StarThatChanged))
            {
                starControl = _stars[args.StarThatChanged];
            }
            else
            {
                starControl = new StarControl();
                _stars.Add(args.StarThatChanged, starControl);
                _sprites.Add(starControl);
                starControl.FadeIn();
                BeeStarHelper.SendToBack(starControl);
            }

            int x = args.StarThatChanged.Location.X;
            int y = args.StarThatChanged.Location.Y;
            BeeStarHelper.SetCanvasLocation(starControl,x,y);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (StarControl starControl in _fadedStars)
            {
                _sprites.Remove(starControl);
            }
            _model.Update();
        }
    }
}