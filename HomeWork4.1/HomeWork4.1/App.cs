using HomeWork4._1.Services.Abstarctions;

namespace HomeWork4._1
{
    public class App
    {
        private readonly IUserService _userService;
        
        public App(IUserService userService)
        {
            _userService = userService; 
        }

        public async Task Start()
        {
            var resource1 = await _userService.ListResource();
            var resource2 = await _userService.GetUserById(9);
            var resource3 = await _userService.SingleUserNotFound(23);
            var resource4 = await _userService.ListResource();
            var resource5 = await _userService.GetResourceById(5);
            var resource6 = await _userService.SingleResourceNotFound(23);
            var resource7 = await _userService.CreateUser("jon", "smitt");
            var resource8 = await _userService.UpdateUserPut(2, "jon", "smitt");
            var resource9 = await _userService.UpdateUserPath(2, "jon", "ssaa");
            var resource10 = await _userService.DeletedUser(20);
            var resource11 = await _userService.RegisterUser("asdn@jask", "00ad3");
            var resource12 = await _userService.RegisterUserError("asdn@jas", "00a3");
            var resource13 = await _userService.Login("a1fgd@jasas", "123sad3");
            var resource14 = await _userService.LoginError("a1fgsas", "3sad3");
            var resource15 = await _userService.GetDelayedResponse();

        }
    }
}
