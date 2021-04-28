using System.Drawing;
using System.Windows.Controls;
using StarryNight.ViewModel;
using SizeChangedEventArgs = System.Windows.SizeChangedEventArgs;

namespace StarryNight.View
{
    public partial class BeesOnAStarryNight : Page
    {
        private BeeStarViewModel beeStarViewModel;
        
        public BeesOnAStarryNight()
        {
            InitializeComponent();
            beeStarViewModel = FindResource(nameof(beeStarViewModel)) as BeeStarViewModel;
        }

        private void Canvas_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            beeStarViewModel.PlayAreaSize = new Size((int)e.NewSize.Width, (int)e.NewSize.Height);
        }
    }
}