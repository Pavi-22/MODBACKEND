using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_UserService.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        /*[ForeignKey("Training")]
        [Required]
        public int TrainingId { get; set; }*/
        [ForeignKey("User")]
        [Required]
        public int UserId { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        [ForeignKey("Mentor")]
        public int MentorId { get; set; }
        [Required]
        public float MentorAmount { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        //public Training Training { get; set; }

    }
}
