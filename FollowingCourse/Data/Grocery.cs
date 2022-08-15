using System;
using System.ComponentModel.DataAnnotations;

namespace FollowingCourse
{

    public class Grocery
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should be less than 15")]
        public string? Name { get; set; }

        [Required]
        [Range(1,1000, ErrorMessage = "Please Enter A Valid Price Range")]
        public float price { get; set; }
    }

}

