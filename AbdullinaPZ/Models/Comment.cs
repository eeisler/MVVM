using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullinaPZ18.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; private set; }

        [Required]
        [MaxLength(200)]
        public string Message { get; set; }

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

    }
}
