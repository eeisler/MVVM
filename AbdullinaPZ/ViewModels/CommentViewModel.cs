using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AbdullinaPZ.Helpers;
using AbdullinaPZ18.Interfaces;
using AbdullinaPZ18.Models;
using System.Collections.ObjectModel;

namespace AbdullinaPZ.ViewModels
{
    public class CommentViewModel : INotifyPropertyChanged
    {
        private Comment _selectedComment;

        public ObservableCollection<Comment> Comments { get; set; } = new ObservableCollection<Comment>();

        public Comment SelectedComment
        {
            get => _selectedComment;
            set
            {
                _selectedComment = value;
                OnPropertyChanged();
            }
        }

        public string NewCommentMessage { get; set; }
        public int NewCommentMasterId { get; set; }
        public int NewCommentRequestId { get; set; }

        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }

        public CommentViewModel()
        {
            AddCommand = new RelayCommand(AddComment);
            DeleteCommand = new RelayCommand(DeleteComment);

            LoadComments();
        }

        private void LoadComments()
        {
            
        }

        private void AddComment()
        {
            if (string.IsNullOrWhiteSpace(NewCommentMessage) || NewCommentMasterId == 0 || NewCommentRequestId == 0)
                return;

            var nextId = Comments.Any() ? Comments.Max(c => c.CommentId) + 1 : 1;
            var newComment = new Comment
            {
                CommentId = nextId,
                Message = NewCommentMessage,
                MasterId = NewCommentMasterId,
                RequestId = NewCommentRequestId
            };

            Comments.Add(newComment);

            NewCommentMessage = string.Empty;
            OnPropertyChanged(nameof(NewCommentMessage));
        }

        private void DeleteComment()
        {
            if (SelectedComment == null)
                return;

            Comments.Remove(SelectedComment);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
