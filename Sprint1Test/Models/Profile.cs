using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint1Test.Models
{
    public class Profile
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "User Name")]
        public string userName { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Name of Business(optional)")]
        public string businessName { get; set; }

        [Display(Name = "Email Address")]
        public string email { get; set; }

        [Display(Name = "City of Residence")]
        public string city { get; set; }

        [Display(Name = "State of Residence")]
        public string state { get; set; }

        [DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{mm/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Joined Symbiosis")]
        public string dateJoined { get; set; }

        [Display(Name = "Skills Offered")]
        public string skillsOffered { get; set; }

        [Display(Name = "Certifications/Education/Licenses")]
        public string certs { get; set; }

        public string imagePath { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}