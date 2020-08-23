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
    }
}
