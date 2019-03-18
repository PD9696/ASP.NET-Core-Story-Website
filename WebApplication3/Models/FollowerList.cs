using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class FollowerList
    {
        public int ProfileId { get; set; }
        
        public int FollowerId { get; set; }
    }
}
