namespace StudRegAppPart2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student01
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Surname { get; set; }

        [Required]
        [StringLength(250)]
        public string email { get; set; }
    }
}
