using System;

using System.Windows.Input;
using Xamarin.Forms;

using SpeechTalk.Services;

namespace SpeechTalk.ViewModules
{
    public class MainPageViewModel : ViewModelBase
    {
        #region Private Properties
        /// <summary>
        /// The text to speech.
        /// </summary>
        private readonly ITextToSpeech _textToSpeech;

        /// <summary>
        /// The description message.
        /// </summary>
        private string _descriptionMessage = "Enter text and press the 'speak' button to start speeaking";

        /// <summary>
        /// The speak entry place holder.
        /// </summary>
        private string _speakEntryPlaceHolder = "Text to speach";

        /// <summary>
        /// The speack text.
        /// </summary>
        private string _speackText = String.Empty;

        /// <summary>
        /// The speak title.
        /// </summary>
        private string _speakTitle = "Speak";

        /// <summary>
        /// The speak command.
        /// </summary>
        private ICommand _speakCommand;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the description message.
        /// </summary>
        /// <value>The description message.</value>
        public string DescriptionMessage
        {
            get
            {
                return _descriptionMessage;
            }
            set
            {
                if(value.Equals(_descriptionMessage))
                {
                    return;
                }
                _descriptionMessage = value;
                OnPropertyChanged("DescriptionMessage");
            }
        }

        /// <summary>
        /// Gets or sets the speak entry place hoder.
        /// </summary>
        /// <value>The speak entry place hoder.</value>
        public string SpeakEntryPlaceHoder
        {
            get
            {
                return _speakEntryPlaceHolder;
            }

            set
            {
                if(value.Equals(_speakEntryPlaceHolder))
                {
                    return;
                }
                _speakEntryPlaceHolder = value;
                OnPropertyChanged("SpeakEntryPlaceHolder");
            }
        }

        /// <summary>
        /// Gets or sets the speak text.
        /// </summary>
        /// <value>The speak text.</value>
        public string SpeakText
        {
            get
            {
                return _speackText;
            }

            set
            {
                if(value.Equals(_speackText))
                {
                    return;
                }
                _speackText = value;
                OnPropertyChanged("SpeakText");
            }
        }

        /// <summary>
        /// Gets or sets the speak title.
        /// </summary>
        /// <value>The speak title.</value>
        public string SpeakTitle
        {
            get
            {
                return _speakTitle;
            }
            set
            {
                if (value.Equals(_speakTitle))
                {
                    return;
                }
                _speakTitle = value;
                OnPropertyChanged("SpeakTitle");
            }
        }

        /// <summary>
        /// Gets or sets the speak command.
        /// </summary>
        /// <value>The speak command.</value>
        public ICommand SpeakCommand
        {
            get
            {
                return _speakCommand;
            }
            set
            {
                if(value.Equals(_speakCommand))
                {
                    return;
                }
                _speakCommand = value;
                OnPropertyChanged("SpeakCommand");
            }
        }
        #endregion

        #region Constructors
        public MainPageViewModel(ITextToSpeech textToSpeech)
        {
            _textToSpeech = textToSpeech;
            _speakCommand = new Command((c) => textToSpeech.Speak(this.SpeakText));
        }

        #endregion
    }
}
