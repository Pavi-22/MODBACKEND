using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_UserService.Models
{
    public class Technology
    {
        [Key]
        public int SkillId { get; set; }
        [Required]
        public string SkillName { get; set; }
        [Required]
        public string TOC { get; set; }
        [Required]
        public double fee { get; set; }
        [Required]
        public int Duration { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
    }
}
