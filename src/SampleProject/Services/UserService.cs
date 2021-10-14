using SampleProject.Dtos;

namespace SampleProject.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public GetUserResponse CreateUser()
        {
            var newUser = _userRepo.CreateUser();

            if (newUser.FirstName == "Welch")
            {
                newUser.ErrorMessage = "Welch found!";
            }

            return newUser;
        }
    }
}
