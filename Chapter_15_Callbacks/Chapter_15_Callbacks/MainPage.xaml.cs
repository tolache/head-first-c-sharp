using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Chapter_15_Callbacks
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        async void ShowDialogWithCallback()
        {
            MessageDialog dialog = new MessageDialog("Here's a dialog.");
            dialog.Commands.Add(new UICommand("Show message box 1", MyUiCommandCallback1, "My identifier"));
            dialog.Commands.Add(new UICommand("Show message box 2", MyUiCommandCallback2, "My identifier"));
            await dialog.ShowAsync();
        }

        private async void MyUiCommandCallback1(IUICommand command)
        {
            MessageDialog dialog = new MessageDialog("Message box 1 callback");
            await dialog.ShowAsync();
        }

        private async void MyUiCommandCallback2(IUICommand command)
        {
            MessageDialog dialog = new MessageDialog("Message box 2 callback");
            await dialog.ShowAsync();
        }

        private void Rectangle_ContextRequested(UIElement sender, ContextRequestedEventArgs args)
        {
            ShowDialogWithCallback();
        }
    }
}
