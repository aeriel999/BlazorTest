﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp2;

namespace BlazorApp2.Data
{
    public class BlazorApp2Context : DbContext
    {
        public BlazorApp2Context (DbContextOptions<BlazorApp2Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp2.Movie> Movie { get; set; } = default!;
    }
}