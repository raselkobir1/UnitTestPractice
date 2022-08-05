using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp
{
    public class CourseManagement
    {
        public async Task CreateCourse(string title, double fees, DateTime classStartdate)
        {
            if (!await IsValidCourseTitleAsync(title))
            {
                throw new InvalidOperationException("Course title is Invalid");
            }
            fees = Math.Round(fees);
            if(classStartdate.Subtract(DateTime.Now).TotalDays < 30)
            {
                throw new Exception("Class start date should be at least 30 days ahed");
            }
            Console.WriteLine(classStartdate.Subtract(DateTime.Now).TotalDays);

            Course course = new Course();
            course.Title = title;
            course.Fee = fees;
            course.ClassStartDate = classStartdate;

            AppDbContext dbContext = new AppDbContext();
            dbContext.Courses.Add(course);
            dbContext.SaveChanges();
        }
        private async Task<bool> IsValidCourseTitleAsync(string title)
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
