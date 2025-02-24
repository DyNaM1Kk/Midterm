﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Midterm.Models;

namespace Midterm.Data
{
    public class MidtermContext : DbContext
    {
        public MidtermContext (DbContextOptions<MidtermContext> options)
            : base(options)
        {
        }

        public DbSet<Midterm.Models.Book> Book { get; set; } = default!;
    }
}
