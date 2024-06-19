namespace Sous_Chef_App.Models;

public class Users
{
    public Guid userId {get; set;}
    public string password {get; set;}
    public string? userName {get; set;}
    public string firstName {get; set;}
    public string lastName {get; set;}
    public DateOnly birthday {get; set;}
    public int zipCode {get; set;}
    public int glutenFree {get; set;}
    public int dairyFree {get; set;} // a scale of how dairy free they are
    
    public Users(){}

    public Users(string _userName, string _password)
    {
        userId = Guid.NewGuid();
        userName = _userName;
        password = _password;
    }

}

