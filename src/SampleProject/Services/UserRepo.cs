using SampleProject.Dtos;

namespace SampleProject.Services
{
    public class UserRepo : IUserRepo
    {
        public GetUserResponse CreateUser()
        {
            return new GetUserResponse
            {
                Id = 1,
                FirstName = "John (Original Service)",
                LastName = "Smith (Original Service)",
                Age = 100
            };
        }
    }
}
