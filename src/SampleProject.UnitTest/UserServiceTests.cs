using NSubstitute;
using NUnit.Framework;
using SampleProject.Dtos;
using SampleProject.Services;

namespace SampleProject.UnitTest
{
    public class UserServiceTests
    {
        private IUserRepo _userRepo;

        [SetUp]
        public void Setup()
        {
            _userRepo = Substitute.For<IUserRepo>();
        }

        [Test]
        public void CreateUser_FirstNameIsWelch_SetErrorMessage()
        {
            // Arrange
            _userRepo.CreateUser().Returns(new GetUserResponse
            {
                Id = 7,
                FirstName = "Welch (from mock)",
                LastName = "Smith (from mock)",
                Age = 300,
                ErrorMessage = "Welch found!"
            });
            var userService = new UserService(_userRepo);

            // Act
            var user = userService.CreateUser();

            // Assert
            Assert.That(user.FirstName, Is.EqualTo("Welch (from mock)"));
            Assert.That(user.ErrorMessage, Is.EqualTo("Welch found!"));
        }
    }
}