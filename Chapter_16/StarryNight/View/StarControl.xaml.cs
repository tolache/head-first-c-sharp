using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace StarryNight.View
{
    public partial class StarControl : UserControl
    {
        private Storyboard fadeInStoryboard;
        private Storyboard fadeOutStoryboard;
        public StarControl()
        {
            InitializeComponent();
            fadeInStoryboard = FindResource(nameof(fadeInStoryboard)) as Storyboard;
            fadeOutStoryboard = FindResource(nameof(fadeOutStoryboard)) as Storyboard;
        }

        public void FadeIn()
        {
            fadeInStoryboard.Begin();
        }
        
        public void FadeOut()
        {
            fadeOutStoryboard.Begin();
        }
    }
}