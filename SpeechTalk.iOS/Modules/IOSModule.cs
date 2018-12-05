using System;

using Autofac;

using SpeechTalk.IoC;
using SpeechTalk.Services;
using SpeechTalk.iOS.Services;

namespace SpeechTalk.iOS.Modules
{
    /// <summary>
    /// IOSM odule.
    /// </summary>
    public class IOSModule : IModule
    {
        #region Public Methods

        /// <summary>
        /// Register the specified builder.
        /// </summary>
        /// <param name="builder">Builder.</param>
        public void Register(ContainerBuilder builder)
        {
            builder.RegisterType<TextToSpeech>().As<ITextToSpeech>().SingleInstance();
        }

        #endregion
    }
}
