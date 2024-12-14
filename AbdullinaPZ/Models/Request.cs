using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AbdullinaPZ18.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AbdullinaPZ18.Models
{
    public class Request : IRequest, INotifyPropertyChanged
    {
        private DateTime? _completeDate;
        private DateTime? _startDate;
        private string _techModel;
        private string _problem;
        private string _parts;

        [Key]
        public int RequestId { get; set; }

        [Required]
        public DateTime? StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }

        [ForeignKey("TechType")]
        public int TechTypeId { get; set; }
        public TechType TechType { get; set; }

        [Required]
        public string TechModel
        {
            get => _techModel;
            set
            {
                _techModel = value;
                OnPropertyChanged();
            }
        }

        [Required]
        [MaxLength(100, ErrorMessage = "Проблема не может быть длиннее 100 символов.")]
        public string Problem
        {
            get => _problem;
            set
            {
                _problem = value;
                OnPropertyChanged();
            }
        }

        [ForeignKey("RequestStatus")]
        public int RequestStatusId { get; set; }
        public RequestStatus RequestStatus { get; set; }

        public DateTime? CompleteDate
        {
            get => _completeDate;
            set
            {
                if (value.HasValue && value < StartDate)
                {
                    throw new InvalidOperationException("Конечная дата не может быть раньше чем дата начала.");
                }

                _completeDate = value;
                OnPropertyChanged();
            }
        }

        [MaxLength(100, ErrorMessage = "Запчасти не могут быть длиннее 100 символов.")]
        public string Parts
        {
            get => _parts;
            set
            {
                _parts = value;
                OnPropertyChanged();
            }
        }

        [ForeignKey("Master")]
        public int MasterId { get; set; }
        public User Master { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public User Client { get; set; }

        public bool IsCompleted()
        {
            return CompleteDate.HasValue && RequestStatusId == 3;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
