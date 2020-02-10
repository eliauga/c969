using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969FinalBOP1.Models
{
    class Customer : BaseModel
    {
        [Required]
        [MaxLength(45)]
        public string CustomerName { get; set; }
        [Required]
        public int AddressId { get; set; }
        [Required]
        public byte Active { get; set; }

    }
} 
