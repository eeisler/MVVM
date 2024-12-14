using AbdullinaPZ.Helpers;
using AbdullinaPZ.Views;
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
    public class UserViewModel : INotifyPropertyChanged
    {
        private User _selectedUser;

        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        public ObservableCollection<UserType> UserTypes { get; set; } = new ObservableCollection<UserType>();

        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }

        public string NewUserName { get; set; }
        public string NewPhone { get; set; }
        public string NewLogin { get; set; }
        public string NewPassword { get; set; }
        public int SelectedUserTypeId { get; set; }

        public ICommand AddUserCommand { get; }
        public ICommand DeleteUserCommand { get; }

        public UserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser);
            DeleteUserCommand = new RelayCommand(DeleteUser);

            LoadUsers();
            LoadUserTypes();
        }

        private void LoadUsers()
        {
            Users.Add(new User { UserId = 1, UserName = "John Doe", Phone = "1234567890", Login = "johndoe", Password = "password123", UserTypeId = 1 });
            Users.Add(new User { UserId = 2, UserName = "Jane Smith", Phone = "0987654321", Login = "janesmith", Password = "password123", UserTypeId = 2 });
        }

        private void LoadUserTypes()
        {
            UserTypes.Add(new UserType { UserTypeId = 1, UserTypeName = "Мастер" });
            UserTypes.Add(new UserType { UserTypeId = 2, UserTypeName = "Клиент" });
        }

        private void AddUser()
        {
            if (string.IsNullOrWhiteSpace(NewUserName) || string.IsNullOrWhiteSpace(NewPhone) || string.IsNullOrWhiteSpace(NewLogin) || string.IsNullOrWhiteSpace(NewPassword))
                return;

            if (!NewPhone.All(char.IsDigit) || NewPhone.Length != 10)
                return;

            var nextId = Users.Any() ? Users.Max(u => u.UserId) + 1 : 1;
            var newUser = new User
            {
                UserId = nextId,
                UserName = NewUserName,
                Phone = NewPhone,
                Login = NewLogin,
                Password = NewPassword,
                UserTypeId = SelectedUserTypeId
            };

            Users.Add(newUser);

            NewUserName = string.Empty;
            NewPhone = string.Empty;
            NewLogin = string.Empty;
            NewPassword = string.Empty;
            OnPropertyChanged(nameof(NewUserName));
            OnPropertyChanged(nameof(NewPhone));
            OnPropertyChanged(nameof(NewLogin));
            OnPropertyChanged(nameof(NewPassword));
        }

        private void DeleteUser()
        {
            if (SelectedUser == null)
                return;

            Users.Remove(SelectedUser);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}
