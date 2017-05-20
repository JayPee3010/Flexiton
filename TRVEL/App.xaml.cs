using Xamarin.Forms;

namespace TRVEL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TRVELPage();
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
