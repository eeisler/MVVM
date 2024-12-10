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
    public class RequestStatusViewModel : INotifyPropertyChanged
    {
        private int _requestStatusId;
        private string _requestStatusName;

        public int RequestStatusId
        {
            get => _requestStatusId;
            set
            {
                _requestStatusId = value;
                OnPropertyChanged();
            }
        }

        public string RequestStatusName
        {
            get => _requestStatusName;
            set
            {
                _requestStatusName = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }

        public RequestStatusViewModel()
        {
            SaveCommand = new RelayCommand(Save, CanSave);
        }

        private void Save()
        {
            // Save logic 
        }

        private bool CanSave()
        {
            return !string.IsNullOrEmpty(RequestStatusName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
