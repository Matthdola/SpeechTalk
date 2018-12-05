using System;

using Autofac;


using SpeechTalk.Droid.Services;
using SpeechTalk.Modules;
using SpeechTalk.Services;
using SpeechTalk.IoC;

namespace SpeechTalk.Droid.Modules
{
    public class DroidModule : IModule
    {
       public void Register(ContainerBuilder builder)
        {
            builder.RegisterType<TextToSpeechDroid>().As<ITextToSpeech>().SingleInstance();
        }
    }
}
