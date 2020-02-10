using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969FinalBOP1.Models
{
    class Country : BaseModel
    {
        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; }

    }
}
 