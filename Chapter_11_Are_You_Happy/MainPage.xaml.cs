using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Chapter_11_Are_You_Happy
{
    /// <summary>
    //Button_OnClicke that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            timer.Tick += timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Start();
            CheckHappiness();
        }
        
        int i = 0;
        void timer_Tick(object sender, object e) {
            ticker.Text = "Tick #" + i++;
        }
        
        private async void CheckHappiness() {
            MessageDialog dialog = new MessageDialog("Are you happy?");
            dialog.Commands.Add(new UICommand("Happy as a clam!"));
            dialog.Commands.Add(new UICommand("Sad as a donkey."));
            dialog.DefaultCommandIndex = 1;
            UICommand result = await dialog.ShowAsync() as UICommand;
            if (result != null && result.Label == "Happy as a clam!")
                response.Text = "The user is happy";
            else
                response.Text = "The user is sad";
            timer.Stop();
        }
    }
}