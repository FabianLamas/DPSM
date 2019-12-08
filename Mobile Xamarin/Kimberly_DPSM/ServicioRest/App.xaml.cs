using System;
using System.IO;
using Kimberly_DPSM.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Kimberly_DPSM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShellPage();
            ServicioLocal.Infraestructura infraestructura = new ServicioLocal.Infraestructura();

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
