using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPhasmophobia.Models;

namespace WebApiPhasmophobia.Data
{
    public class GhostsContext : DbContext
    {
        public GhostsContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Ghost_ES> Ghosts { get; set; }
    }
}

