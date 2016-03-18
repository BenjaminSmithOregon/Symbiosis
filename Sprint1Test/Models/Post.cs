using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sprint1Test.Models
{
    public class Post
    {
        public int PostId { get; set; }

        [Required]
        [Display(Name = "Update Title")]
        [StringLength(40, ErrorMessage = "Content cannot be longer than 40 characters.")]
        public string PostTitle { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Posted on Symbiosis")]
        public DateTime PostDate { get; set; }

        [StringLength(250, ErrorMessage = "Content cannot be longer than 250 characters.")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string PostText { get; set; }


    }
}