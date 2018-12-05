using System;

using Autofac;

namespace SpeechTalk.IoC
{
    public interface IModule
    {
        #region Methods
        /// <summary>
        /// Register the specified builder.
        /// </summary>
        /// <param name="builder">Builder.</param>
        void Register(ContainerBuilder builder);
        #endregion
    }
}
