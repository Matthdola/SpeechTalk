using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using SpeechTalk.Droid.Modules;
using SpeechTalk.IoC;
using SpeechTalk.Modules;
using SpeechTalk;

namespace SpeechTalk.Droid
{
    [Activity(Label = "SpeechTalk", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            InitIoC();

            LoadApplication(new App());
        }

        private void InitIoC()
        {
            IoC.IoC.CreateContainer();
            IoC.IoC.RegisterModule(new DroidModule());
            IoC.IoC.RegisterModule(new PCLModule());
            IoC.IoC.StartContainer();
        }
    }
}