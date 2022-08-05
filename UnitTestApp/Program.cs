// See https://aka.ms/new-console-template for more information
using UnitTestApp;

CourseManagement courseManagement = new CourseManagement();
await courseManagement.CreateCourseAsync("c# with unit test", 8000, new DateTime(2022, 09, 10));
