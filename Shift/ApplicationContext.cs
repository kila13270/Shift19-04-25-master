﻿using Microsoft.EntityFrameworkCore;
using Shift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=postgres");
        }
    }
}
