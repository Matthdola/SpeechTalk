using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SpeechTalk.Pages;
using SpeechTalk.IoC;
using SpeechTalk.Modules;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SpeechTalk
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainPage = IoC.IoC.Resolve<MainPage>();

            MainPage = new NavigationPage(mainPage);
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
