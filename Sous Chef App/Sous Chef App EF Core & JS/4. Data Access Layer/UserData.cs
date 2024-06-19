using Sous_Chef_App.Models;

namespace Sous_Chef_App.Data;

public class UserData : IUserData
{
    private readonly DataContext _dataContext;
    public UserData(DataContext dataContextFromBuilder)
    {
        _dataContext = dataContextFromBuilder;
    }
}