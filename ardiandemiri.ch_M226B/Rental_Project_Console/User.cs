using System;
namespace Rental_Project_Console
{
    public class User
    {
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public User(Guid _userID, string _firstName, string _lastName, string _password)
        {
            UserID = _userID;
            FirstName = _firstName;
            LastName = _lastName;
            Password = _password;
        }
    }
}
