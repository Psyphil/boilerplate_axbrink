using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Public.Models;

namespace Public.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Public.Models.Meeting> Meetings { get; set; }
        public DbSet<Public.Models.MeetingItem> MeetingsItems { get; set; }
    }
}
