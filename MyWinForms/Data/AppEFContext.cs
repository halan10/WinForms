using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinForms.Data
{
    public class AppEFContext : DbContext

    {
        public AppEFContext()
        { 
        this.Database.EnsureCreated();
        }
        public DbSet<AppUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sql = optionsBuilder.UseSqlServer("Server=DESKTOP-NF3RPRE\\SQLEXPRESS; Integrated Security = True; Initial Catalog = HW1.2.3");

        }
    }
}
