using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sprint1Test.Models
{
    public class Job
    {
        public enum Rating
        {
            one, two, three, four, five
        }

        public int JobID { get; set; }
        public String City { get; set; }
        public String State { get; set; }

        [Display(Name = "Skill Area")]
        public int skillID { get; set; }

        [DataType(DataType.Date)]
        public DateTime JobDate { get; set; }
        public string JobDetails { get; set; }
        public Rating? JobRating { get; set; }

        [Display(Name = "User Hired")]
        public int UserId { get; set; }

        public virtual ApplicationUser Users { get; set; }
        public virtual ICollection<Skill> skills { get; set; }

    }
}