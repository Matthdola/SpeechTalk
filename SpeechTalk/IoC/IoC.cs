using System;

using System.Collections.Generic;

using Autofac;

namespace SpeechTalk.IoC
{
    public static class IoC
    {
        #region Public Static Properties

        /// <summary>
        /// Gets the container.
        /// </summary>
        /// <value>The container.</value>
        public static IContainer Container { get; private set; }

        #endregion

        #region Private Static Properties

        /// <summary>
        /// The builder.
        /// </summary>
        public static ContainerBuilder Builder;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates the container.
        /// </summary>
        public static void CreateContainer()
        {
            Builder = new ContainerBuilder();
        }

        #endregion

        #region Public Static Methods

        /// <summary>
        /// Starts the container.
        /// </summary>
        public static void StartContainer()
        {
            Container = Builder.Build();
        }

        /// <summary>
        /// Registers the module.
        /// </summary>
        /// <param name="module">Module.</param>
        public static void RegisterModule(IModule module)
        {
            module.Register(Builder);
        }

        /// <summary>
        /// Registers the modules.
        /// </summary>
        /// <param name="modules">Modules.</param>
        public static void RegisterModules(IEnumerable<IModule> modules)
        {
            foreach(var module in modules)
            {
                module.Register(Builder);
            }
        }

        /// <summary>
        /// Resorlve this instance.
        /// </summary>
        /// <returns>The resorlve.</returns>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        #endregion
    }
}
