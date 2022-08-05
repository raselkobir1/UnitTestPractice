using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp
{
    public class DbContextConcrete : IDbContext
    {
        private readonly AppDbContext _context;
        public DbContextConcrete(AppDbContext context)
        {
            _context = context; 
        }
        public void AddItem(Course course)
        {
            _context.Courses.Add(course);   
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
