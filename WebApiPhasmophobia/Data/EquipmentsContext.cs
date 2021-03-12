using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiPhasmophobia.Models;

namespace WebApiPhasmophobia.Data
{
    public class EquipmentsContext : DbContext
    {
        public EquipmentsContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Equipment_ES> Equipments { get; set; }
    }
}
