/* 
     * Paul Hood
     * CIT 195 Lesson 4
     * 3/13/2013
     * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Address_Book
{
    public class Contact
    {
        // Public properties representing features of a Contact object
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ImageFileName { get; set; }

        // Constructor for new Contact object
        public Contact()
        {
            // Assign empty strings instead of nulls
            this.Name = string.Empty;
            this.Street = string.Empty;
            this.City = string.Empty;
            this.State = string.Empty;
            this.ZipCode = string.Empty;
            this.ImageFileName = string.Empty;
        }

        // returns address information
        public String address()
        {
            string address = this.Street + "\n  " + this.City + "," + this.State + " " + this.ZipCode;
            return address;
        }
    }
}
