using System;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SpeechTalk.ViewModules
{
    /// <summary>
    /// View model base.
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Public Events

        /// <summary>
        /// Occurs when property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
