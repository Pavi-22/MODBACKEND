using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_PaymentService.Models
{
    public class Mentor
    {
        [Key]
        public int MentorId { get; set; }
        [Required]
        public string MentorFName { get; set; }
        [Required]
        public string MentorLName { get; set; }
        [Required]
        public string MentorPassword { get; set; }
        [Required]
        public string MentorEmail { get; set; }
        [Required]
        public string MentorMobileNo { get; set; }
        [Required]
        public string MentorSkills { get; set; }
        [Required]
        public string MentorTimeSlot { get; set; }
        [Required]
        public bool MentorAvailability { get; set; }
        [Required]
        public bool MentorActive { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> payments { get; set; }

    }
}
