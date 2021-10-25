using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS3D3KSanchez
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Navegación entre ventanas
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
