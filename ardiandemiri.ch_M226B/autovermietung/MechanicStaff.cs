using System;
namespace autovermietung
{
    public class MechanicStaff : Staff
    {
        protected int _mechanicID;

        public MechanicStaff(int MechanicID, int ID, Location location,
            string Name, string Surname, string PhoneNumber)
            : base(ID, location, Name, Surname, PhoneNumber)
        {
            _mechanicID = MechanicID;
            _clientID = ID;
            _location = location;
            _name = Name;
            _surname = Surname;
            _phoneNumber = PhoneNumber;
        }

        public MechanicStaff() { }
    }
}
