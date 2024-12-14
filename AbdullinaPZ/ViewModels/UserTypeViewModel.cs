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
    public class UserTypeViewModel : INotifyPropertyChanged
    {
        private UserType _selectedUserType;

        public ObservableCollection<UserType> UserTypes { get; set; } = new ObservableCollection<UserType>();

        public UserType SelectedUserType
        {
            get => _selectedUserType;
            set
            {
                _selectedUserType = value;
                OnPropertyChanged();
            }
        }

        public string NewUserTypeName { get; set; }

        public ICommand AddUserTypeCommand { get; }
        public ICommand DeleteUserTypeCommand { get; }

        public UserTypeViewModel()
        {
            AddUserTypeCommand = new RelayCommand(AddUserType);
            DeleteUserTypeCommand = new RelayCommand(DeleteUserType);

            LoadUserTypes();
        }

        private void LoadUserTypes()
        {
            UserTypes.Add(new UserType { UserTypeId = 1, UserTypeName = "Мастер" });
            UserTypes.Add(new UserType { UserTypeId = 2, UserTypeName = "Клиент" });
        }

        private void AddUserType()
        {
            if (string.IsNullOrWhiteSpace(NewUserTypeName))
                return;

            var nextId = UserTypes.Any() ? UserTypes.Max(ut => ut.UserTypeId) + 1 : 1;
            var newUserType = new UserType
            {
                UserTypeId = nextId,
                UserTypeName = NewUserTypeName
            };

            UserTypes.Add(newUserType);

            NewUserTypeName = string.Empty;
            OnPropertyChanged(nameof(NewUserTypeName));
        }

        private void DeleteUserType()
        {
            if (SelectedUserType == null)
                return;

            UserTypes.Remove(SelectedUserType);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
