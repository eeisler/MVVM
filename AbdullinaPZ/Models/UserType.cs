using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbdullinaPZ18.Models
{
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserTypeName { get; set; }

        public bool IsMasterRole()
        {
            return UserTypeName.Equals("Мастер", StringComparison.OrdinalIgnoreCase);
        }

        public UserType() { }

    }

}
