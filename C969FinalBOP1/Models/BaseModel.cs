using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969FinalBOP1.Models
{
    class BaseModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } 
        [Required]
        [MaxLength(40)]
        public string LastUpdatedBy { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
    }
}
