using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace AnimatedBee.View
{
    public static class BeeHelper
    {
        public static AnimatedImage BeeFactory(double width, double height, TimeSpan flapInterval)
        {
            List<string> imageNames = new List<string>()
            {
                "Bee animation 1.png",
                "Bee animation 2.png",
                "Bee animation 3.png",
                "Bee animation 4.png",
            };
            AnimatedImage bee = new AnimatedImage(imageNames,flapInterval);
            bee.Width = width;
            bee.Height = height;
            return bee;
        }

        public static void SetBeeLocation(AnimatedImage bee, double x, double y)
        {
            Canvas.SetLeft(bee, x);
            Canvas.SetTop(bee, y);
        }

        public static void MakeBeeMove(AnimatedImage bee, double fromX, double toX, double y)
        {
            Canvas.SetTop(bee, y);
            Storyboard storyboard = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation();
            Storyboard.SetTarget(animation, bee);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Canvas.LeftProperty));
            animation.From = fromX;
            animation.To = toX;
            animation.Duration = TimeSpan.FromSeconds(3);
            animation.AutoReverse = true;
            animation.RepeatBehavior = RepeatBehavior.Forever;
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }
    }
}