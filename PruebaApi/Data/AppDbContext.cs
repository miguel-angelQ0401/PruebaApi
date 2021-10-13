using Microsoft.EntityFrameworkCore;
using PruebaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ModeloPrueba> PruebaApi { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
