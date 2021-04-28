using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Chapter_11_Excuse_Manager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(600, 480);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        private void NewExcuseButton_OnClick(object sender, RoutedEventArgs e)
        {
            excuseManager.NewExcuseAsync();
        }

        private async void FolderButton_OnClick(object sender, RoutedEventArgs e)
        {
            bool folderChosen = await excuseManager.ChooseNewFolderAsync();
            if (folderChosen)
            {
                saveButton.IsEnabled = true;
                randomButton.IsEnabled = true;
            }
        }

        private void RandomExcuseButton_OnClick(object sender, RoutedEventArgs e)
        {
            excuseManager.OpenRandomExcuseAsync();
        }

        private void OpenButton_OnClick(object sender, RoutedEventArgs e)
        {
            excuseManager.OpenExcuseAsync();
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            excuseManager.SaveCurrentExcuseAsync();
        }

        private void SaveAsButton_OnClick(object sender, RoutedEventArgs e)
        {
            excuseManager.SaveCurrentExcuseAsAsync();
        }

        private void SetToCurrentTime_OnClick(object sender, RoutedEventArgs e)
        {
            excuseManager.SetToCurrentTime();
        }
    }
}