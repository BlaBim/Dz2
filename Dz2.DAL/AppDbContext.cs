using Dz2.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dz2
{
     public  class AppDbContext : DbContext
    {
        private string _conectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UN;Integrated Security=True;Connect Timeout=30;";

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conectionString);
        }
    }
}
