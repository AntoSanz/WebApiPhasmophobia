using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPhasmophobia.Models;


namespace WebApiPhasmophobia.Data
{
    public class MapsContext : DbContext
    {
        public MapsContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Map_ES> Maps { get; set; }
    }
}

