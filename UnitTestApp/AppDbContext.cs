using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp
{
    public class AppDbContext : DbContext 
    {
        private string _connectionString;
        private string _assemblyName;
        public DbSet<Course> Courses { get; set; }

        public AppDbContext()
        {
            _connectionString = "Server = DESKTOP-QJ0GMMS\\SQLSERVER; Database = UnitTest; User Id = sa; Password = sa123";
            _assemblyName = Assembly.GetExecutingAssembly().FullName?? "";
            Console.WriteLine("Assembly name : {0}", _assemblyName);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }
            base.OnConfiguring(dbContextOptionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
