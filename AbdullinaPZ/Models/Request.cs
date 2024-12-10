using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbdullinaPZ18.Models
{
    public class Request
    {
        [Key]
        public int RequestId {  get; private set; }

        [Required]
        public DateTime? StartDate { get; set; }

        [ForeignKey("TechType")]
        public int TechTypeId { get; set; }
        public TechType TechType { get; set; }

        [Required]
        public string TechModel { get; set; }

        [Required]
        [MaxLength(100)]
        public string Problem {  get; set; }

        [ForeignKey("RequestStatus")]
        public int RequestStatusId { get; set; }
        public RequestStatus RequestStatus { get; set; }

        public DateTime? CompleteDate { get; set; }           // to do: check wether the complete date is more than start date           
        
        [MaxLength(100)]
        public string Parts { get; set; }

        [ForeignKey("Master")]                             // to do: make validation if not master deny
        public int MasterId { get; set; }
        public User Master { get; set; }

        [ForeignKey("Client")]                             // to do: the same as above but for client
        public int ClientId { get; set; }
        public User Client { get; set; }

        public bool IsCompleted()
        {
            return CompleteDate.HasValue && RequestStatusId == 3;
        }
    }
}
