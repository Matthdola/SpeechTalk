using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using SpeechTalk.ViewModules;

namespace SpeechTalk.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(MainPageViewModel model)
        {
            BindingContext = model;
            InitializeComponent();
        }
    }
}
