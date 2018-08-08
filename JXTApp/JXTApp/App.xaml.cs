using JXTApp.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace JXTApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // The root page of the application
            MainPage = new SplashPage();
        }

        protected override void OnStart()
        {
            // Handle when the app starts
        }

        protected override void OnSleep()
        {
            // Handle when the app sleeps
        }

        protected override void OnResume()
        {
            // Handle when the app resumes
        }
    }
}