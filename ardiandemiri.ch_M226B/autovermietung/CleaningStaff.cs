using System;
namespace autovermietung
{
    public class CleaningStaff : Staff
    {
        protected int _cleaningID;

        public CleaningStaff(int CleaningID, int ID, Location location,
            string Name, string Surname, string PhoneNumber)
            : base(ID, location, Name, Surname, PhoneNumber)
        {
            _cleaningID = CleaningID;
            _clientID = ID;
            _location = location;
            _name = Name;
            _surname = Surname;
            _phoneNumber = PhoneNumber;
        }

        public CleaningStaff() { }
    }
}
