using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MintHillMusic.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }

            public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<Review> Reviews { get; set; }



    }
}