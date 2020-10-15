using System;
namespace autovermietung
{
    public class Business
    {
        protected string _businessName;
        protected string _website;

        public Business(string Name, string Website)
        {
            _businessName = Name;
            _website = Website;
        }

        //_businessName
        public Business() { }

        public string BusinessName
        {
            get { return _businessName; }
            set
            {
                if(BusinessName != null)
                {
                    _businessName = value;
                }
            }
        }

        //_website
        public string Website
        {
            get { return _website; }
            set
            {
                if (Website != null)
                {
                    _website = value;
                }
            }
        }
    }
}
