using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
        public class Custumer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        private DateTime birthDay;
            public string Address { get; set; }

        private List<Invoice> invoices = new List <Invoice>();
        public List<Invoice>Invoices { get { return invoices; } }
            public string Zip { get; set; }

            public string City { get; set; }

            public string PhoneNumber { get; set; }

            public Custumer(string firstname, string lastname, string address, string zip, string city)
            {
                FirstName = firstname;
                LastName = lastname;
                Address = address;
                Zip = zip;
                City = city;
            }

        public DateTime Birthdate
        {
            set
            {
                if ((DateTime.Now.Year - value.Year)>120 && (DateTime.Now.Year - value.Year) < 0)
                {
                    throw new Exception ("Age is not accepted");
                }
                else
                {
                    this.birthDay = value;
                }
            }
            get { return this.birthDay; }
        }


        public List<string> PhoneNumbers { get; } = new List<string>();
        
        
        //method
        public void AddPhone (string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public void AddInvoice (Invoice invoice)
        {
            Invoices.Add(invoice);
        }
        public Custumer()
        {
        }
    }

    }

