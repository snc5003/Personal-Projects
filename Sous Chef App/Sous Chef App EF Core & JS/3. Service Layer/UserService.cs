using Sous_Chef_App.Data;
namespace Sous_Chef_App.Services;

public class UserService : IUserService
{
    private readonly IUserData _userData;
    public UserService(IUserData userDataFromBuilder)
    {
        _userData = userDataFromBuilder;
        
    }
}