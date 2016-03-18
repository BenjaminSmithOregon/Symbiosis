using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sprint1Test.Models
{
    public class UserJob
    {
        public int UserJobID { get; set; }
        public int JobID { get; set; }
        public int UserID { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }

    }
}