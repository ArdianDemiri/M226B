using System;
using System.Collections.Generic;

namespace autovermietung
{
    public class Location : Business
    {
        private List<Staff> _staffs = new List<Staff>();
        private string _location;

        public Location(string Name, string Website, List<Staff> Staffs, string Location)
            : base(Name, Website)
        {
            _businessName = Name;
            _website = Website;
            _staffs = Staffs;
            _location = Location;
        }

        public Location() { }

        //_staffs
        public List<Staff> Staffs
        {
            get { return _staffs; }
            set
            {
                if (Staffs != null)
                {
                    _staffs = value;
                }
            }
        }

        //_location
        public string Location_P
        {
            get { return _location; }
            set
            {
                if (Location_P != null)
                {
                    _location = value;
                }
            }
        }
    }
}
