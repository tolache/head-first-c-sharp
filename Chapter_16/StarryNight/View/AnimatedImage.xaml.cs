using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace StarryNight.View
{
    public partial class AnimatedImage : UserControl
    {
        public AnimatedImage()
        {
            InitializeComponent();
        }

        public AnimatedImage(IEnumerable<string> imageNames, TimeSpan interval) : this()
        {
            StartAnimation(imageNames, interval);
        }

        private void StartAnimation(IEnumerable<string> imageNames, TimeSpan interval)
        {
            Storyboard storyboard = new Storyboard();
            ObjectAnimationUsingKeyFrames animation = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, image);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Image.SourceProperty));

            TimeSpan currentInterval = TimeSpan.Zero;
            foreach (string imageName in imageNames)
            {
                ObjectKeyFrame keyFrame = new DiscreteObjectKeyFrame();
                keyFrame.Value = CreateImageFromAssets(imageName);
                keyFrame.KeyTime = currentInterval;
                animation.KeyFrames.Add(keyFrame);
                currentInterval += interval;
            }

            storyboard.AutoReverse = true;
            storyboard.RepeatBehavior = RepeatBehavior.Forever;
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }

        private BitmapImage CreateImageFromAssets(string imageName)
        {
            Uri uri = new Uri("pack://application:,,,/Assets/" + imageName, UriKind.Absolute);
            return new BitmapImage(uri);
        }
    }
}