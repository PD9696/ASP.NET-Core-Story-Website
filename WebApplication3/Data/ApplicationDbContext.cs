using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplication3.Models.Profile> Profile { get; set; }
        public DbSet<WebApplication3.Models.FollowerList> FollowerList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FollowerList>()
                .HasKey(FollowerList => new { FollowerList.ProfileId, FollowerList.FollowerId });

            modelBuilder.Entity<LikeList>()
                .HasKey(LikeList => new { LikeList.ProfileId, LikeList.StoryId });

            modelBuilder.Entity<Profile>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            modelBuilder.Entity<Story>()
                .HasOne("WebApplication3.Models.Profile")
                .WithMany()
                .HasForeignKey("ProfileId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Profile>()
                .HasOne("WebApplication3.Data.ApplicationUser")
                .WithOne()
                .HasForeignKey(typeof(Profile).ToString(), "OwnerId")
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<WebApplication3.Models.Story> Story { get; set; }
        public DbSet<WebApplication3.Models.LikeList> LikeList { get; set; }
    }
}
