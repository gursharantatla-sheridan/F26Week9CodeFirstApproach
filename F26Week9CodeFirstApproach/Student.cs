using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace F26Week9CodeFirstApproach
{
    public class Student
    {
        // scalar properties
        public int StudentId { get; set; }
        [Column("Name")]
        public string? StudentName { get; set; }
        public int? StandardId { get; set; }
        public int? Age { get; set; }

        // navigation property
        public Standard? Standard { get; set; }
    }
}
