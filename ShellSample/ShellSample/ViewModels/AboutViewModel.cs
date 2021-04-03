using Sentry;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ShellSample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

            SentrySdk.CaptureMessage("Hello Xamarin Shell");
        }

        public ICommand OpenWebCommand { get; }
    }
}