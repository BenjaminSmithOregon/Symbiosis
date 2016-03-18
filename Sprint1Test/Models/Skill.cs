using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint1Test.Models
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public int SubCategoryID { get; set; }
        public String SkillName { get; set; }
        public String Link { get; set; }

        public virtual SubCategory SubCat { get; set; }
    }
}