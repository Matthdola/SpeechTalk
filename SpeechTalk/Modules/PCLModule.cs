using System;

using Autofac;

using SpeechTalk.IoC;
using SpeechTalk.ViewModules;
using SpeechTalk.Pages;

namespace SpeechTalk.Modules
{
    /// <summary>
    /// PCLM odule.
    /// </summary>
    public class PCLModule : IModule
    {
        #region Public Methods

        /// <summary>
        /// Register the specified builder.
        /// </summary>
        /// <param name="builder">Builder.</param>
        public void Register(ContainerBuilder builder)
        {
            builder.RegisterType<MainPageViewModel> ().SingleInstance();
            builder.RegisterType<MainPage>().SingleInstance();
        }
        #endregion
    }
}
