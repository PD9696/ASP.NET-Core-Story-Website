using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Story
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }

        public int Likes { get; set; }

        public int EstimatedLength { get; set; }

        public int EstimatedLengthSeconds { get; set; }

        public bool IsEdited { get; set; }

        [Display(Name = "Edit Date")]
        [DataType(DataType.Date)]
        public DateTime EditDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [StringLength(20)]
        public string Author { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9""'\s-$%#!?.,:;’/_–”“…]*$", ErrorMessage = "Only letters, numbers, or $ and # symbols are allowed")]
        [StringLength(150)]
        [Required]
        public string Title { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9""'\s-$%#!?.,:;’/_–”“…]*$", ErrorMessage = "Only letters, numbers, or $ and # symbols are allowed")]
        [StringLength(40000)]
        [Required]
        public string Content { get; set; }
    }
}