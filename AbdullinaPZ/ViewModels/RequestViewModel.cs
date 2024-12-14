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
    public class RequestViewModel : INotifyPropertyChanged
    {
        private Request _selectedRequest;

        public ObservableCollection<Request> Requests { get; set; } = new ObservableCollection<Request>();

        public Request SelectedRequest
        {
            get => _selectedRequest;
            set
            {
                _selectedRequest = value;
                OnPropertyChanged();
            }
        }

        public DateTime? NewRequestStartDate { get; set; }
        public int NewRequestTechTypeId { get; set; }
        public string NewRequestTechModel { get; set; }
        public string NewRequestProblem { get; set; }
        public int NewRequestRequestStatusId { get; set; }
        public DateTime? NewRequestCompleteDate { get; set; }
        public string NewRequestParts { get; set; }
        public int NewRequestMasterId { get; set; }
        public int NewRequestClientId { get; set; }

        public ICommand AddRequestCommand { get; }
        public ICommand DeleteRequestCommand { get; }

        public RequestViewModel()
        {
            AddRequestCommand = new RelayCommand(AddRequest);
            DeleteRequestCommand = new RelayCommand(DeleteRequest);

            LoadRequests();
        }

        private void LoadRequests()
        {
            Requests.Add(new Request
            {
                RequestId = 1,
                StartDate = DateTime.Now,
                TechTypeId = 1,
                TechModel = "Model A",
                Problem = "Issue with model A",
                RequestStatusId = 1,
                CompleteDate = null,
                Parts = "Spare parts for A",
                MasterId = 1,
                ClientId = 1
            });
        }

        private void AddRequest()
        {
            if (string.IsNullOrWhiteSpace(NewRequestTechModel) || string.IsNullOrWhiteSpace(NewRequestProblem) ||
                NewRequestTechTypeId == 0 || NewRequestRequestStatusId == 0 || NewRequestMasterId == 0 || NewRequestClientId == 0)
                return;

            var nextId = Requests.Any() ? Requests.Max(r => r.RequestId) + 1 : 1;
            var newRequest = new Request
            {
                RequestId = nextId,
                StartDate = NewRequestStartDate,
                TechTypeId = NewRequestTechTypeId,
                TechModel = NewRequestTechModel,
                Problem = NewRequestProblem,
                RequestStatusId = NewRequestRequestStatusId,
                CompleteDate = NewRequestCompleteDate,
                Parts = NewRequestParts,
                MasterId = NewRequestMasterId,
                ClientId = NewRequestClientId
            };

            Requests.Add(newRequest);

            ClearNewRequestData();
            OnPropertyChanged(nameof(NewRequestStartDate));
            OnPropertyChanged(nameof(NewRequestTechTypeId));
            OnPropertyChanged(nameof(NewRequestTechModel));
            OnPropertyChanged(nameof(NewRequestProblem));
            OnPropertyChanged(nameof(NewRequestRequestStatusId));
            OnPropertyChanged(nameof(NewRequestCompleteDate));
            OnPropertyChanged(nameof(NewRequestParts));
            OnPropertyChanged(nameof(NewRequestMasterId));
            OnPropertyChanged(nameof(NewRequestClientId));
        }

        private void DeleteRequest()
        {
            if (SelectedRequest == null)
                return;

            Requests.Remove(SelectedRequest);
        }

        private void ClearNewRequestData()
        {
            NewRequestStartDate = null;
            NewRequestTechTypeId = 0;
            NewRequestTechModel = string.Empty;
            NewRequestProblem = string.Empty;
            NewRequestRequestStatusId = 0;
            NewRequestCompleteDate = null;
            NewRequestParts = string.Empty;
            NewRequestMasterId = 0;
            NewRequestClientId = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

