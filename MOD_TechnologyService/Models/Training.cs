using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TechnologyService.Models
{
    public class Training
    {
        [Key]
        public int TrainingId { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Mentor")]
        [Required]
        public int MentorId { get; set; }
        [Required]
        [ForeignKey("Technology")]
        public int SkillId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string timeslot { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public string Progress { get; set; }
        [Required]
        public int rating { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        public Technology Technology { get; set; }
        //public IEnumerable<Payment> Payments { get; set; }

    }
}