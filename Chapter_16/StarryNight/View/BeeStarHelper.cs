using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace StarryNight.View
{
    public static class BeeStarHelper
    {
        private static Random _random = new Random();
        public static AnimatedImage BeeFactory(double width, double height, TimeSpan flapInterval)
        {
            List<string> imageNames = new List<string>()
            {
                "Bee animation 1.png",
                "Bee animation 2.png",
                "Bee animation 3.png",
                "Bee animation 4.png",
            };
            
            AnimatedImage bee = new AnimatedImage(imageNames, flapInterval)
            {
                Width = width,
                Height = height,
            };
            return bee;
        }

        public static void SetCanvasLocation(UIElement control, double x, double y)
        {
            Canvas.SetLeft(control, x);
            Canvas.SetTop(control, y);
        }

        public static void MoveElementOnCanvas(UIElement uiElement, double toX, double toY)
        {
            double fromX = Canvas.GetLeft(uiElement);
            double fromY = Canvas.GetTop(uiElement);

            Storyboard storyboard = new Storyboard();
            DoubleAnimation animationX = CreateDoubleAnimation(uiElement, fromX, toX, Canvas.LeftProperty);
            DoubleAnimation animationY = CreateDoubleAnimation(uiElement, fromY, toY, Canvas.TopProperty);
            storyboard.Children.Add(animationX);
            storyboard.Children.Add(animationY);
            storyboard.Begin();
        }

        public static void SendToBack(StarControl newStar)
        {
            Panel.SetZIndex(newStar, -1000);
        }

        private static DoubleAnimation CreateDoubleAnimation(UIElement uiElement, double from, double to, DependencyProperty propertyToAnimate)
        {
            DoubleAnimation animation = new DoubleAnimation();
            Storyboard.SetTarget(animation, uiElement);
            Storyboard.SetTargetProperty(animation, new PropertyPath(propertyToAnimate));
            animation.From = from;
            animation.To = to;
            animation.Duration = TimeSpan.FromMilliseconds(_random.Next(2000, 3500));
            return animation;
        }
    }
}