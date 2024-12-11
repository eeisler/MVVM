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
    public class TechTypeViewModel : INotifyPropertyChanged
    {
        private int _techTypeId;
        private string _techTypeName;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ObservableCollection<TechTypeViewModel> TechType { get; set; } = new ObservableCollection<TechTypeViewModel>();

        private TechTypeViewModel _selectedTechType;
        public TechTypeViewModel SelectedTechType
        {
            get => _selectedTechType;
            set
            {
                _selectedTechType = value;
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

        public string TechTypeName
        {
            get => _techTypeName;
            set
            {
                _techTypeName = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }

        public TechTypeViewModel()
        {
            SaveCommand = new RelayCommand(Save, CanSave);
        }

        private void Save()
        {
            // Save logic make
        }

        private bool CanSave()
        {
            return !string.IsNullOrEmpty(TechTypeName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
