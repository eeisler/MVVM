using AbdullinaPZ.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AbdullinaPZ.ViewModels
{
    public class RequestViewModel : INotifyPropertyChanged
    {
        private int _requestId;
        private DateTime? _startDate;
        private int _techTypeId;
        private string _techModel;
        private string _problem;
        private int _requestStatusId;
        private DateTime? _completeDate;
        private string _parts;
        private int _masterId;
        private int _clientId;

        public RequestViewModel()
        {
            SaveCommand = new RelayCommand(Save, CanSave);
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

        public DateTime? StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }

        public int TechTypeId
        {
            get => _techTypeId;
            set
            {
                _techTypeId = value;
                OnPropertyChanged();
            }
        }

        public string TechModel
        {
            get => _techModel;
            set
            {
                _techModel = value;
                OnPropertyChanged();
            }
        }

        public string Problem
        {
            get => _problem;
            set
            {
                _problem = value;
                OnPropertyChanged();
            }
        }

        public int RequestStatusId
        {
            get => _requestStatusId;
            set
            {
                _requestStatusId = value;
                OnPropertyChanged();
            }
        }

        public DateTime? CompleteDate
        {
            get => _completeDate;
            set
            {
                _completeDate = value;
                OnPropertyChanged();
                ValidateCompletionDate();
            }
        }

        public string Parts
        {
            get => _parts;
            set
            {
                _parts = value;
                OnPropertyChanged();
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

        public int ClientId
        {
            get => _clientId;
            set
            {
                _clientId = value;
                OnPropertyChanged();
            }
        }

        private bool _isCompletionDateValid;
        public bool IsCompletionDateValid
        {
            get => _isCompletionDateValid;
            private set
            {
                _isCompletionDateValid = value;
                OnPropertyChanged();
            }
        }

        private void ValidateCompletionDate()
        {
            IsCompletionDateValid = !CompleteDate.HasValue || (StartDate.HasValue && CompleteDate > StartDate);
        }

        public bool IsCompleted => CompleteDate.HasValue && RequestStatusId == 3;

        public ICommand SaveCommand { get; }

        private void Save()
        {
            // Save logic 
        }

        private bool CanSave()
        {
            return !string.IsNullOrEmpty(TechModel) &&
                   !string.IsNullOrEmpty(Problem) &&
                   StartDate.HasValue &&
                   MasterId > 0 &&
                   ClientId > 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

