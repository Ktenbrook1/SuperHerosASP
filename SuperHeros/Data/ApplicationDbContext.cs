﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHeros.Models;

namespace SuperHeros.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHero> SuperHeros { get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
