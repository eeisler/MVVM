using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AbdullinaPZ18.Models
{
    public class TechType
    {
        [Key]
        public int TechTypeId { get; set; } 

        [Required]
        [MaxLength(100)]
        public string TechTypeName { get; set; }

        public TechType() { }
    }
}
