using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969FinalBOP1.Models
{
    class Address : BaseModel
    {
        [Required]
        [MaxLength(50)]
        public string Address1 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address2 { get; set; }
        [Required]
        public int CityId { get; set; } 
        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
