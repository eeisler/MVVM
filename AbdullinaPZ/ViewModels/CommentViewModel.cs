using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AbdullinaPZ.Helpers;

namespace AbdullinaPZ.ViewModels
{
    public class CommentViewModel : INotifyPropertyChanged
    {
        private int _commentId;
        private string _message;
        private int _masterId;
        private int _requestId;
        private bool _isMessageValid;

        public CommentViewModel()
        {
            SaveCommand = new RelayCommand(Save, CanSave);
        }

        public int CommentId
        {
            get => _commentId;
            set
            {
                _commentId = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
                IsMessageValid = IsMessageLengthValid(); 
            }
        }

        public int MasterId
        {
            get => _masterId;
            set
            {
                _masterId = value;
                OnPropertyChanged();
            }
        }

        public int RequestId
        {
            get => _requestId;
            set
            {
                _requestId = value;
                OnPropertyChanged();
            }
        }

        public bool IsMessageValid
        {
            get => _isMessageValid;
            private set
            {
                _isMessageValid = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }

        private bool IsMessageLengthValid()
        {
            return !string.IsNullOrEmpty(Message) && Message.Length <= 250;
        }

        private void Save()
        {
            // Add save logic 
        }

        private bool CanSave()
        {
            return IsMessageValid && !string.IsNullOrEmpty(Message);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
