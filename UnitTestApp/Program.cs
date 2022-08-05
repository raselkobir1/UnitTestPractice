// See https://aka.ms/new-console-template for more information
using UnitTestApp;

CourseManagement courseManagement = new CourseManagement();
await courseManagement.CreateCourse("c#", 8000, new DateTime(2022, 12, 12));
