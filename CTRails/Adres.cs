using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails
{
    class Adres
    {
        private string street;
        private int number;
        private string city;
        private string country;
        private string postalCode;
        public Adres(string street, int number, string city, string country, string postalCode)
        {
            this.street = street;
            this.number = number;
            this.city = city;
            this.country = country;
            this.postalCode = postalCode;
        }
        
        public void EditAdres(Adres adres) { }
        public void RemoveAdres(Adres adres) { }
    }
}
