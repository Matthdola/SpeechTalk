using System;

using UIKit;
using Foundation;
using AVFoundation;

using SpeechTalk.Services;

namespace SpeechTalk.iOS.Services
{
    public class TextToSpeech : ITextToSpeech
    {
        #region

        /// <summary>
        /// Speak the specified msg.
        /// </summary>
        /// <param name="msg">Message.</param>
        public void Speak(string msg)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(msg)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("fr-FR"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }

        #endregion
    }
}
