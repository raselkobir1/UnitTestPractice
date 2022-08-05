using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp
{
    public class CourseManagement
    {
        private readonly IDbContext _dbContext;
        public CourseManagement(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateCourseAsync(string title, double fees, DateTime classStartdate)
        {
            if (! IsValidCourseTitleAsync(title))
            {
                throw new InvalidOperationException("Course title is Invalid");
            }
            fees = Math.Round(fees);
            if (classStartdate.Subtract(DateTime.Now).TotalDays < 30)
            {
                throw new Exception("Class start date should be at least 30 days ahed");
            }
            Console.WriteLine("Subtract date : {0}", classStartdate.Subtract(DateTime.Now).TotalDays);


            Course course = new Course();
            course.Title = title;
            course.Fee = fees;
            course.ClassStartDate = classStartdate;

            _dbContext.AddItem(course);
            _dbContext.Save();
        }
        private bool IsValidCourseTitleAsync(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return false;
            else if(title.Length > 100)
                return false;
            else 
                return true;

        }
    }
}
