using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace StarryNight.Model
{
    public sealed class BeeStarModel
    {
        private static readonly Size StarSize = new Size(150, 100);
        
        private readonly Dictionary<Bee, Point> _bees = new Dictionary<Bee, Point>();
        private readonly Dictionary<Star, Point> _stars = new Dictionary<Star, Point>();
        private readonly Random _random = new Random();

        public BeeStarModel()
        {
            _playAreaSize = Size.Empty;
        }

        public void Update()
        {
            MoveOneBee();
            AddOrRemoveAStar();
        }

        private static bool RectanglesOverlap(Rectangle r1, Rectangle r2)
        {
            r1.Intersect(r2);
            return r1.Width > 0 || r1.Height > 0;
        }

        private Size _playAreaSize;

        public Size PlayAreaSize
        {
            get => _playAreaSize;
            set
            {
                _playAreaSize = value;
                CreateBees();
                CreateStars();
            }
        }

        private void CreateBees()
        {
            if (PlayAreaSize.IsEmpty)
                return;
            if (_bees.Count > 0)
            {
                foreach (Bee bee in _bees.Keys)
                {
                    MoveOneBee(bee);
                }
            }
            else
            {
                int maxBees = _random.Next(5, 10);
                for (int i = 0; i < maxBees; i++)
                {
                    int beeSide = _random.Next(50, 101);
                    Size beeSize = new Size(beeSide, beeSide);
                    Point beeLocation = FindNonOverlappingPoint(beeSize);
                    Bee newBee = new Bee(beeLocation, beeSize);
                    _bees.Add(newBee, beeLocation);
                    OnBeeMoved(newBee, beeLocation.X, beeLocation.Y);
                }   
            }
        }

        private void MoveOneBee(Bee bee = null)
        {
            if (_bees.Keys.Count == 0) 
                return;
            if (bee == null)
            {
                int randomBeeIndex = _random.Next(0, _bees.Count);
                bee = _bees.ElementAt(randomBeeIndex).Key;
            }

            bee.Location = FindNonOverlappingPoint(bee.Size);
            _bees[bee] = bee.Location;
            OnBeeMoved(bee, bee.Location.X, bee.Location.Y);
        }

        public event EventHandler<BeeMovedEventArgs> BeeMoved;

        private void OnBeeMoved(Bee beeThatMoved, double x, double y)
        {
            BeeMoved?.Invoke(this, new BeeMovedEventArgs(beeThatMoved, x, y));
        }

        private void CreateStars()
        {
            if (PlayAreaSize.IsEmpty)
                return;
            if (_stars.Count > 0)
            {
                foreach (Star star in _stars.Keys)
                {
                    star.Location = FindNonOverlappingPoint(StarSize);
                    OnStarChanged(star, false);
                }
            }
            else
            {
                int maxStars = _random.Next(5,11);
                for (int i = 0; i < maxStars; i++)
                {
                    CreateAStar();
                }   
            }
        }

        private void CreateAStar()
        {
            Point starLocation = FindNonOverlappingPoint(StarSize);
            Star star = new Star(starLocation);
            _stars.Add(star, star.Location);
            OnStarChanged(star, false);
        }

        public event EventHandler<StarChangedEventArgs> StarChanged;

        private void OnStarChanged(Star star, bool removed)
        {
            StarChanged?.Invoke(this, new StarChangedEventArgs(star, removed));
        }

        private Point FindNonOverlappingPoint(Size size)
        {
            Point newPoint;
            int tries = 0;
            bool noOverlap = false;
            do
            {
                newPoint = new Point(_random.Next(0, _playAreaSize.Width - size.Width),
                    _random.Next(0, _playAreaSize.Height - size.Height));
                Rectangle newRectangle = new Rectangle(newPoint, size);

                var overlappingStars = from star in _stars.Keys
                    where RectanglesOverlap(newRectangle, new Rectangle(star.Location, StarSize))
                    select star;

                var overlappingBees = from bee in _bees.Keys
                    where RectanglesOverlap(newRectangle, bee.Position)
                    select bee;

                if (!overlappingStars.Any() && !overlappingBees.Any() || tries++ >= 1000)
                    noOverlap = true;
            } while (!noOverlap);

            return newPoint;
        }

        private void AddOrRemoveAStar()
        {
            if (5 < _stars.Count && _stars.Count < 20 && _random.Next(2) == 0 || _stars.Count <= 5)  
            {
                CreateAStar();
            }
            else
            {
                Star randomStar = _stars.Keys.ToList()[_random.Next(_stars.Count)];
                _stars.Remove(randomStar);
                OnStarChanged(randomStar, true);
            }
        }
    }
}