using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969FinalBOP1.Models
{
    class Appointment : BaseModel
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; } 
        [Required]
        public string Location { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [MaxLength(255)]
        public string Url { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
    }
}
