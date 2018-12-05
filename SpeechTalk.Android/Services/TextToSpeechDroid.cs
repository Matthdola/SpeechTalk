using System;
using System.Collections.Generic;

using Android.Runtime;
using Android.Speech.Tts;
using SpeechTalk.Services;

using Xamarin.Forms;
using Java.Lang;

namespace SpeechTalk.Droid.Services
{
    /// <summary>
    /// Text to speech droid.
    /// </summary>
    public class TextToSpeechDroid : Java.Lang.Object, ITextToSpeech,
        Android.Speech.Tts.TextToSpeech.IOnInitListener
    {
        #region Private Properties
        /// <summary>
        /// The speaker.
        /// </summary>
        private TextToSpeech _speaker;

        /// <summary>
        /// To speak.
        /// </summary>
        private string _toSpeak;

        #endregion

        /// <summary>
        /// Speak the specified msg.
        /// </summary>
        /// <param name="msg">Message.</param>
        public void Speak(string msg)
        {
            var ctx = Forms.Context;
            _toSpeak = msg;

            if(_speaker == null)
            {
                _speaker = new Android.Speech.Tts.TextToSpeech(ctx, this);
            } else
            {
                var p = new Dictionary<string, string>();
                _speaker.Speak(_toSpeak, QueueMode.Flush, p);
            }
        }

        #region TextToSpeech.IOnInitializer implementation

        /// <summary>
        /// Ons the init.
        /// </summary>
        /// <param name="status">Status.</param>
        public void OnInit([GeneratedEnum] OperationResult status)
        {
            if(status.Equals(OperationResult.Success))
            {
                var p = new Dictionary<string, string>();
                _speaker.Speak(_toSpeak, QueueMode.Flush,p);
            }
        }
        #endregion

    }
}
