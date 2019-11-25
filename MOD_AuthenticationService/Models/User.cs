using MOD_AuthenticationService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_AuthenticationService.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(10)]
        public string UserFName { get; set; }
        [Required]
        public string UserLName { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string UserMobileNo { get; set; }
        [Required]
        public bool UserActive { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> payments { get; set; }
    }
}
