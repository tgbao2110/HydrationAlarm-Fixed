using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NotificationSample
{
    public partial class App : Application
    {
        public App(bool shallNavigate)
        {
            InitializeComponent();
            {
                MainPage = new NavigationPage(new HydrationAlarm());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
