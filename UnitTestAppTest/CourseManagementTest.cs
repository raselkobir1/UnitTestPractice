using Autofac.Extras.Moq;
using Moq;
using NUnit.Framework;
using Shouldly;
using System;
using System.Threading.Tasks;
using UnitTestApp;

namespace UnitTestAppTest
{
    public class CourseManagementTest
    {
        private  AutoMock _mock;
        private  Mock<IDbContext> _dbContextmock;
        private CourseManagement _courseManagement; 

        [OneTimeSetUp]  //run only one before all test start. 
        public void OneTimeSetup()
        {
            _mock = AutoMock.GetLoose();
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _mock?.Dispose();
        }
        [SetUp] //run before every test start. 
        public void Setup()
        {
            _dbContextmock = _mock.Mock<IDbContext>();
            _courseManagement = _mock.Create<CourseManagement>();   
        }
        [TearDown]
        public void CleanUp()
        {
            _dbContextmock?.Reset();
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
            await Should.ThrowAsync<InvalidOperationException>(async () =>
                await _courseManagement.CreateCourseAsync(title, fee, startDate));
        }
        [Test]
        public async Task CreateCourse_validCourseValues_CreatesCourse() 
        {
            //Arrange
            const string title = "Asp.net Core";
            const double fee = 9500;
            DateTime startDate = new DateTime(2022, 10, 10);

            _dbContextmock.Setup(x=> x.AddItem(It.Is<Course>(y => y.Fee == fee && y.Title == title))).Verifiable();
            _dbContextmock.Setup(x => x.Save()).Verifiable();
            
            //Action
            await _courseManagement.CreateCourseAsync(title, fee, startDate);

            //Assert
            _dbContextmock.VerifyAll();

        }
    }
}