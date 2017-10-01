using System;
using System.ComponentModel.DataAnnotations;

namespace MintHillMusic.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int InstructorID { get; set; }

            public virtual Instructor Instructor { get; set; }

        [Required()]
        [Display(Name ="Review")]
        public string Contents { get; set; }

        [Required()]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)] 
        public string ReviewerEmail { get; set; }
    }
}