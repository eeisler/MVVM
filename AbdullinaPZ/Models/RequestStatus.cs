using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbdullinaPZ18.Models
{
    public class RequestStatus
    {
        [Key]
        public int RequestStatusId { get; private set; }

        [Required]
        [MaxLength(100)]
        public string RequestStatusName { get; set; }
    }
}
