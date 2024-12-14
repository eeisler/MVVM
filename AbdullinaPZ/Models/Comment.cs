using AbdullinaPZ18.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbdullinaPZ18.Models
{
    public class Comment : IComment, INotifyPropertyChanged
    {
        private string _message;

        [Key]
        public int CommentId { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Сообщение не может быть длиннее 200 символов.")]
        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        [ForeignKey("Master")]
        public int MasterId { get; set; }
        public User Master { get; set; }

        [ForeignKey("Request")]
        public int RequestId { get; set; }
        public Request Request { get; set; }

        public bool IsMessageLengthValid()
        {
            return Message.Length <= 250;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
