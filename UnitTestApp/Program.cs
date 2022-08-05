// See https://aka.ms/new-console-template for more information
using UnitTestApp;

CourseManagement courseManagement = new CourseManagement(new DbContextConcrete(new AppDbContext()));
await courseManagement.CreateCourseAsync("c# with .Net Core", 8000, new DateTime(2022, 09, 10));

Console.WriteLine("Call program class");
