using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sprint1Test.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        public int CategoryID { get; set; }
        public String SubCategoryName { get; set; }

        public virtual Category Categories { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual Job Jobs { get; set; }
    }
}