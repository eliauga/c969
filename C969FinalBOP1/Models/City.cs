using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969FinalBOP1.Models
{
    class City : BaseModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int CountryId { get; set; } 
    }
}
