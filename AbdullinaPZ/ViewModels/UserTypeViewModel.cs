using AbdullinaPZ.Helpers;
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
    public class UserTypeViewModel : INotifyPropertyChanged
    {
        private int _userTypeId;
        private string _userTypeName;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ObservableCollection<UserTypeViewModel> Requests { get; set; } = new ObservableCollection<UserTypeViewModel>();

        private UserTypeViewModel _selectedUserType;
        public UserTypeViewModel SelectedUserType
        {
            get => _selectedUserType;
            set
            {
                _selectedUserType = value;
                OnPropertyChanged();
            }
        }

        public int UserTypeId
        {
            get => _userTypeId;
            set
            {
                _userTypeId = value;
                OnPropertyChanged();
            }
        }

        public string UserTypeName
        {
            get => _userTypeName;
            set
            {
                _userTypeName = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }

        public UserTypeViewModel()
        {
            SaveCommand = new RelayCommand(Save, CanSave);
        }

        private void Save()
        {
            // Save logic
        }

        private bool CanSave()
        {
            return !string.IsNullOrEmpty(UserTypeName);
        }

        public bool IsMasterRole()
        {
            return UserTypeName.Equals("Мастер", StringComparison.OrdinalIgnoreCase);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
