namespace CTRails
{
    public class Address
    {
        //Fields
        public string StreetName { get; private set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string Country { get; private set; }
        public string Zipcode { get; set; }
        public string Addition { get; private set; }

        //Constructor
        public Address(string streetName, int number, string city, string country, string zipcode, string addition)
        {
            StreetName = streetName;
            Number = number;
            City = city;
            Country = country;
            Zipcode = zipcode;
            Addition = addition;
        }
    }
}
