using System;
namespace autovermietung
{
    public class Business
    {
        private string _businessName;
        private string _website;

        public Business(string Name, string Website)
        {
            _businessName = Name;
            _website = Website;
        }

        public Business() { }
    }
}
