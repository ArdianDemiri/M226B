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

        public Business() { }
    }
}
