﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrivateMessenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateMessenger.Data
{
    public class AppDbContext :IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
       public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
