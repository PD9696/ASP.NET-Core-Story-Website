using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Profile
    {
        public int Id { get; set; }

        [StringLength(450)]
        public string OwnerId { get; set; }

        [StringLength(20)]
        [Required]
        public string UserName { get; set; }

        [StringLength(150)]
        public string QuickDescription { get; set; }

        [StringLength(1000)]
        public string Biography { get; set; }

        public int Followers { get; set; }

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        public int GetProfileId()
        {
            return Id;
        }

        public void SetOwnerId(string ownerId)
        {
            OwnerId = ownerId;
        }
    }
}
