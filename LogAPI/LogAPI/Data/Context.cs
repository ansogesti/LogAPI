using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LogAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
            //Deteled database
            //Database.EnsureDeleted();

            //Create database
            Database.EnsureCreated();
        }

        public DbSet<LogModel> Logs { get; set; }
    }
}
