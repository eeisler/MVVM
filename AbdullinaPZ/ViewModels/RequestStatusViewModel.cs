using AbdullinaPZ.Helpers;
using AbdullinaPZ18.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private RequestStatus _selectedRequestStatus;

        public ObservableCollection<RequestStatus> RequestStatuses { get; set; } = new ObservableCollection<RequestStatus>();

        public RequestStatus SelectedRequestStatus
        {
            get => _selectedRequestStatus;
            set
            {
                _selectedRequestStatus = value;
                OnPropertyChanged();
            }
        }

        public string NewRequestStatusName { get; set; }

        public ICommand AddRequestStatusCommand { get; }
        public ICommand DeleteRequestStatusCommand { get; }

        public RequestStatusViewModel()
        {
            AddRequestStatusCommand = new RelayCommand(AddRequestStatus);
            DeleteRequestStatusCommand = new RelayCommand(DeleteRequestStatus);

            LoadRequestStatuses();
        }

        private void LoadRequestStatuses()
        {
            RequestStatuses.Add(new RequestStatus { RequestStatusId = 1, RequestStatusName = "New" });
            RequestStatuses.Add(new RequestStatus { RequestStatusId = 2, RequestStatusName = "In Progress" });
            RequestStatuses.Add(new RequestStatus { RequestStatusId = 3, RequestStatusName = "Completed" });
        }

        private void AddRequestStatus()
        {
            if (string.IsNullOrWhiteSpace(NewRequestStatusName))
                return;

            var nextId = RequestStatuses.Any() ? RequestStatuses.Max(rs => rs.RequestStatusId) + 1 : 1;
            var newRequestStatus = new RequestStatus
            {
                RequestStatusId = nextId,
                RequestStatusName = NewRequestStatusName
            };

            RequestStatuses.Add(newRequestStatus);

            NewRequestStatusName = string.Empty;
            OnPropertyChanged(nameof(NewRequestStatusName));
        }

        private void DeleteRequestStatus()
        {
            if (SelectedRequestStatus == null)
                return;

            RequestStatuses.Remove(SelectedRequestStatus);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
