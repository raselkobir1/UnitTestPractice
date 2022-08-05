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
        public async Task CreateCourse_TitleMissing_ThrowsException()
        {
            //Arrange
            var title = string.Empty;
            const double fee = 9000;
            DateTime startDate = new DateTime(2022, 09, 25);

            //Act
            CourseManagement courseManagement = new CourseManagement();

            await Should.ThrowAsync<InvalidOperationException>(async () =>
                await courseManagement.CreateCourse(title, fee, startDate));
             

        }
    }
}