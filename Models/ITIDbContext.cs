using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDEFDay2.Models
{
    public class ITIDbContext:DbContext
    {

        public virtual DbSet<post> Posts { get; set; }
        public virtual DbSet<Author> Authors{ get; set; }
        public virtual DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=ADELSHADY\\SQLSERVER;Initial Catalog=ITIV2;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
