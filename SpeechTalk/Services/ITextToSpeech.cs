using System;
namespace SpeechTalk.Services
{
    /// <summary>
    /// Text to speech.
    /// </summary>
    public interface ITextToSpeech
    {
        #region Methods

        /// <summary>
        /// Speak the specified msg.
        /// </summary>
        /// <param name="msg">Message.</param>
        void Speak(string msg);

        #endregion
    }
}
