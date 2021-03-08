﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToHModels;

namespace ToHDL
{
    //By inheriting the Dbcontext class, I'm estaclishing an is-a relationship between herodbcontext
    // and the dbcontext => herodbcontext is a dbcontext
    public class HeroDBContext : DbContext
    {
        public HeroDBContext(DbContextOptions options) : base(options)
        {

        }

        protected HeroDBContext()
        {

        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<SuperPower> SuperPowers { get; set; }

    }
}
