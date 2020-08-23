using System;
using System.Collections.Generic;

namespace autovermietung
{
    public class Location : Business
    {
        protected List<Staff> _staffs = new List<Staff>();
        protected string _location;

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
