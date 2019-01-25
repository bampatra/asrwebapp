using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASRWebApp.Models
{
    public class AsrContext : IdentityDbContext<ApplicationUser>
    {
        public AsrContext(DbContextOptions<AsrContext> options) : base(options)
        { }

        public DbSet<Room> Room { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Slot> Slot { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Slot>().HasKey(x => new { x.RoomID, x.StartTime });
        }

    }
}
