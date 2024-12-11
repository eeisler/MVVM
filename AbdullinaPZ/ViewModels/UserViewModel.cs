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
    public class UserViewModel : INotifyPropertyChanged
    {
        private int _userId;
        private string _userName;
        private string _phone;
        private string _login;
        private string _password;
        private int _userTypeId;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ObservableCollection<UserViewModel> Requests { get; set; } = new ObservableCollection<UserViewModel>();

        private UserViewModel _selectedUser;
        public UserViewModel SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }

        public int UserId
        {
            get => _userId;
            set
            {
                _userId = value;
                OnPropertyChanged();
            }
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
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

        public ICommand SaveCommand { get; }

        public UserViewModel()
        {
            SaveCommand = new RelayCommand(Save, CanSave);
        }

        private void Save()
        {
            // to do save logic 
        }

        private bool CanSave()
        {
            return !string.IsNullOrEmpty(UserName) && Phone.Length == 10 && Phone.All(char.IsDigit);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
