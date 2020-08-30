using System;
namespace autovermietung
{
    public class CleaningStaff : Staff
    {
        private int _cleaningID;

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

        //_cleaningID
        public int CleaningID
        {
            get { return _cleaningID; }
            set
            {
                if (CleaningID >= 0)
                {
                    _cleaningID = CleaningID;
                }
            }
        }
    }
}
