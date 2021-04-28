using System.Windows;

namespace Chapter_14_Jimmys_Comics
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private async void App_OnExit(object sender, ExitEventArgs e)
        {
            await SessionManager.SaveAsync();
        }

        private async void App_OnStartup(object sender, StartupEventArgs e)
        {
            await SessionManager.LoadAsync();
        }
    }
}
