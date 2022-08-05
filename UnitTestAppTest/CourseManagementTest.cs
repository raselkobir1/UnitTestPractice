using NUnit.Framework;
using Shouldly;
using System;
using System.Threading.Tasks;
using UnitTestApp;

namespace UnitTestAppTest
{
    public class CourseManagementTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public async Task CreateCourse_TitleMissing_ThrowsException(string title)
        {
            //Arrange
            //var title = string.Empty;
            const double fee = 9000;
            DateTime startDate = new DateTime(2022, 09, 25);

            //Act
            CourseManagement courseManagement = new CourseManagement();

            await Should.ThrowAsync<InvalidOperationException>(async () =>
                await courseManagement.CreateCourseAsync(title, fee, startDate));
        }
        [Test]
        public async Task CreateCourse_validCourseValues_CreatesCourse() 
        {
            //Arrange
            const string title = "Asp.net Core";
            const double fee = 9500;
            DateTime startDate = new DateTime(2022, 10, 10);

            //Action
            CourseManagement courseManagement = new CourseManagement();
            await courseManagement.CreateCourseAsync(title, fee, startDate);
        }
    }
}