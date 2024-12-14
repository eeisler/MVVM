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
    public class TechTypeViewModel : INotifyPropertyChanged
    {
        private TechType _selectedTechType;

        public ObservableCollection<TechType> TechTypes { get; set; } = new ObservableCollection<TechType>();

        public TechType SelectedTechType
        {
            get => _selectedTechType;
            set
            {
                _selectedTechType = value;
                OnPropertyChanged();
            }
        }

        public string NewTechTypeName { get; set; }

        public ICommand AddTechTypeCommand { get; }
        public ICommand DeleteTechTypeCommand { get; }

        public TechTypeViewModel()
        {
            AddTechTypeCommand = new RelayCommand(AddTechType);
            DeleteTechTypeCommand = new RelayCommand(DeleteTechType);

            LoadTechTypes();
        }

        private void LoadTechTypes()
        {
            TechTypes.Add(new TechType { TechTypeId = 1, TechTypeName = "Electronics" });
            TechTypes.Add(new TechType { TechTypeId = 2, TechTypeName = "Appliances" });
        }

        private void AddTechType()
        {
            if (string.IsNullOrWhiteSpace(NewTechTypeName))
                return;

            var nextId = TechTypes.Any() ? TechTypes.Max(tt => tt.TechTypeId) + 1 : 1;
            var newTechType = new TechType
            {
                TechTypeId = nextId,
                TechTypeName = NewTechTypeName
            };

            TechTypes.Add(newTechType);

            NewTechTypeName = string.Empty;
            OnPropertyChanged(nameof(NewTechTypeName));
        }

        private void DeleteTechType()
        {
            if (SelectedTechType == null)
                return;

            TechTypes.Remove(SelectedTechType);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
